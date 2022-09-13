namespace WinTweakTool
{
    public static class RegistryFuncs
    {
        public static bool CheckLocalMachine(string subKey, string keyValue, int expectedValue) 
        {
            Microsoft.Win32.RegistryKey? key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(subKey);
            if (key is not null)
            {
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
                if (Convert.ToInt32(key.GetValue(keyValue)) == expectedValue) return true;
            }
            return false;
        }
    }
}
