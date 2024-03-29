using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Security.Principal;
using System.Windows.Forms;
using WinTweakTool.components;
using Button = System.Windows.Forms.Button;

namespace WinTweakTool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            OperatingSystem os = Environment.OSVersion;
            WinVerText.Text = $"WinVer: {os.Version}";

            bool isAdmin;
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!isAdmin)
            {
                NotAdminText.Text = "Not running as admin!\nThings might not work.";
            }

            this.Text = $"WTTk v{Global.version[0]}.{Global.version[1]}.{Global.version[2]}";
        }

        private void RestartExplorer_Click(object sender, EventArgs e)
        {
            foreach (Process hopefullyExporer in Process.GetProcesses())
            {
                if (hopefullyExporer.ProcessName.StartsWith("explorer"))
                {
                    hopefullyExporer.Kill();
                    break;
                }
            }
        }

        private void WebLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            if (Global.updateAvailable)
            {
                browser.StartInfo.FileName = "https://github.com/markski1/winTweakTool/releases/latest";
            } else
            {
                browser.StartInfo.FileName = "https://markski.ar";
            }
            browser.Start();
        }


        private void ShutdownSchedButton_Click(object sender, EventArgs e)
        {
            Shutdown window = new Shutdown();
            OpenWindow(window, (Button)sender);
        }

        private void WindowsToolsButton_Click(object sender, EventArgs e)
        {
            WindowsTools window = new WindowsTools();
            OpenWindow(window, (Button)sender);
        }

        private void DesktopTweaksButton_Click(object sender, EventArgs e)
        {
            DesktopTweaks window = new DesktopTweaks();
            OpenWindow(window, (Button)sender);
        }

        private void CommonTweaksButton_Click(object sender, EventArgs e)
        {
            SystemTweaks window = new SystemTweaks();
            OpenWindow(window, (Button)sender);
        }

        private static void OpenWindow(Form window, Button btn)
        {
            window.FormClosed += (sender, e) => WindowClosed(window, btn);
            window.Show();
            btn.Enabled = false;
        }

        private static void WindowClosed(Form sender, Button btn)
        {
            sender.Dispose();
            btn.Enabled = true;
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            // attempt to fetch last version
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://snep.markski.ar/wttk.txt");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                int lastVer = Int32.Parse(responseBody);

                int currVer = Int32.Parse($"{Global.version[0]}{Global.version[1]}{Global.version[2]}");

                if (lastVer > currVer)
                {
                    WebLink.Text = "Update available!";
                    WebLink.LinkColor = Color.Green;
                    Global.updateAvailable = true;
                }

                if (lastVer < currVer)
                {
					WebLink.Text += "\nUsing newer than official version.";
					WebLink.Location = new System.Drawing.Point(10, 245);
				}
            }
            catch
            {
                WebLink.Text += "\nFailed to fetch update.";
                WebLink.Location = new System.Drawing.Point(10, 245);
                // if we fail, just don't crash.
            }

            client.Dispose();
        }
    }
}