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
using AscentRestApi;

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
            if (cBoxConfig.Checked && cBoxConfig.Enabled)
            {
                selectedProConfig.WriteCfgToDirectory(cBoxSteamDir.Text);
            }
            if(cBoxAutoexec.Checked && cBoxAutoexec.Enabled)
            {
                selectedProConfig.WriteAutoexecToDirectory(cBoxSteamDir.Text);
            }
            if(cBoxVideo.Checked && cBoxVideo.Enabled)
            {
                selectedProConfig.WriteVideoToDirectory(cBoxSteamDir.Text);
            }
        }

        private async Task LoadProConfigNames()
        {
            ProConfigRequest proConfigRequest = new ProConfigRequest();
            proConfigs = proConfigRequest.GetProConfig();
            foreach (var config in proConfigs)
            {
                cBoxProConfig.Items.Add(config.pro_name);
            }
            cBoxProConfig.SelectedIndex = 0;
        }
        private void LoadSteamDirectorys()
        {
            SteamDirectorys steamDirectorys = new SteamDirectorys();
            var csCfgDir = steamDirectorys.FindSteamDirectorys();
            foreach (var directory in csCfgDir)
            {
                cBoxSteamDir.Items.Add(directory.cfgDir);
            }
            cBoxSteamDir.SelectedIndex = 0;
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
            if (selectedProConfig.HasConfig())
            {
                cBoxConfig.Enabled = true;
            }
            else
            {
                cBoxConfig.Enabled = false;
            }

            if (selectedProConfig.HasVideo())
            {
                cBoxVideo.Enabled = true;
            }
            else
            {
                cBoxVideo.Enabled = false;
            }

            if (selectedProConfig.HasAutoexec())
            {
                cBoxAutoexec.Enabled = true;
            }
            else
            {
                cBoxAutoexec.Enabled = false;
            }
        }
    }
}

