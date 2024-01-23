using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExer2Xiong
{
    public partial class frmExer2Form : Form
    {
        public frmExer2Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the Application.
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears the the textbox and clear string in lblDisplay.
            txtBooks.Clear();
            txtDays.Clear();
            lblDisplay.Text = string.Empty;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a varibale for books overdue.
                int intBooks;

                // Create a varibale for days overdue.
                int intDays;

                // Create a varibale for fee due.
                double dblFees;

                // Get the number of days from textbox ane the number of books from textbox.
                intDays = int.Parse(txtDays.Text);
                intBooks = int.Parse(txtBooks.Text);

                // The math for Fee. (number of books x .05)number of days)
                dblFees = (intBooks * .05) * intDays;

                // Output the value to screen.
                lblDisplay.Text = dblFees.ToString("C");

                // Set the Focus back to textbox and clears days textbox.
                txtBooks.Focus();
                txtBooks.SelectAll();
            }
            catch (Exception)
            {
                // Display an error message.

                MessageBox.Show("Invalid data was entered!");
            }
        }
        

        private void txtBooks_TextChanged(object sender, EventArgs e)
        {
            // This event will occure whenever user types in the textbox.
            lblDisplay.Text = string.Empty;
            txtDays.Clear();
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            // This event will occure whenever the user types in the textbox.
            lblDisplay.Text = string.Empty;
        }
    }
}
