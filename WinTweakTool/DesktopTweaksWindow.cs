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
            enabled = RegistryFuncs.CheckCurrentUser("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSecondsInSystemClock", 1);
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

            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced",
                keyName: "ShowSecondsInSystemClock",
                setValue: 1,
                key: key,
                userChoise: ClockSeconds.Checked,
                errName: "DT1",
                localMachine: false);
            
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced",
                keyName: "UseOLEDTaskbarTransparency",
                setValue: 1,
                key: key,
                userChoise: TaskbarTrans.Checked,
                errName: "DT2",
                localMachine: true);

            MessageBox.Show("Changes applied. \n\nRestarting explorer.exe might be needed.");
        }
    }
}
