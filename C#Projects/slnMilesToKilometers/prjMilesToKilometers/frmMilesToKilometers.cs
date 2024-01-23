using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMilesToKilometers
{
    public partial class frmMilesToKilometers : Form
    {
        public frmMilesToKilometers()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Create a variable for Miles
            double dblMiles;

            // Create a variable for the Kilometers
            double dblKilometers;

            // Get the inches from the screen
            dblMiles = double.Parse(txtMiles.Text);

            // The Math ( 1 Mile = 1.61 Kilometers)
            dblKilometers = dblMiles * 1.61;

            // Output the Value to screen
            lblDisplay.Text = dblKilometers.ToString("N2");

            // Set the focuse back to textbox
            txtMiles.Focus();
            txtMiles.SelectAll();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears textbox and Clear string in lblDisplay
            txtMiles.Clear();
            lblDisplay.Text = string.Empty;
        }

        private void txtMiles_TextChanged(object sender, EventArgs e)
        {
            // This event will occure whenever user types in the textbox.
            lblDisplay.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the Application
            Application.Exit();
        }
    }
}
