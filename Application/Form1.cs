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
        private ProConfig selectedProConfig;

        public Form1()
        {
            InitializeComponent();
            LoadProConfigNames();
            LoadSteamDirectorys();
        }

        private void btnUseCfg_Click(object sender, EventArgs e)
        {
            selectedProConfig.WriteCfgToDirectory(cBoxSteamDir.Text);
            selectedProConfig.WriteVideoToDirectory(cBoxSteamDir.Text);
            selectedProConfig.WriteAutoexecToDirectory(cBoxSteamDir.Text);
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

        private void cBoxProConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var config in proConfigs)
            {
                if (config.pro_name == cBoxProConfig.Text)
                {
                    selectedProConfig = config;
                }
            }

            if (!selectedProConfig.HasVideo())
            {
                cBoxVideo.Enabled = false;            
            }

            if (!selectedProConfig.HasConfig())
            {
                cBoxConfig.Enabled = false;
            }

            if (!selectedProConfig.HasAutoexec())
            {
                cBoxAutoexec.Enabled = false;
            }
        }
    }
}

