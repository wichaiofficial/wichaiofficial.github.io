using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjInchesToCentimeters
{
    public partial class frmInchesToCentimeters : Form
    {
        public frmInchesToCentimeters()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create a varibale for the inches
            double dblInches;

            // Create a varibale for the Centimeters
            double dblCentimeters;

            // Get the inches from the screen
            dblInches = double.Parse(txtInches.Text);

            // Do the math (1 inch = 2.45 centimeters)
            dblCentimeters = dblInches * 2.54;

            // Output the value to the screen
            lblCentimeters.Text = dblCentimeters.ToString("N2");

            // Set the focus to the textbox
            txtInches.Focus();
            txtInches.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInches.Clear();
            lblCentimeters.Text = string.Empty;

            // Set the focus to the textbox
            txtInches.Focus();
            txtInches.SelectAll();
        }

        private void txtInches_TextChanged(object sender, EventArgs e)
        {
            // this event will fire off anytime the user types in the textbox
            lblCentimeters.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Get out
            Application.Exit();
        }
    }
}
