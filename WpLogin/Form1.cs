using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Authentication authentication = new Authentication();
            authentication.LoginToWordpress(tbUser.Text, tbPass.Text);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
