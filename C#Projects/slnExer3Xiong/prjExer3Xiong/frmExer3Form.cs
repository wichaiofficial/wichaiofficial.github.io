using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExer3Xiong
{
    public partial class frmExer3Form : Form
    {
        private double Item = 99;
        private double Sales_Commission = .05;
        private double More_Commission = .1;
        public frmExer3Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantitySold.Clear();
            lblDisplay.Text = String.Empty;
            txtQuantitySold.Focus();
            txtQuantitySold.SelectAll();
        }

        private void txtQuantitySold_TextChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = String.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblSales;
            double dblDiscount;
            double dblTotal;

            // This will convert the text entered by user into a double 
            // base off the amount of sales entered will calcualte the total amount due
            // if the value entered is a negative number or none numeric number will give user error and option to cancel or retry
            if (double.TryParse(txtQuantitySold.Text, out dblSales) && dblSales >=1)
            {
                if (dblSales < 10)
                {
                    dblTotal = dblSales * Item;
                    lblDisplay.Text = dblTotal.ToString("C");
                }
                if (dblSales >= 10 && dblSales < 20)
                {
                    dblDiscount = dblSales * Sales_Commission;
                    dblTotal = (dblSales * Item) - dblDiscount;
                    lblDisplay.Text = dblTotal.ToString("C");
                }
                if (dblSales > 20)
                {
                    dblDiscount = dblSales * More_Commission;
                    dblTotal = (dblSales * Item) - dblDiscount;
                    lblDisplay.Text = dblTotal.ToString("C");
                }
            }
            else
            {
                MessageBox.Show("Not Valid Numeric Value",
                                "Error", MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                txtQuantitySold.Focus();
                txtQuantitySold.SelectAll();
            }
        }
    }
}