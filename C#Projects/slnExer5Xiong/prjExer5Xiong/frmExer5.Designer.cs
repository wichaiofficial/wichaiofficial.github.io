
namespace prjExer5Xiong
{
    partial class frmExer5
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
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.lblGallonsUsed = new System.Windows.Forms.Label();
            this.lblMPG = new System.Windows.Forms.Label();
            this.lblDisplayMPG = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.AutoSize = true;
            this.lblMilesDriven.Location = new System.Drawing.Point(41, 39);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(68, 13);
            this.lblMilesDriven.TabIndex = 0;
            this.lblMilesDriven.Text = "Miles Driven:";
            // 
            // lblGallonsUsed
            // 
            this.lblGallonsUsed.AutoSize = true;
            this.lblGallonsUsed.Location = new System.Drawing.Point(41, 90);
            this.lblGallonsUsed.Name = "lblGallonsUsed";
            this.lblGallonsUsed.Size = new System.Drawing.Size(73, 13);
            this.lblGallonsUsed.TabIndex = 2;
            this.lblGallonsUsed.Text = "Gallons Used:";
            // 
            // lblMPG
            // 
            this.lblMPG.AutoSize = true;
            this.lblMPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPG.Location = new System.Drawing.Point(92, 217);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(103, 13);
            this.lblMPG.TabIndex = 7;
            this.lblMPG.Text = "Miles Per Gallon:";
            // 
            // lblDisplayMPG
            // 
            this.lblDisplayMPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayMPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayMPG.Location = new System.Drawing.Point(201, 217);
            this.lblDisplayMPG.Name = "lblDisplayMPG";
            this.lblDisplayMPG.Size = new System.Drawing.Size(130, 23);
            this.lblDisplayMPG.TabIndex = 8;
            this.lblDisplayMPG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(47, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 28);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(128, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(209, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(256, 267);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 28);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(136, 36);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 1;
            this.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(136, 87);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(100, 20);
            this.txtGallons.TabIndex = 3;
            this.txtGallons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmExer5
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(361, 322);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDisplayMPG);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.lblGallonsUsed);
            this.Controls.Add(this.lblMilesDriven);
            this.Name = "frmExer5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise 5 ~ Miles per Gallon v2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilesDriven;
        private System.Windows.Forms.Label lblGallonsUsed;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.Label lblDisplayMPG;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtGallons;
    }
}

