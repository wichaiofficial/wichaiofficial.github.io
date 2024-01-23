
namespace prjMilesToKilometers
{
    partial class frmMilesToKilometers
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(63, 175);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(155, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(247, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(55, 40);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(31, 13);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "Miles";
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Location = new System.Drawing.Point(55, 120);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(55, 13);
            this.lblKilometers.TabIndex = 2;
            this.lblKilometers.Text = "Kilometers";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(130, 37);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 1;
            this.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMiles.TextChanged += new System.EventHandler(this.txtMiles_TextChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(130, 115);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMilesToKilometers
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(382, 246);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Name = "frmMilesToKilometers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert Miles to Kilometers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblDisplay;
    }
}

