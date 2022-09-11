using System.Diagnostics;

namespace WinTweakTool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            OperatingSystem os = Environment.OSVersion;
            WinVerText.Text = $"WinVer: {os.Version}";
        }

        private void ShutdownSchedButton_Click(object sender, EventArgs e)
        {
            var SleepDialog = new ShutdownWindow();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}