using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AscentRestApi;
using Steam;

namespace WpLogin
{
    public partial class Form1 : Form
    {

        private List<ProConfig> proConfigs;
        private ProConfig selectedProConfig;
        private RestApi restApi;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            restApi = new RestApi();
            await restApi.Login(tbUser.Text, tbPass.Text);
            if (restApi.IsAuthenticated)
            {
                await LoadProConfigNames();
                LoadSteamDirectorys();
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnUseCfg_Click(object sender, EventArgs e)
        {
            if (cBoxConfig.Checked && cBoxConfig.Enabled)
            {
                selectedProConfig.WriteCfgToDirectory(cBoxSteamDir.Text);
            }
            if (cBoxAutoexec.Checked && cBoxAutoexec.Enabled)
            {
                selectedProConfig.WriteAutoexecToDirectory(cBoxSteamDir.Text);
            }
            if (cBoxVideo.Checked && cBoxVideo.Enabled)
            {
                selectedProConfig.WriteVideoToDirectory(cBoxSteamDir.Text);
            }
        }

        private async Task LoadProConfigNames()
        {
            proConfigs = await restApi.ProConfigRequest();
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
