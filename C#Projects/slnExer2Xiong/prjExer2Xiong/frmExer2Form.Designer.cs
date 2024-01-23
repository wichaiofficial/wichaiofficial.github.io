
namespace prjExer2Xiong
{
    partial class frmExer2Form
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
            this.lblFine = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumberOfBooks = new System.Windows.Forms.Label();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFine
            // 
            this.lblFine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(100, 247);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(57, 26);
            this.lblFine.TabIndex = 0;
            this.lblFine.Text = "Fine";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(181, 247);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(57, 26);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(41, 198);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(65, 32);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNumberOfBooks
            // 
            this.lblNumberOfBooks.AutoSize = true;
            this.lblNumberOfBooks.Location = new System.Drawing.Point(52, 50);
            this.lblNumberOfBooks.Name = "lblNumberOfBooks";
            this.lblNumberOfBooks.Size = new System.Drawing.Size(120, 26);
            this.lblNumberOfBooks.TabIndex = 5;
            this.lblNumberOfBooks.Text = "Enter the number of \r\nbooks that are overdue ";
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(52, 124);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(91, 26);
            this.lblNumberOfDays.TabIndex = 6;
            this.lblNumberOfDays.Text = "Enter the number \r\nof days overdue ";
            // 
            // txtBooks
            // 
            this.txtBooks.BackColor = System.Drawing.SystemColors.Control;
            this.txtBooks.Location = new System.Drawing.Point(185, 56);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(83, 20);
            this.txtBooks.TabIndex = 7;
            this.txtBooks.TextChanged += new System.EventHandler(this.txtBooks_TextChanged);
            // 
            // txtDays
            // 
            this.txtDays.BackColor = System.Drawing.SystemColors.Control;
            this.txtDays.Location = new System.Drawing.Point(185, 130);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(83, 20);
            this.txtDays.TabIndex = 8;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // frmExer2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 300);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.lblNumberOfBooks);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblFine);
            this.Name = "frmExer2Form";
            this.Text = "Exercise 2 ~ Library Fine Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumberOfBooks;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.TextBox txtDays;
    }
}

