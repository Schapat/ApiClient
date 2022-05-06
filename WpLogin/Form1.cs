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

namespace WpLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RestApi restApi = new RestApi(tbUser.Text,tbPass.Text);
            restApi.TokenRequest();
            restApi.SetLoginToken();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
