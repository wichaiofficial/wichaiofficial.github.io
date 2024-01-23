using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFlags
{
    public partial class frmFlags : Form
    {
        public frmFlags()
        {
            InitializeComponent();
        }

        private void pbxGermany_Click(object sender, EventArgs e)
        {
            // Show Germany in the lable
            lblInformation.Text = "Germany";
        }

        private void pbxFinland_Click(object sender, EventArgs e)
        {
            // Show Finland in the lable
            lblInformation.Text = "Finland";
        }

        private void pbxFrance_Click(object sender, EventArgs e)
        {
            // Show France in the lable
            lblInformation.Text = "France";
        }
    }
}
