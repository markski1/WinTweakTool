using System.Diagnostics;
using System.Security.Principal;
using WinTweakTool.components;

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
            WindowsPrincipal principal = new(identity);
            isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!isAdmin)
            {
                NotAdminText.Text = "Not running as admin!\nThings might not work.";
            }

            this.Text = $"WTTk v{Global.version[0]}.{Global.version[1]}.{Global.version[2]}";
        }

        private void ShutdownSchedButton_Click(object sender, EventArgs e)
        {
            Shutdown SleepDialog = new();
            SleepDialog.ShowDialog();
            SleepDialog.Dispose();
        }

        private void RestartExplorer_Click(object sender, EventArgs e)
        {
            foreach (Process hopefullyExporer in Process.GetProcesses())
            {
                if (hopefullyExporer.ProcessName.StartsWith("explorer.exe"))
                {
                    hopefullyExporer.Kill();
                    break;
                }
            }
        }

        private void WebLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process browser = new();
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

        private void WindowsToolsButton_Click(object sender, EventArgs e)
        {
            WindowsTools ToolsDialog = new();
            ToolsDialog.ShowDialog();
            ToolsDialog.Dispose();
        }

        private void DesktopTweaksButton_Click(object sender, EventArgs e)
        {
            DesktopTweaks DesktopDialog = new();
            DesktopDialog.ShowDialog();
            DesktopDialog.Dispose();
        }

        private void CommonTweaksButton_Click(object sender, EventArgs e)
        {
            SystemTweaks TweaksDialog = new();
            TweaksDialog.ShowDialog();
            TweaksDialog.Dispose();
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            HttpClient client = new();

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
            }
            catch
            {
                // if we fail, just don't crash.
            }

            client.Dispose();
        }
    }
}