namespace WinTweakTool
{
    public partial class DesktopTweaksWindow : Form
    {
        public DesktopTweaksWindow()
        {
            InitializeComponent();
            bool enabled = false;
            Microsoft.Win32.RegistryKey? key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons");
            if (key is not null)
            {
                if (key.GetValue("29") is null) enabled = true;
            } else
            {
                enabled = true;
            }

            if (enabled)
            {
                DesktopIndicatorChk.Checked = true;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var enable = DesktopIndicatorChk.Checked;
            Microsoft.Win32.RegistryKey? key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons", true);
            if (enable)
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
            else
            {
                key ??= Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons");
                if (key is not null)
                {
                    key.SetValue("29", "");
                }
            }
            MessageBox.Show("Done. Use the \"Restart explorer.exe\" button to apply.");
        }
    }
}
