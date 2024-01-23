using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjComparePopulation
{
    public partial class frmComparePopulation : Form
    {
        public frmComparePopulation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // varibales
            double dblPopulation1;
            double dblPopulation2;
            string strCity;
            string strState;
            string strCityState;
            string strIncrease;
            string strDecrease;
            double dblIncrease;
            double dblDecrease;
            if (double.TryParse(txtPopulation1.Text, out dblPopulation1) && double.TryParse(txtPopulation2.Text, out dblPopulation2) && dblPopulation1 >= 1 && dblPopulation2 >= 1)
            {
                dblPopulation1 = int.Parse(txtPopulation1.Text);
                dblPopulation2 = int.Parse(txtPopulation2.Text);
                strCity = txtCity.Text;
                strState = txtState.Text;
                strCityState = "No Change in population for " + strCity + ", " + strState.ToUpper();
                strIncrease = "Increase in Population for " + strCity + ", " + strState.ToUpper();
                strDecrease = "Decrease in Population for " + strCity + ", " + strState.ToUpper();

                if (txtCity.Text == "" || txtState.Text == "")
                {
                    MessageBox.Show("Please Enter City and State",
                            "Error", MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Error);
                    lblDisplayDecrease.Text = String.Empty;
                    lblDisplayIncrease.Text = String.Empty;
                    txtPopulation1.Clear();
                    txtPopulation2.Clear();
                    txtState.Clear();
                    txtCity.Focus();
                    txtCity.SelectAll();
                }
                else if (dblPopulation1 == dblPopulation2)
                {
                    MessageBox.Show(strCityState, "No Change in Population");
                }
                else if (dblPopulation2 > dblPopulation1)
                {                  
                    dblIncrease = (dblPopulation2 - dblPopulation1)/dblPopulation1;
                    lblDisplayIncrease.Text = dblIncrease.ToString("P");
                    MessageBox.Show(strIncrease, "Increase in Population");
                }
                else if (dblPopulation2 < dblPopulation1)
                {
                    dblDecrease = (dblPopulation1 - dblPopulation2) / dblPopulation1;
                    lblDisplayDecrease.Text = dblDecrease.ToString("P");
                    MessageBox.Show(strDecrease, "Decrease in Population");
                }
            }
            else
            {
                // This will clear all data entered in the textboxes, any strings in the lables and reset focus back onto City textbox.
                MessageBox.Show("Not Valid Numeric Value For Population",
                                "Error", MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                lblDisplayDecrease.Text = String.Empty;
                lblDisplayIncrease.Text = String.Empty;
                txtPopulation1.Clear();
                txtPopulation2.Clear();
                txtState.Clear();
                txtCity.Focus();
                txtCity.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplayDecrease.Text = String.Empty;
            lblDisplayIncrease.Text = String.Empty;
            txtPopulation1.Clear();
            txtPopulation2.Clear();
            txtState.Clear();
            txtCity.Focus();
            txtCity.Clear();
        }
    }
}
