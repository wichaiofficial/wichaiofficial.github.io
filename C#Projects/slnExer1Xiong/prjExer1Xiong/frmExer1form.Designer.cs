
namespace prjExer1Xiong
{
    partial class frmExer1form
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCisFun = new System.Windows.Forms.Label();
            this.lblFvtc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(13, 184);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(65, 30);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(209, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCisFun
            // 
            this.lblCisFun.AutoSize = true;
            this.lblCisFun.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCisFun.ForeColor = System.Drawing.Color.Maroon;
            this.lblCisFun.Location = new System.Drawing.Point(52, 78);
            this.lblCisFun.Name = "lblCisFun";
            this.lblCisFun.Size = new System.Drawing.Size(87, 20);
            this.lblCisFun.TabIndex = 3;
            this.lblCisFun.Text = "C# is Fun!";
            // 
            // lblFvtc
            // 
            this.lblFvtc.AutoSize = true;
            this.lblFvtc.Location = new System.Drawing.Point(52, 113);
            this.lblFvtc.Name = "lblFvtc";
            this.lblFvtc.Size = new System.Drawing.Size(143, 13);
            this.lblFvtc.TabIndex = 4;
            this.lblFvtc.Text = "Fox Valley Technical College";
            // 
            // frmExer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(326, 243);
            this.Controls.Add(this.lblFvtc);
            this.Controls.Add(this.lblCisFun);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Name = "frmExer1";
            this.Text = "Intro to C#~Exercise 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCisFun;
        private System.Windows.Forms.Label lblFvtc;
    }
}

