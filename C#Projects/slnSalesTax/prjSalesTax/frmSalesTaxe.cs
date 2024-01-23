using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSalesTax
{
    public partial class frmSalesTaxe : Form
    {
        CTransaction oTrans;
        const double Tax_Rate = .05;

        public frmSalesTaxe()
        {
            InitializeComponent();
        }

        // When clicked, This will calculate the sales tax by calling the method and display the amount to user.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblSales;
            double dblTotal;
            oTrans = new CTransaction();
            oTrans.TaxRate = Tax_Rate;

            if (double.TryParse(txtSales.Text, out dblSales) && dblSales >0)
            {
                dblTotal = dblSales + oTrans.CalculateSalesTax(dblSales);
                lblDisplayTaxes.Text = oTrans.CalculateSalesTax(dblSales).ToString("C");
                lblDisplayTotal.Text = dblTotal.ToString("C");
                txtSales.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid Sales amount.");
                txtSales.Focus();
                txtSales.SelectAll();
            }
        }

        // When clicked, This will clear the displayed sales tax and total along with whatever data user entered.
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplayTaxes.Text = String.Empty;
            lblDisplayTotal.Text = String.Empty;
            txtSales.Clear();
            txtSales.Focus();
        }

        // When clicked, this will close out the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout ofrmAbout = new frmAbout();

            ofrmAbout.ShowDialog();
        }
    }
}
