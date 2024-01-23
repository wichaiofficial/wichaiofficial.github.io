using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExer1Xiong
{
    public partial class frmExer1form : Form
    {
        public frmExer1form()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // This should display name on lblFvtc.
            lblFvtc.Text = "Wichai Xiong";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // This should clear name and change it back to Fox Valley Technical College.
            lblFvtc.Text = "Fox Valley Technical College";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // This will exit the applitcation.
            Application.Exit();
        }
    }
}
