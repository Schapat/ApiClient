using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProConfigLoader
{
    public class ProConfig
    {
        public int pro_id;
        public string pro_name;
        public string config;
        public string autoexec;
        public string video;

        public ProConfig()
        {
        }

        public bool HasConfig()
        {
            if(this.config == null)
            {
                return false;
            }
            return true;
        }

        public bool HasAutoexec()
        {
            if (this.autoexec == null)
            {
                return false;
            }
            return true;
        }

        public bool HasVideo()
        {
            if (this.video == null)
            {
                return false;
            }
            return true;
        }

        public void WriteCfgToDirectory(string csCfgDir)
        {
            if (this.HasConfig())
            {
                File.WriteAllText(csCfgDir + "config.cfg", this.config);
            }
        }

        public void WriteAutoexecToDirectory(string csCfgDir)
        {
            if (this.HasAutoexec())
            {
                File.WriteAllText(csCfgDir + "Autoexec.cfg", this.autoexec);
            }
            
        }

        public void WriteVideoToDirectory(string csCfgDir)
        {
            if (this.HasVideo())
            {
                File.WriteAllText(csCfgDir + "Video.txt", this.video);
            }
            
        }

    }
}
