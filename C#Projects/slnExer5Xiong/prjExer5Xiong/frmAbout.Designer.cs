
namespace prjExer5Xiong
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDisciption = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(209, 26);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(150, 88);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Developed by: Wichai Xiong";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(28, 54);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 2.0.0";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(28, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "December 15, 2021";
            // 
            // lblDisciption
            // 
            this.lblDisciption.AutoSize = true;
            this.lblDisciption.Location = new System.Drawing.Point(116, 149);
            this.lblDisciption.Name = "lblDisciption";
            this.lblDisciption.Size = new System.Drawing.Size(123, 13);
            this.lblDisciption.TabIndex = 3;
            this.lblDisciption.Text = "Written for C# intro class";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(284, 144);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 197);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblDisciption);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxLogo);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About ... Miles per Gallon";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDisciption;
        private System.Windows.Forms.Button btnOk;
    }
}