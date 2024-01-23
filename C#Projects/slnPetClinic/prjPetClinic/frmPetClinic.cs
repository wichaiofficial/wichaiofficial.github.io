using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPetClinic
{
    public partial class frmPetClinic : Form
    {
        // Field variable to hold the total.
        // Initialized with 0
        private decimal scope = 0m;

        public frmPetClinic()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // When this button is clicked it will close out the application.
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // When this button is clicked it will Clear out the total price, the displayed prices of the services, and all the check boxes.
            lblDisplay.Text = string.Empty;
            lblPrice1.Text = string.Empty;
            lblPrice2.Text = string.Empty;
            lblPrice3.Text = string.Empty;
            lblPrice4.Text = string.Empty;
            lblPrice5.Text = string.Empty;
            lblPrice6.Text = string.Empty;
            lblPrice7.Text = string.Empty;
            lblPrice8.Text = string.Empty;
            chkBehavioral.Checked = false;
            chkVaccination.Checked = false;
            chkMicro.Checked = false;
            chkDiagnostics.Checked = false;
            chkSurgical.Checked = false;
            chkWellness.Checked = false;
            chkDental.Checked = false;
            chkNutrition.Checked = false;
        }

        private void chkVaccination_CheckedChanged(object sender, EventArgs e)
        {
            // If this checkbox is checked it will display the cost of the service on the right of the service name.
            if (chkVaccination.Checked)
            {
                // Create variable for vaccination price.
                decimal decVaccinationPrice;
                decVaccinationPrice = 500;
                // This will display the cost of the service.
                lblPrice1.Text = decVaccinationPrice.ToString("C");
                // Add the service price to Class-level scope.
                scope += 500;
                // Display the updated total.
                lblDisplay.Text = scope.ToString("C");
            }
            else
            {
                // If the checkbox is unchecked this will clear out the price shown.
                lblPrice1.Text = string.Empty;
                // Subtract the service price to Class-level scope.
                scope -= 500;
                lblDisplay.Text = scope.ToString("C");

            }
        }

        private void chkMicro_CheckedChanged(object sender, EventArgs e)
        {
            // If this checkbox is checked it will display the cost of the service on the right of the service name.
            if (chkMicro.Checked)
            {
                // Create variable for vaccination price
                decimal decMicroPrice;
                decMicroPrice = 800;
                // This will display the service price.
                lblPrice2.Text = decMicroPrice.ToString("C");
                // Add the service price to Class-level scope.
                scope += 800;
                // Display the updated total.
                lblDisplay.Text = scope.ToString("C");
            }
            else
            {
                // If the checkbox is unchecked this will clear out the price shown.
                lblPrice2.Text = string.Empty;
                // Subtract the service price to Class-level scope.
                scope -= 800;
                lblDisplay.Text = scope.ToString("C");
            }
        }

        private void chkSurgical_CheckedChanged(object sender, EventArgs e)
        {
            // If this checkbox is checked it will display the cost of the service on the right of the service name.
            if (chkSurgical.Checked)
            {
                // Create variable for vaccination price
                decimal decSurgicalPrice;
                decSurgicalPrice = 800;
                // This will display the service price.
                lblPrice3.Text = decSurgicalPrice.ToString("C");
                // Add the service price to Class-level scope.
                scope += 800;
                // Display the updated total.
                lblDisplay.Text = scope.ToString("C");
            }
            else
            {
                // If the checkbox is unchecked this will clear out the price shown.
                lblPrice3.Text = string.Empty;
                // Subtract the service price to Class-level scope.
                scope -= 800;
                lblDisplay.Text = scope.ToString("C");
            }
        }

        private void chkDiagnostics_CheckedChanged(object sender, EventArgs e)
        {
            // If this checkbox is checked it will display the cost of the service on the right of the service name.
            if (chkDiagnostics.Checked)
            {
                // Create variable for vaccination price
                decimal decDiagnosticsPrice;
                decDiagnosticsPrice = 300;
                // This will display the service price.
                lblPrice4.Text = decDiagnosticsPrice.ToString("C");
                // Add the service price to Class-level scope.
                scope += 300;
                // Display the updated total.
                lblDisplay.Text = scope.ToString("C");
            }
            else
            {
                // If the checkbox is unchecked this will clear out the price shown.
                lblPrice4.Text = string.Empty;
                // Subtract the service price to Class-level scope.
                scope -= 300;
                lblDisplay.Text = scope.ToString("C");
            }
        }

        private void chkBehvioral_CheckedChanged(object sender, EventArgs e)
        {
            // If this checkbox is checked it will display the cost of the service on the right of the service name.
            if (chkBehavioral.Checked)
            {
                // Create variable for vaccination price
                decimal decbehavioralPrice;
                decbehavioralPrice = 200;
                // This will display the service price.
                lblPrice5.Text = decbehavioralPrice.ToString("C");
                // Add the service price to Class-level scope.
                scope += 200;
                // Display the updated total.
                lblDisplay.Text = scope.ToString("C");
            }
            else
            {
                // If the checkbox is unchecked this will clear out the price shown.
                lblPrice5.Text = string.Empty;
                // Subtract the service price to Class-level scope.
                scope -= 200;
                lblDisplay.Text = scope.ToString("C");
            }
        }

        private void chkDental_CheckedChanged(object sender, EventArgs e)
        {
            // If this checkbox is checked it will display the cost of the service on the right of the service name.
            if (chkDental.Checked)
            {
                // Create variable for vaccination price
                decimal decDentalPrice;
                decDentalPrice = 400;
                // This will display the service price
                lblPrice6.Text = decDentalPrice.ToString("C");
                // Add the service price to Class-level scope.
                scope += 200;
                // Display the updated total.
                lblDisplay.Text = scope.ToString("C");
            }
            else
            {
                // If the checkbox is unchecked this will clear out the price shown.
                lblPrice6.Text = string.Empty;
                // Subtract the service price to Class-level scope.
                scope -= 400;
                lblDisplay.Text = scope.ToString("C");
            }
        }

        private void chkNutrition_CheckedChanged(object sender, EventArgs e)
        {
            // If this checkbox is checked it will display the cost of the service on the right of the service name.
            if (chkNutrition.Checked)
            {
                // Create variable for vaccination price
                decimal decNutritionPrice;
                decNutritionPrice = 150;
                // This will display the service price
                lblPrice7.Text = decNutritionPrice.ToString("C");
                // Add the service price to Class-level scope.
                scope += 150;
                // Display the updated total.
                lblDisplay.Text = scope.ToString("C");
            }
            else
            {
                // If the checkbox is unchecked this will clear out the price shown.
                lblPrice7.Text = string.Empty;
                // Subtract the service price to Class-level scope.
                scope -= 150;
                lblDisplay.Text = scope.ToString("C");
            }
        }

        private void chkWellness_CheckedChanged(object sender, EventArgs e)
        {
            // If this checkbox is checked it will display the cost of the service on the right of the service name.
            if (chkWellness.Checked)
            {
                // Create variable for vaccination price
                decimal decWellnessPrice;
                decWellnessPrice = 200;
                // This will display the service price
                lblPrice8.Text = decWellnessPrice.ToString("C");
                // Add the service price to Class-level scope.
                scope += 200;
                // Display the updated total.
                lblDisplay.Text = scope.ToString("C");
            }
            else
            {
                // If the checkbox is unchecked this will clear out the price shown.
                lblPrice8.Text = string.Empty;
                // Subtract the service price to Class-level scope.
                scope -= 200;
                lblDisplay.Text = scope.ToString("C");
            }
        }


    }
    }

