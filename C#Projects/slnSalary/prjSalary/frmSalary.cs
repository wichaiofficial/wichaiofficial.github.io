using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalary
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        // When clicked, this will close the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When clicked, this will clear the form and set focus back onto textbox.
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstDisplayDays.Items.Clear();
            txtDays.Clear();
            lblDisplay.Text = string.Empty;
            txtDays.Focus();
        }
        
        // This method will return a double for the total pay user will recieve.
        private double GetTotalPay(double dblSalaryPaid, double dblPayIncrease, double dblCounter)
        {
            return Math.Pow(dblPayIncrease, dblCounter) * dblSalaryPaid;
        }

        // When Clicked this will calculate salary for the amount of days worked.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double Salary_Paid = .01;
            const double Pay_Increase = 2;
            double dblDays; // Variale for the amount of days worked.

            lstDisplayDays.Items.Clear(); // Clears the list so calculation doesn't double.

            if (string.IsNullOrWhiteSpace(txtDays.Text))
            {
                MessageBox.Show("Please enter valid amount of days worked.");
            }
            else if(double.TryParse(txtDays.Text, out dblDays) && dblDays >0)
            {
                // Loop from 1 to amount of days user entered, and display amount of pay user will recieve per day work.
                for (double dblCounter = 0; dblCounter < dblDays; dblCounter ++)
                {
                    double dblTotalPay = GetTotalPay(Salary_Paid, Pay_Increase, dblCounter);
                    lblDisplay.Text = dblTotalPay.ToString("C");
                    lstDisplayDays.Items.Add("Pay for Day " + (dblCounter+1).ToString() + " = " + dblTotalPay.ToString("C"));
                    txtDays.Focus();
                    txtDays.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid amount of days worked.");
            }
        }

        // When new data is enter this will clear the displayed data.
        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            lstDisplayDays.Items.Clear();
            lblDisplay.Text = string.Empty;           
        }
    }
}
