using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTweakTool
{
    public partial class CommonTweaksWindow : Form
    {
        public CommonTweaksWindow()
        {
            InitializeComponent();

            // check all the registry keys for changes already made.
            // this will reflect if boxes should be checked or not.

            bool enabled;

            // check if Windows Maintenance is already disabled.
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance", "MaintenanceDisabled", 1);
            if (enabled)
            {
                WinMan.Checked = true;
            }

            // check if Windows Defender is already disabled.
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 1);
            if (enabled)
            {
                WinDef.Checked = true;
            }

            // check if Cortana is already disabled.
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", 0);
            if (enabled)
            {
                Cortana.Checked = true;
            }

            // check if web search is already disabled.
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableWebSearch", 1);
            if (enabled)
            {
                enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "ConnectedSearchUseWeb", 0);
                if (enabled)
                {
                    SearchNet.Checked = true;
                }
            }

            // check if startup delay is already set to 0

            enabled = RegistryFuncs.CheckCurrentUser("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Serialize", "StartupDelayInMSec", 0);
            if (enabled)
            {
                StartupDelay.Checked = true;
            }

            // check if app tracking is already disabled
            enabled = RegistryFuncs.CheckCurrentUser("Software\\Policies\\Microsoft\\Windows\\EdgeUI", "DisableMFUTracking", 1);
            if (enabled)
            {
                AppTracking.Checked = true;
            }

            // check if error reporting is already disabled
            enabled = RegistryFuncs.CheckCurrentUser("Software\\Microsoft\\Windows\\Windows Error Reporting", "Disabled", 1);
            if (enabled)
            {
                ErrorReporting.Checked = true;
            }

            // check if app suggestions is already disabled.
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", "DisableWindowsConsumerFeatures", 1);
            if (enabled)
            {
                StartSuggestions.Checked = true;
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
