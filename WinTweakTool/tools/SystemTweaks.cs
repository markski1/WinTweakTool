using System;
using System.Windows.Forms;
using WinTweakTool.components;

namespace WinTweakTool
{
    public partial class SystemTweaks : Form
    {
        public SystemTweaks()
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
            enabled = enabled && RegistryFuncs.CheckCurrentUser("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search", "CortanaConsent", 0);

            if (enabled)
            {
                Cortana.Checked = true;
            }

            // check if web search is already disabled.
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableWebSearch", 1);
            enabled = enabled && RegistryFuncs.CheckCurrentUser("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search", "BingSearchEnabled", 0);

            if (enabled)
            {
                SearchNet.Checked = true;
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

            // check if updating drivers is already disabled
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate", "ExcludeWUDriversInQualityUpdate", 1);
            if (enabled)
            {
                UpdateDrivers.Checked = true;
            }

            // check if windows modern standby is already disabled
            enabled = RegistryFuncs.CheckLocalMachine("System\\CurrentControlSet\\Control\\Power", "PlatformAoAcOverride", 0);
            if (enabled)
            {
                ModernStandby.Checked = true;
            }

            // check for verbose mode
            enabled = RegistryFuncs.CheckLocalMachine("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "VerboseStatus", 32);
            if (enabled)
            {
                VerboseMode.Checked = true;
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance",
                keyName: "MaintenanceDisabled",
                setValue: 1,
                userChoise: WinMan.Checked,
                errName: "CT1",
                localMachine: true);


            // Windows Defender option
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows Defender",
                keyName: "DisableAntiSpyware",
                setValue: 1,
                userChoise: WinDef.Checked,
                errName: "CT2",
                localMachine: true);

            // Disable Cortana option
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search",
                keyName: "AllowCortana",
                setValue: 0,
                userChoise: Cortana.Checked,
                errName: "CT3-4",
                localMachine: true);

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search",
                keyName: "CortanaConsent",
                setValue: 0,
                userChoise: Cortana.Checked,
                errName: "CT3-4-1",
                localMachine: false);


            // Disable search internet suggestions option
            // No need to re-set key
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search",
                keyName: "DisableWebSearch",
                setValue: 1,
                userChoise: SearchNet.Checked,
                errName: "CT3-4",
                localMachine: true);

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search",
                keyName: "BingSearchEnabled",
                setValue: 0,
                userChoise: SearchNet.Checked,
                errName: "CT3-4-1",
                localMachine: false);


            // Disable startup delay option
            RegistryFuncs.SetRegistryValue(
                subKey: "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Serialize",
                keyName: "StartupDelayInMSec",
                setValue: 0,
                userChoise: StartupDelay.Checked,
                errName: "CT5",
                localMachine: false);


            // Disable app tracking option
            RegistryFuncs.SetRegistryValue(
                subKey: "Software\\Policies\\Microsoft\\Windows\\EdgeUI",
                keyName: "DisableMFUTracking",
                setValue: 1,
                userChoise: AppTracking.Checked,
                errName: "CT6",
                localMachine: false);


            // Disable error reporting option
            RegistryFuncs.SetRegistryValue(
                subKey: "Software\\Microsoft\\Windows\\Windows Error Reporting",
                keyName: "Disabled",
                setValue: 1,
                userChoise: ErrorReporting.Checked,
                errName: "CT7",
                localMachine: false);


            // Disable app suggestion on start option
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent",
                keyName: "DisableWindowsConsumerFeatures",
                setValue: 1,
                userChoise: StartSuggestions.Checked,
                errName: "CT8",
                localMachine: true);


            // Disable windows update also updating drivers
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate",
                keyName: "ExcludeWUDriversInQualityUpdate",
                setValue: 1,
                userChoise: UpdateDrivers.Checked,
                errName: "CT9",
                localMachine: true);


            // Disable windows modern standby
            RegistryFuncs.SetRegistryValue(
                subKey: "System\\CurrentControlSet\\Control\\Power",
                keyName: "PlatformAoAcOverride",
                setValue: 0,
                userChoise: ModernStandby.Checked,
                errName: "CT10",
                localMachine: true);


            // Enable verbose mode
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System",
                keyName: "VerboseStatus",
                setValue: 32,
                userChoise: VerboseMode.Checked,
                errName: "CT10",
                localMachine: true);


            MessageBox.Show("Changes applied.\n\nA system restart might be needed.");
        }

        private void WinDef_CheckedChanged(object sender, EventArgs e)
        {
            if (WinDef.Checked)
            {
                MessageBox.Show(
                    "Attention!\n\nRunning your computer with no anti-virus is not worth whatever performance improvements you think you might get.\n\nI don't care if you're a super expert or a leet hacker, using an anti-virus is not beneath you. Modern system security is a lot more complex than \"I know what to download lol\"\n\nThis option exists because I am of the belief that you should be able to do whatever you want with your own computer. But be advised, this is a very stupid idea.\n\nIf you really dislike Windows Defender, do at least consider replacing it with another AV solution rather than running with no AV at all."
                );
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"- Disable Windows Maintenance
Disables automated maintenance tasks like updates, security scanning and system diagnostics.

- Disable Windows defender
Disables the Windows Defender native antivirus.

- Disable Cortana
Disables the Cortana button and it's related voice functionality.

- Disable Search internet suggestion
Disables the taskbar Search function from poking Bing about things you search and giving you search suggestions.

- Disable startup delay
Windows will make a ~10 second delay on bootup to let things start up before showing you the desktop. This disables that behaviour.

- Disable app tracking
Disables Windows trying to figure out what applications you use often to suggest them.

- Disable error reporting
Disables Windows phoning home about errors and other odd behaviour.

- Disable app suggestions on start menu
Disables advert/suggested apps showing up on the Start Menu tiles.

- Disable WinUpdate also updating drivers
Windows Update will attempt to update some system drivers at times. Disable if you dislike this behaviour or believe it's causing you issues.

- Disable Windows Modern Standby
Force use of S3 sleep instead of S0 when sleeping or hibernating. This will prevent battery draining and heat on laptops while they're off. This might cause BSODs on laptops which don't support S3

- Enable verbose mode
Shows more detail of what is really happening in certain cases, for example when the computer is booting up and shutting down."
                );
        }
    }
}
