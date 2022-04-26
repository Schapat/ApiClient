using ProConfigLoader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steam;

namespace ProConfigLoader
{
    public partial class Form1 : Form
    {
        private List<ProConfig>proConfigs;

        public Form1()
        {
            InitializeComponent();
            LoadProConfigNames();
            LoadSteamDirectorys();
        }

        private void btnUseCfg_Click(object sender, EventArgs e)
        {
            foreach (var config in proConfigs)
            {
                if (config.pro_name == cBoxProConfig.Text)
                {
                    config.WriteCfgToDirectory(cBoxSteamDir.Text);
                    config.WriteVideoToDirectory(cBoxSteamDir.Text);
                    config.WriteAutoexecToDirectory(cBoxSteamDir.Text);
                }
            }
        }

        private async void LoadProConfigNames()
        {
            ProConfigRequest proConfigRequest = new ProConfigRequest();
            proConfigs = await proConfigRequest.GetProConfig();
            foreach (var config in proConfigs)
            {
                cBoxProConfig.Items.Add(config.pro_name);
            }
        }

        private void LoadSteamDirectorys()
        {
            SteamDirectorys steamDirectorys = new SteamDirectorys();
            var csCfgDir = steamDirectorys.FindSteamDirectorys();
            foreach (var directory in csCfgDir)
            {
                cBoxSteamDir.Items.Add(directory.cfgDir);
            }
        }
    }
}

