using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjStateCapitals
{
    public partial class frmStateCapitals : Form
    {
        public frmStateCapitals()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Will exit application.
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Will Clear the State and Capital
            lblState.Text = "";
            lblCapital.Text = "";
        }

        private void btnWisconsin_Click(object sender, EventArgs e)
        {
            // will show state and capital for Wisconsin
            lblState.Text = "Wisconsin";
            lblCapital.Text = "Madison";
        }

        private void btnMinnesota_Click(object sender, EventArgs e)
        {
            // will show state and capital of Minnesota
            lblState.Text = "Minnesota";
            lblCapital.Text = "Saint Paul";
        }

        private void btnMichigan_Click(object sender, EventArgs e)
        {
            // will show state and capital of Michigan
            lblState.Text = "Michigan";
            lblCapital.Text = "Lansing";
        }

        private void btnIllinois_Click(object sender, EventArgs e)
        {
            // will show the state and capital of Illinois
            lblState.Text = "Illinois";
            lblCapital.Text = "Springfield";
        }

        private void btnCalifornia_Click(object sender, EventArgs e)
        {
            // will show the state and capital of California
            lblState.Text = "California";
            lblCapital.Text = "Sacramento";
        }
    }
}
