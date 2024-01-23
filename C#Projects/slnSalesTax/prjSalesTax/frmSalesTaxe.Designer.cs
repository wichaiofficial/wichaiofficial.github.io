
namespace prjSalesTax
{
    partial class frmSalesTaxe
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.lblDisplayTaxes = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 195);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(170, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(294, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(72, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price: ";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(49, 104);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(60, 13);
            this.lblSalesTax.TabIndex = 2;
            this.lblSalesTax.Text = "Sales Tax: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(49, 146);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Due: ";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayTotal.Location = new System.Drawing.Point(128, 136);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(159, 23);
            this.lblDisplayTotal.TabIndex = 5;
            this.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDisplayTaxes
            // 
            this.lblDisplayTaxes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayTaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayTaxes.Location = new System.Drawing.Point(128, 94);
            this.lblDisplayTaxes.Name = "lblDisplayTaxes";
            this.lblDisplayTaxes.Size = new System.Drawing.Size(159, 23);
            this.lblDisplayTaxes.TabIndex = 3;
            this.lblDisplayTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(128, 40);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(159, 20);
            this.txtSales.TabIndex = 1;
            this.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(294, 240);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmSalesTaxe
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(437, 275);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.lblDisplayTaxes);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSalesTax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmSalesTaxe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Tax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Label lblDisplayTaxes;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnAbout;
    }
}

