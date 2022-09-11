namespace WinTweakTool
{
    public partial class ShutdownWindow : Form
    {
        public ShutdownWindow()
        {
            InitializeComponent();
        }

        private void ScheduleShutdown_Click(object sender, EventArgs e)
        {
            int hours = Convert.ToInt32(numericUpDown1.Value);
            int minutes = Convert.ToInt32(numericUpDown2.Value);

            int total = (hours * 3600) + (minutes * 60);

            if (total <= 0)
            {
                MessageBox.Show("You must set a delay of at least 1 minute.");
                return;
            }

            System.Diagnostics.Process cmd = new();

            cmd.StartInfo.FileName = "shutdown";
            cmd.StartInfo.Arguments = $"-s -t {total}";

            cmd.Start();
            cmd.WaitForExit();
            cmd.Dispose();

            MessageBox.Show($"Your system will shut down in {hours} hour(s), {minutes} minute(s).");
        }

        private void CancelShutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new();

            cmd.StartInfo.FileName = "shutdown";
            cmd.StartInfo.Arguments = $"-a";

            cmd.Start();
            cmd.WaitForExit();
            cmd.Dispose();

            MessageBox.Show($"The scheduled shutdown (if any) has been cancelled.");
        }
    }
}
