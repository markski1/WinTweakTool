using System.Security.Cryptography.X509Certificates;

namespace WinTweakTool
{
    public partial class DesktopTweaksWindow : Form
    {
        public DesktopTweaksWindow()
        {
            InitializeComponent();
            bool enabled = true;
            Microsoft.Win32.RegistryKey? key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons");
            // if the key exists, check for the value 29. This sets the desktop indicator.
            if (key is not null)
            {
                if (key.GetValue("29") is null) enabled = false;
            }
            else
            {
                enabled = false;
            }

            if (enabled)
            {
                DesktopIndicatorChk.Checked = true;
            }

            // check if taskbar transparency is increased.
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "UseOLEDTaskbarTransparency", 1);
            if (enabled)
            {
                TaskbarTrans.Checked = true;
            }

            // check if taskbar clock is already showing seconds
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSecondsInSystemClock", 1);
            if (enabled)
            {
                ClockSeconds.Checked = true;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var disable = DesktopIndicatorChk.Checked;
            Microsoft.Win32.RegistryKey? key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons", true);
            if (disable)
            {
                key ??= Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons");
                if (key is not null)
                {
                    key.SetValue("29", "");
                }
            }
            else
            {
                // if the key isn't null, we need change nothing as no key means icons are on.
                if (key is not null)
                {
                    try
                    {
                        key.DeleteValue("29");
                    }
                    catch
                    {
                        // no need to handle, just don't crash.
                    }
                }
            }

            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
            if (key is not null)
            {
                if (ClockSeconds.Checked)
                {
                    if (Convert.ToInt32(key.GetValue("ShowSecondsInSystemClock")) != 1)
                    {
                        key.SetValue("ShowSecondsInSystemClock", 1);
                    }
                }
                else
                {
                    key.SetValue("ShowSecondsInSystemClock", 0);
                }

                if (TaskbarTrans.Checked)
                {
                    if (Convert.ToInt32(key.GetValue("UseOLEDTaskbarTransparency")) != 1)
                    {
                        key.SetValue("UseOLEDTaskbarTransparency", 1);
                    }
                }
                else
                {
                    key.SetValue("UseOLEDTaskbarTransparency", 0);
                }
            }
            else
            {
                MessageBox.Show("There was an error accesing certain registry values.");
            }


            MessageBox.Show("Done. Use the \"Restart explorer.exe\" button to apply.");
        }

        private void DesktopIndicatorChk_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
