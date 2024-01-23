
namespace prjFlags
{
    partial class frmFlags
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
            this.lblPromt = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.pbxGermany = new System.Windows.Forms.PictureBox();
            this.pbxFrance = new System.Windows.Forms.PictureBox();
            this.pbxFinland = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGermany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFinland)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPromt
            // 
            this.lblPromt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromt.ForeColor = System.Drawing.Color.Blue;
            this.lblPromt.Location = new System.Drawing.Point(132, 24);
            this.lblPromt.Name = "lblPromt";
            this.lblPromt.Size = new System.Drawing.Size(319, 33);
            this.lblPromt.TabIndex = 0;
            this.lblPromt.Text = "Click a flag to see the name of the country.";
            this.lblPromt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInformation
            // 
            this.lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Blue;
            this.lblInformation.Location = new System.Drawing.Point(132, 199);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(319, 33);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxGermany
            // 
            this.pbxGermany.Image = global::prjFlags.Properties.Resources.Germany;
            this.pbxGermany.Location = new System.Drawing.Point(419, 92);
            this.pbxGermany.Name = "pbxGermany";
            this.pbxGermany.Size = new System.Drawing.Size(120, 70);
            this.pbxGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxGermany.TabIndex = 4;
            this.pbxGermany.TabStop = false;
            this.pbxGermany.Click += new System.EventHandler(this.pbxGermany_Click);
            // 
            // pbxFrance
            // 
            this.pbxFrance.Image = global::prjFlags.Properties.Resources.France;
            this.pbxFrance.Location = new System.Drawing.Point(231, 92);
            this.pbxFrance.Name = "pbxFrance";
            this.pbxFrance.Size = new System.Drawing.Size(120, 70);
            this.pbxFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxFrance.TabIndex = 3;
            this.pbxFrance.TabStop = false;
            this.pbxFrance.Click += new System.EventHandler(this.pbxFrance_Click);
            // 
            // pbxFinland
            // 
            this.pbxFinland.Image = global::prjFlags.Properties.Resources.Finland;
            this.pbxFinland.Location = new System.Drawing.Point(43, 92);
            this.pbxFinland.Name = "pbxFinland";
            this.pbxFinland.Size = new System.Drawing.Size(120, 70);
            this.pbxFinland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxFinland.TabIndex = 2;
            this.pbxFinland.TabStop = false;
            this.pbxFinland.Click += new System.EventHandler(this.pbxFinland_Click);
            // 
            // frmFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 250);
            this.Controls.Add(this.pbxGermany);
            this.Controls.Add(this.pbxFrance);
            this.Controls.Add(this.pbxFinland);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblPromt);
            this.Name = "frmFlags";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGermany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFinland)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromt;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox pbxFinland;
        private System.Windows.Forms.PictureBox pbxFrance;
        private System.Windows.Forms.PictureBox pbxGermany;
    }
}

