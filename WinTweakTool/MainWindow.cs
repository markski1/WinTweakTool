using System.Diagnostics;
using System.Security.Principal;

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
        }

        private void ShutdownSchedButton_Click(object sender, EventArgs e)
        {
            ShutdownWindow SleepDialog = new();
            SleepDialog.ShowDialog();
            SleepDialog.Dispose();
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
            Process browser = new();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = "https://markski.ar";
            browser.Start();
        }

        private void WindowsToolsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DesktopTweaksButton_Click(object sender, EventArgs e)
        {
            DesktopTweaksWindow DesktopDialog = new();
            DesktopDialog.ShowDialog();
            DesktopDialog.Dispose();
        }
    }
}