
namespace prjSalary
{
    partial class frmSalary
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
            this.lstDisplayDays = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromptDaysWorked = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDisplayDays
            // 
            this.lstDisplayDays.FormattingEnabled = true;
            this.lstDisplayDays.Location = new System.Drawing.Point(47, 68);
            this.lstDisplayDays.Name = "lstDisplayDays";
            this.lstDisplayDays.Size = new System.Drawing.Size(371, 173);
            this.lstDisplayDays.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(101, 276);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total Pay Earned:";
            // 
            // lblPromptDaysWorked
            // 
            this.lblPromptDaysWorked.AutoSize = true;
            this.lblPromptDaysWorked.Location = new System.Drawing.Point(97, 39);
            this.lblPromptDaysWorked.Name = "lblPromptDaysWorked";
            this.lblPromptDaysWorked.Size = new System.Drawing.Size(127, 13);
            this.lblPromptDaysWorked.TabIndex = 2;
            this.lblPromptDaysWorked.Text = "Number of Days Worked:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(230, 32);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 3;
            this.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(199, 266);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(219, 23);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(61, 316);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(189, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(317, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSalary
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(444, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblPromptDaysWorked);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstDisplayDays);
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earnings Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplayDays;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromptDaysWorked;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

