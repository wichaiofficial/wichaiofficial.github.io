using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFVTCBookSales
{
    public partial class frmFVTCBookSales : Form
    {
        public frmFVTCBookSales()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears the textbox and clear string in lblDisplay.
            txtInput.Clear();
            lblDisplay.Text = string.Empty;
            lblDiscount.Text = string.Empty;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // This event will occure whenever user types in the textbox.
            lblDisplay.Text = string.Empty;
            lblDiscount.Text = string.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create a variable for Total Price
            double dblTotal;

            // Create a variable for New Discounted Pice

            double dblDiscount;

            // Create a variable for Amount Saved

            double dblSavings;

            // Get the Total Price from Textbox.
            dblTotal = double.Parse(txtInput.Text);

            // The math for Discounted Amount ( Total price * .25 = dblSavings)
            dblSavings = dblTotal * .25;
            dblDiscount = dblTotal - dblSavings;

            // Output the Value to screen
            lblDisplay.Text = dblDiscount.ToString("C");
            lblDiscount.Text = dblSavings.ToString("C");

            // Set the focus back to Textbox
            txtInput.Focus();
            txtInput.SelectAll();

            
        }
    }
}
