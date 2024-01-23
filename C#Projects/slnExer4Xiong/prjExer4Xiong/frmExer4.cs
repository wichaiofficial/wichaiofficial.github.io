using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExer4Xiong
{
    public partial class frmExer4 : Form
    {
        public frmExer4()
        {
            InitializeComponent();
        }

        // When clicked, this will clear text box and everything displayed in the listbox. This will also set focus back to textbox.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCost.Clear();
            txtCost.Focus();
            lstDisplay.Items.Clear();
        }

        // When new data is entered will clear displayed data in listbox.
        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
        }

        // When clicked, this will Exit the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When clicked, will calculate how much it'll cost for 18 credits depending on the cost per credit user entered.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
             const int Max_Value = 18;
            double dblTuition; // Variable for Tuition cost in textbox

            lstDisplay.Items.Clear(); // Clears the listbox everytime the user clicks calculate that way it does not double.         
            if (string.IsNullOrWhiteSpace(txtCost.Text))
            {
                MessageBox.Show("Please Enter Cost for Tuition");
            }
            else if (double.TryParse(txtCost.Text, out dblTuition) && dblTuition >=0)
            {
                // Loop from 1 to 18 and send focus back to textbox.
                for (double dblCounter = 1; dblCounter <= Max_Value; dblCounter ++)
                {
                    double dblTotal;
                    dblTotal = dblCounter * dblTuition;
                    lstDisplay.Items.Add(dblCounter.ToString() + " credits ~ "+ dblTotal.ToString("C"));
                    txtCost.Focus();
                    txtCost.SelectAll();                   
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Tuition Cost");
            }
        }
    }
}
