using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExer5Xiong
{
    public partial class frmExer5 : Form
    {
        public frmExer5()
        {
            InitializeComponent();
        }

        // When clicked, This will calculate the miles per gallon entered by user.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblMiles;
            double dblGallons;
            double dblMPG;
            if (double.TryParse(txtMiles.Text, out dblMiles) && (double.TryParse(txtGallons.Text, out dblGallons) && dblGallons > 0 && dblMiles > 0))
            {
                dblMPG = dblMiles / dblGallons;
                lblDisplayMPG.Text = dblMPG.ToString("N1");
                txtMiles.SelectAll();
                txtMiles.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid value for miles and gallons");
                txtMiles.SelectAll();
                txtGallons.Clear();
            }
        }

        // When clicked, This will clear all data entered and old data displayed.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGallons.Clear();
            txtMiles.Clear();
            lblDisplayMPG.Text = string.Empty;
            txtMiles.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When clicked, this will show the about form.
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout ofrmAbout = new frmAbout();
            ofrmAbout.ShowDialog();
        }
    }
}
