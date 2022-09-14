namespace WinTweakTool
{
    public partial class SystemTweaksWindow : Form
    {
        public SystemTweaksWindow()
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
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey? key;
                

            // Windows Maintenance option
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance", 
                keyName: "MaintenanceDisabled", 
                setValue: 1, 
                key: key, 
                userChoise: WinMan.Checked, 
                errName: "CT1",
                localMachine: true);



            // Windows Defender option
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows Defender",
                keyName: "DisableAntiSpyware",
                setValue: 1,
                key: key,
                userChoise: WinDef.Checked,
                errName: "CT2",
                localMachine: true);                



            // Disable Cortana option
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search");

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search",
                keyName: "AllowCortana",
                setValue: 0,
                key: key,
                userChoise: Cortana.Checked,
                errName: "CT3-4",
                localMachine: true);



            // Disable search internet suggestions option
            // No need to re-set key
            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search",
                keyName: "DisableWebSearch",
                setValue: 1,
                key: key,
                userChoise: SearchNet.Checked,
                errName: "CT3-4",
                localMachine: true);



            // Disable startup delay option
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Serialize");

            RegistryFuncs.SetRegistryValue(
                subKey: "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Serialize",
                keyName: "StartupDelayInMSec",
                setValue: 0,
                key: key,
                userChoise: StartupDelay.Checked,
                errName: "CT5",
                localMachine: false);



            // Disable app tracking option
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\EdgeUI");

            RegistryFuncs.SetRegistryValue(
                subKey: "Software\\Policies\\Microsoft\\Windows\\EdgeUI",
                keyName: "DisableMFUTracking",
                setValue: 1,
                key: key,
                userChoise: AppTracking.Checked,
                errName: "CT6",
                localMachine: false);



            // Disable error reporting option
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\Windows Error Reporting");

            RegistryFuncs.SetRegistryValue(
                subKey: "Software\\Microsoft\\Windows\\Windows Error Reporting",
                keyName: "Disabled",
                setValue: 1,
                key: key,
                userChoise: ErrorReporting.Checked,
                errName: "CT7",
                localMachine: false);



            // Disable app suggestion on start option
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\Windows Error Reporting");

            RegistryFuncs.SetRegistryValue(
                subKey: "SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent",
                keyName: "DisableWindowsConsumerFeatures",
                setValue: 1,
                key: key,
                userChoise: StartSuggestions.Checked,
                errName: "CT8",
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
Disables advert/suggested apps showing up on the Start Menu tiles."
                );
        }
    }
}
