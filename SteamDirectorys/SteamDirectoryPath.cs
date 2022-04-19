using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    public class SteamDirectoryPath
    {
        public string steamDir;
        public string accountDir;
        public string cfgDir;

        public SteamDirectoryPath(string steamDir, string accountDir, string cfgDir)
        {
            this.steamDir = steamDir;
            this.accountDir = accountDir;
            this.cfgDir = cfgDir + "\\";
        }

        //ctor für manuellen cfg path
        public SteamDirectoryPath(string cfgDir)
        {
            this.cfgDir = cfgDir;
        }
    }
}