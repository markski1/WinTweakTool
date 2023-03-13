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

		public static void SetRegistryValue(string subKey, string keyName, bool userChoise, string errName, bool localMachine, int? setValue = null, string? setStrValue = null, int? unSetValue = null)
		{
            Microsoft.Win32.RegistryKey? key;

			if (localMachine)
			{
                key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(subKey, true);
            }
            else
			{
				key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey, true);
			}

            if (key is null)
			{
				MessageBox.Show($"Sorry, there was an error accessing certain registry information. Please report this error: {errName}");
				return;
			}

			try
			{
				if (userChoise)
				{
					if (setValue is not null) key.SetValue(keyName, setValue);
					if (setStrValue is not null) key.SetValue(keyName, setStrValue);
				}
				else
				{
					if (unSetValue is null)
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
					else
					{
						key.SetValue(keyName, unSetValue);
					}
				}
			}
			catch {
                MessageBox.Show($"Sorry, I couldn't write the registry key. Please make sure I'm running as admin! {errName}");
                return;
            }
		}
	}
}
