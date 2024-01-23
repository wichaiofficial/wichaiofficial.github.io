
namespace prjInchesToCentimeters
{
    partial class frmInchesToCentimeters
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInches = new System.Windows.Forms.Label();
            this.lblCent = new System.Windows.Forms.Label();
            this.lblCentimeters = new System.Windows.Forms.Label();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(298, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(100, 210);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(97, 48);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(42, 13);
            this.lblInches.TabIndex = 3;
            this.lblInches.Text = "Inches:";
            // 
            // lblCent
            // 
            this.lblCent.AutoSize = true;
            this.lblCent.Location = new System.Drawing.Point(97, 96);
            this.lblCent.Name = "lblCent";
            this.lblCent.Size = new System.Drawing.Size(65, 13);
            this.lblCent.TabIndex = 4;
            this.lblCent.Text = "Centimeters:";
            // 
            // lblCentimeters
            // 
            this.lblCentimeters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentimeters.Location = new System.Drawing.Point(224, 86);
            this.lblCentimeters.Name = "lblCentimeters";
            this.lblCentimeters.Size = new System.Drawing.Size(123, 23);
            this.lblCentimeters.TabIndex = 5;
            this.lblCentimeters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(224, 41);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(123, 20);
            this.txtInches.TabIndex = 6;
            this.txtInches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInches.TextChanged += new System.EventHandler(this.txtInches_TextChanged);
            // 
            // frmInchesToCentimeters
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(443, 271);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.lblCentimeters);
            this.Controls.Add(this.lblCent);
            this.Controls.Add(this.lblInches);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "frmInchesToCentimeters";
            this.Text = "Inchest to Centimeters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Label lblCent;
        private System.Windows.Forms.Label lblCentimeters;
        private System.Windows.Forms.TextBox txtInches;
    }
}

