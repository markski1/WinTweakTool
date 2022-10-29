namespace WinTweakTool.components
{
    public static class RegistryFuncs
    {
        public static bool CheckLocalMachine(string subKey, string keyValue, int expectedValue)
        {
            Microsoft.Win32.RegistryKey? key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(subKey);
            if (key is not null)
            {
                if (key.GetValue(keyValue) is null) return false;
                if (Convert.ToInt32(key.GetValue(keyValue)) == expectedValue) return true;
            }
            return false;
        }

        public static bool CheckCurrentUser(string subKey, string keyValue, int expectedValue)
        {
            Microsoft.Win32.RegistryKey? key;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey);
            if (key is not null)
            {
                if (key.GetValue(keyValue) is null) return false;
                if (Convert.ToInt32(key.GetValue(keyValue)) == expectedValue) return true;
            }
            return false;
        }

        public static void SetRegistryValue(string subKey, string keyName, int setValue, Microsoft.Win32.RegistryKey? key, bool userChoise, string errName, bool localMachine)
        {
            if (key is null)
            {
                MessageBox.Show($"Sorry, there was an error accessing certain registry information. Please report this error: {errName}");
                return;
            }

            if (userChoise)
            {
                bool enabled;
                if (localMachine)
                {
                    enabled = CheckLocalMachine(subKey, keyName, setValue);
                }
                else
                {
                    enabled = CheckCurrentUser(subKey, keyName, setValue);
                }
                if (!enabled)
                {
                    key.SetValue(keyName, setValue);
                }
            }
            else
            {
                try
                {
                    key.DeleteValue(keyName);
                }
                catch
                {
                    // nothing, just don't crash.
                }
            }
        }
    }
}
