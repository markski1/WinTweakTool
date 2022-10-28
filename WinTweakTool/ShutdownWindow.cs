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
            int hours, minutes;
            TimeSpan shutdownTime;
            if (shutdownIn.Checked)
            {
                hours = Convert.ToInt32(numericUpDown1.Value);
                minutes = Convert.ToInt32(numericUpDown2.Value);
                shutdownTime = new TimeSpan(hours, minutes, 0);
            }
            else
            {
                var DayChosen = monthPicker.SelectionRange.End;
                shutdownTime = (new DateTime(DayChosen.Year, DayChosen.Month, DayChosen.Day, timePicker.Value.Hour, timePicker.Value.Minute, 0)) - DateTime.Now;
                hours = shutdownTime.Days * 24;
                hours += shutdownTime.Hours;
                minutes = shutdownTime.Minutes;
            }
            
            if (shutdownTime.TotalMinutes <= 0)
            {
                MessageBox.Show("You must set a delay of at least 1 minute.");
                return;
            }

            System.Diagnostics.Process cmd = new();

            cmd.StartInfo.FileName = "shutdown";
            cmd.StartInfo.Arguments = $"-s -t {((int)shutdownTime.TotalSeconds)}";

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
