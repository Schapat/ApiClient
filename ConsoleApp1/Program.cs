using System;
using Microsoft.Win32;

class Program
{
    static String steampath = "";
    private static void SearchSubKeys(RegistryKey root, String searchKey)
    {

        foreach (string keyname in root.GetSubKeyNames())
        {
            try
            {
                using (RegistryKey key = root.OpenSubKey(keyname))
                {
                    if (keyname == searchKey)
                    {
                        steampath= (String) key.Name;
                    }
                    SearchSubKeys(key, searchKey);
                }
            }
            catch (System.Security.SecurityException)
            {
            }
        }
    }

    public static void Main(String[] args)
    {
        using (RegistryKey root = Registry.CurrentUser)
        {
            string myKey = "Steam";
            SearchSubKeys(root, myKey);
            Console.WriteLine(steampath);
        }
        
    }
}


//Computer\HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\ActiveProcess -----STEAMID32
//STEAMID32 + 76561197960265728 = STEAMID64
//STEAMID64 = concatenate("00000001000100000000000000000001", STEAMID32);