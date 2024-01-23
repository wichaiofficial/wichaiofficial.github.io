
namespace prjSalesCommision
{
    partial class frmSalesCommission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLastNamePromt = new System.Windows.Forms.Label();
            this.lblFirstNamePromt = new System.Windows.Forms.Label();
            this.lblSalesPromt = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblDisplayCommission = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLastNamePromt
            // 
            this.lblLastNamePromt.AutoSize = true;
            this.lblLastNamePromt.Location = new System.Drawing.Point(26, 26);
            this.lblLastNamePromt.Name = "lblLastNamePromt";
            this.lblLastNamePromt.Size = new System.Drawing.Size(64, 13);
            this.lblLastNamePromt.TabIndex = 0;
            this.lblLastNamePromt.Text = "Last Name :";
            // 
            // lblFirstNamePromt
            // 
            this.lblFirstNamePromt.AutoSize = true;
            this.lblFirstNamePromt.Location = new System.Drawing.Point(26, 52);
            this.lblFirstNamePromt.Name = "lblFirstNamePromt";
            this.lblFirstNamePromt.Size = new System.Drawing.Size(63, 13);
            this.lblFirstNamePromt.TabIndex = 2;
            this.lblFirstNamePromt.Text = "First Name :";
            // 
            // lblSalesPromt
            // 
            this.lblSalesPromt.AutoSize = true;
            this.lblSalesPromt.Location = new System.Drawing.Point(50, 78);
            this.lblSalesPromt.Name = "lblSalesPromt";
            this.lblSalesPromt.Size = new System.Drawing.Size(39, 13);
            this.lblSalesPromt.TabIndex = 4;
            this.lblSalesPromt.Text = "Sales :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(53, 125);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 22);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Commission";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(40, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(134, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Location = new System.Drawing.Point(53, 161);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(198, 23);
            this.lblDisplayName.TabIndex = 7;
            // 
            // lblDisplayCommission
            // 
            this.lblDisplayCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayCommission.Location = new System.Drawing.Point(53, 197);
            this.lblDisplayCommission.Name = "lblDisplayCommission";
            this.lblDisplayCommission.Size = new System.Drawing.Size(100, 23);
            this.lblDisplayCommission.TabIndex = 8;
            this.lblDisplayCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 19);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(95, 71);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 20);
            this.txtSales.TabIndex = 5;
            // 
            // frmSalesCommission
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(344, 304);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblDisplayCommission);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSalesPromt);
            this.Controls.Add(this.lblFirstNamePromt);
            this.Controls.Add(this.lblLastNamePromt);
            this.Name = "frmSalesCommission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Commission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastNamePromt;
        private System.Windows.Forms.Label lblFirstNamePromt;
        private System.Windows.Forms.Label lblSalesPromt;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblDisplayCommission;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSales;
    }
}

