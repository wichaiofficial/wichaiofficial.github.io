using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalesCommision
{
    public partial class frmSalesCommission : Form
    {
        public const double Commission_Rate = .10;
        public frmSalesCommission()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // By clicking Clear this will clear out input data from the user and displayed commission data calculated.
            lblDisplayName.Text = String.Empty;
            lblDisplayCommission.Text = String.Empty;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtSales.Clear();
            txtLastName.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Varibales for the sales amount first and last name of the sales rep.
            double dblSales;
            double dblCommssion;
            string strLastName = txtLastName.Text;
            string strFirstName = txtFirstName.Text;

            // Setting up the input validation.
            if (Double.TryParse(txtSales.Text, out dblSales))
            {
                //Figure out the Sales Commission if no names are entered.
                if ((txtFirstName.Text =="")||(txtLastName.Text ==""))
                {
                    // The Math for the Commission Rate.
                    dblCommssion = dblSales * Commission_Rate;

                    // Displays the Commission Rate.
                    lblDisplayCommission.Text = dblCommssion.ToString("C");                  
                }
                else
                {
                    // The Math for the Commission Rate.
                    dblCommssion = dblSales * Commission_Rate;
                    // Displays the Sales reps Name and commission rate.
                    lblDisplayCommission.Text = dblCommssion.ToString("C");
                    lblDisplayName.Text = "Commission for " + strFirstName + " " + strLastName;

                }
            }
            else
            {
                MessageBox.Show("Not Valid Numeric Value",
                                "Error", MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                txtSales.Focus();
                txtSales.SelectAll();

            }

        }
    }
}
