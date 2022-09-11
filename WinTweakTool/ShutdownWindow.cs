using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
