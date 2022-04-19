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

namespace ProConfigLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUseCfg_Click(object sender, EventArgs e)
        {

        }

        private async void LoadProConfigNames()
        {
            ProConfigRequest proConfigRequest = new ProConfigRequest();
            var proConfigs = await proConfigRequest.GetProConfig();
            foreach (var config in proConfigs)
            {
                //cBoxProConfig.Items.Add(config.pro_name);
            }
        }

        private void LoadSteamDirectors()
        {

        }
    }
}

