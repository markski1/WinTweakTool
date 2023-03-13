using WinTweakTool.components;

namespace WinTweakTool
{
    public partial class DesktopTweaks : Form
    {
        public DesktopTweaks()
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
                DesktopIndicator.Checked = true;
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

            // if menu delay is set to 400, then the tweak is NOT set.
            enabled = RegistryFuncs.CheckCurrentUser("Control Panel\\Desktop", "MenuShowDelay", 400);
            if (!enabled)
            {
                MenuDelay.Checked = true;
            }

            // check if shake-to-minimize is disabled
            enabled = RegistryFuncs.CheckCurrentUser("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", 1);
            if (enabled)
            {
                ShakeMin.Checked = true;
            }

            // check if action center is disabled
            enabled = RegistryFuncs.CheckCurrentUser("Software\\Policies\\Microsoft\\Windows", "DisableNotificationCenter", 1);
            if (enabled)
            {
                ActionCenter.Checked = true;
            }

            // check if balloon notis are enabled
            enabled = RegistryFuncs.CheckCurrentUser("Software\\Policies\\Microsoft\\Windows\\Explorer", "EnableLegacyBalloonNotifications", 1);
            if (enabled)
            {
                BalloonNotis.Checked = true;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var disable = DesktopIndicator.Checked;
            Microsoft.Win32.RegistryKey? key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons", true);
            if (disable)
            {
                key ??= Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons");
                key?.SetValue("29", "");
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
                localMachine: false);

            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);

            RegistryFuncs.SetRegistryValue(
                subKey: "Control Panel\\Desktop",
                keyName: "MenuShowDelay",
                setValue: 20,
                unSetValue: 400,
                key: key,
                userChoise: MenuDelay.Checked,
                errName: "DT3",
                localMachine: false);

            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced",
                keyName: "DisallowShaking",
                setValue: 1,
                unSetValue: 0,
                key: key,
                userChoise: ShakeMin.Checked,
                errName: "DT4",
                localMachine: false);

            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows", true);

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows",
                keyName: "DisableNotificationCenter",
                setValue: 1,
                unSetValue: 0,
                key: key,
                userChoise: ActionCenter.Checked,
                errName: "DT5",
                localMachine: false);

            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);

            if (key is null)
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
            }

            RegistryFuncs.SetRegistryValue(
                subKey: "Software\\Policies\\Microsoft\\Windows\\Explorer",
                keyName: "EnableLegacyBalloonNotifications",
                setValue: 1,
                unSetValue: 0,
                key: key,
                userChoise: BalloonNotis.Checked,
                errName: "DT6",
                localMachine: false);

            MessageBox.Show("Changes applied. \n\nRestarting explorer.exe might be needed.");
        }

        private void DesktopIndicator_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"- Hide shortcut indicator icons
Removes the little arrow icon from shortcuts. Might make icons invisible in Windows 11; if that's the case, just turn it back off.

- Increase taskbar transparency.
Increases the transparency of the taskbar.

- Show seconds in taskbar clock
Shows the second in the taskbar clock, after hours and minutes.

- Decrease context menu delay
Decreases the amount of time you must hover on an element for context menu to show up.

- Disable shake-to-minimize
Disable the behaviour of shaking a window causing it to be minimized.

- Disable action center / notification.
Disables the Windows 10 notification bar.

- Enable old 'balloon' notifications
Shows notifications as a balloon in the taskbar, like in older versions of Windows."
                );
        }
    }
}
