using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    public class SteamDirectorys
    {
        private List<SteamDirectoryPath> steamDirectoryPaths;
        SteamDirectoryPath steamDirectoryPath;

        public SteamDirectorys()
        {
            steamDirectoryPaths = new List<SteamDirectoryPath>();
        }

        public List<SteamDirectoryPath> FindSteamDirectorys()
        {
            HddInfo hddInfo = new HddInfo();

            foreach (var drive in hddInfo.drives)
            {
                foreach (var dir in Directory.GetDirectories(drive))
                {
                    if (!File.GetAttributes(dir).HasFlag(FileAttributes.Hidden) && !dir.Contains("Win"))
                    {
                        if (dir.Contains("Steam"))
                        {
                            FindAccountDirectorys(dir);
                        }
                        else
                        {
                            foreach (var subDir in Directory.GetDirectories(dir))
                            {
                                if (!File.GetAttributes(subDir).HasFlag(FileAttributes.Hidden) && !subDir.Contains("Win"))
                                {
                                    if (subDir.Contains("Steam"))
                                    {
                                        FindAccountDirectorys(subDir);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return steamDirectoryPaths;
        }

        private void FindAccountDirectorys(String steamPath)
        {
            foreach (var dir in Directory.GetDirectories(steamPath))
            {
                if (dir.Contains("userdata"))
                {
                    foreach (var account in Directory.GetDirectories(dir))
                    {
                        FindCfgDirectorys(steamPath, account);
                    }
                }
            }
        }

        private void FindCfgDirectorys(String steamPath, String account)
        {
            foreach (var dir in Directory.GetDirectories(account))
            {
                //IF CSGO is on this Account
                if (dir.Contains("730"))
                {
                    foreach (var subDir in Directory.GetDirectories(dir))
                    {
                        //or remote?
                        if (subDir.Contains("local"))
                        {
                            foreach (var cfgDir in Directory.GetDirectories(subDir))
                            {
                                if (cfgDir.Contains("cfg"))
                                {
                                    steamDirectoryPath = new SteamDirectoryPath(steamPath, account, cfgDir);
                                    steamDirectoryPaths.Add(steamDirectoryPath);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}