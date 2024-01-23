using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLooping
{
    public partial class frmLooping : Form
    {
        public frmLooping()
        {
            InitializeComponent();
        }

        // When clicked, This will close the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When clicked, This will Clear all textboxes and Listbox.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputPhrase.Clear();
            txtInputRepition.Clear();
            lstOutput.Items.Clear();
            txtInputPhrase.Focus();
        }
        // When clicked, Loops Users inputed phrase to Users inputed repitioned by 1
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Create a variable for phrase and repition user inputed.        
            int intRepition;
            string stringPhrase;
            stringPhrase = txtInputPhrase.Text;
            
            // Check to see if data was entered into the textboxes
            if (String.IsNullOrWhiteSpace(txtInputPhrase.Text) || String.IsNullOrWhiteSpace(txtInputRepition.Text))
            {
                // No data entered in Textboxes
                MessageBox.Show("Please Enter Values for Phrase and Repition");       
            }
            // Check to See if repition user entere parse out into an Int and if it is greater then 0 and not negative value.
            else if (int.TryParse(txtInputRepition.Text, out intRepition) && intRepition >= 0)
            {
                // Loop from 1 to number of repition that user inputed.
                for (int intCounter = 1; intCounter <= intRepition; intCounter++)
                {
                    lstOutput.Items.Add(intCounter + ". " + stringPhrase);
                }
            }
            // Display Error Message if invalid number was entered.
            else
            {
                MessageBox.Show("Please Valid Number for Repition");
            }
            }
            
        }
    }
