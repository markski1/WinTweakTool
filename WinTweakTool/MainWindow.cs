namespace WinTweakTool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShutdownSchedButton_Click(object sender, EventArgs e)
        {
            var SleepDialog = new ShutdownWindow();
            SleepDialog.ShowDialog();
            SleepDialog.Dispose();
        }

        private void RestartExplorer_Click(object sender, EventArgs e)
        {

        }
    }
}