
namespace prjComparePopulation
{
    partial class frmComparePopulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPopulation1 = new System.Windows.Forms.TextBox();
            this.txtPopulation2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDisplayDecrease = new System.Windows.Forms.Label();
            this.lblDisplayIncrease = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(32, 265);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(124, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(216, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "State";
            // 
            // txtPopulation1
            // 
            this.txtPopulation1.Location = new System.Drawing.Point(35, 158);
            this.txtPopulation1.Name = "txtPopulation1";
            this.txtPopulation1.Size = new System.Drawing.Size(100, 20);
            this.txtPopulation1.TabIndex = 4;
            // 
            // txtPopulation2
            // 
            this.txtPopulation2.Location = new System.Drawing.Point(35, 207);
            this.txtPopulation2.Name = "txtPopulation2";
            this.txtPopulation2.Size = new System.Drawing.Size(100, 20);
            this.txtPopulation2.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(35, 44);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 1;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(166, 43);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(45, 20);
            this.txtState.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.lblDisplayDecrease);
            this.groupBox1.Controls.Add(this.lblDisplayIncrease);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(153, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Percent Change";
            // 
            // lblDisplayDecrease
            // 
            this.lblDisplayDecrease.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayDecrease.Location = new System.Drawing.Point(24, 97);
            this.lblDisplayDecrease.Name = "lblDisplayDecrease";
            this.lblDisplayDecrease.Size = new System.Drawing.Size(100, 22);
            this.lblDisplayDecrease.TabIndex = 3;
            this.lblDisplayDecrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDisplayIncrease
            // 
            this.lblDisplayIncrease.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayIncrease.Location = new System.Drawing.Point(24, 47);
            this.lblDisplayIncrease.Name = "lblDisplayIncrease";
            this.lblDisplayIncrease.Size = new System.Drawing.Size(100, 23);
            this.lblDisplayIncrease.TabIndex = 1;
            this.lblDisplayIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Percent Decrease";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Percent Increase";
            // 
            // frmComparePopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPopulation2);
            this.Controls.Add(this.txtPopulation1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmComparePopulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare Population";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPopulation1;
        private System.Windows.Forms.TextBox txtPopulation2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDisplayDecrease;
        private System.Windows.Forms.Label lblDisplayIncrease;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

