
namespace prjLooping
{
    partial class frmLooping
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
            this.lblPhrase = new System.Windows.Forms.Label();
            this.txtInputPhrase = new System.Windows.Forms.TextBox();
            this.lblPromt = new System.Windows.Forms.Label();
            this.txtInputRepition = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Location = new System.Drawing.Point(39, 40);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(40, 13);
            this.lblPhrase.TabIndex = 0;
            this.lblPhrase.Text = "Phrase";
            // 
            // txtInputPhrase
            // 
            this.txtInputPhrase.Location = new System.Drawing.Point(98, 37);
            this.txtInputPhrase.Name = "txtInputPhrase";
            this.txtInputPhrase.Size = new System.Drawing.Size(382, 20);
            this.txtInputPhrase.TabIndex = 1;
            // 
            // lblPromt
            // 
            this.lblPromt.AutoSize = true;
            this.lblPromt.Location = new System.Drawing.Point(52, 130);
            this.lblPromt.Name = "lblPromt";
            this.lblPromt.Size = new System.Drawing.Size(106, 13);
            this.lblPromt.TabIndex = 2;
            this.lblPromt.Text = "Number of repititions:";
            // 
            // txtInputRepition
            // 
            this.txtInputRepition.Location = new System.Drawing.Point(221, 127);
            this.txtInputRepition.Name = "txtInputRepition";
            this.txtInputRepition.Size = new System.Drawing.Size(100, 20);
            this.txtInputRepition.TabIndex = 3;
            this.txtInputRepition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(33, 188);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(447, 160);
            this.lstOutput.TabIndex = 4;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(69, 390);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(169, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(269, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLooping
            // 
            this.AcceptButton = this.btnDisplay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(525, 440);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtInputRepition);
            this.Controls.Add(this.lblPromt);
            this.Controls.Add(this.txtInputPhrase);
            this.Controls.Add(this.lblPhrase);
            this.Name = "frmLooping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who Me??";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.TextBox txtInputPhrase;
        private System.Windows.Forms.Label lblPromt;
        private System.Windows.Forms.TextBox txtInputRepition;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

