
namespace prjStateCapitals
{
    partial class frmStateCapitals
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
            this.btnWisconsin = new System.Windows.Forms.Button();
            this.btnMinnesota = new System.Windows.Forms.Button();
            this.btnMichigan = new System.Windows.Forms.Button();
            this.btnIllinois = new System.Windows.Forms.Button();
            this.btnCalifornia = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIs = new System.Windows.Forms.Label();
            this.lblThecapitalof = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWisconsin
            // 
            this.btnWisconsin.Location = new System.Drawing.Point(43, 57);
            this.btnWisconsin.Name = "btnWisconsin";
            this.btnWisconsin.Size = new System.Drawing.Size(75, 23);
            this.btnWisconsin.TabIndex = 0;
            this.btnWisconsin.Text = "Wisconsin";
            this.btnWisconsin.UseVisualStyleBackColor = true;
            this.btnWisconsin.Click += new System.EventHandler(this.btnWisconsin_Click);
            // 
            // btnMinnesota
            // 
            this.btnMinnesota.Location = new System.Drawing.Point(43, 105);
            this.btnMinnesota.Name = "btnMinnesota";
            this.btnMinnesota.Size = new System.Drawing.Size(75, 23);
            this.btnMinnesota.TabIndex = 1;
            this.btnMinnesota.Text = "Minnesota";
            this.btnMinnesota.UseVisualStyleBackColor = true;
            this.btnMinnesota.Click += new System.EventHandler(this.btnMinnesota_Click);
            // 
            // btnMichigan
            // 
            this.btnMichigan.Location = new System.Drawing.Point(43, 153);
            this.btnMichigan.Name = "btnMichigan";
            this.btnMichigan.Size = new System.Drawing.Size(75, 23);
            this.btnMichigan.TabIndex = 2;
            this.btnMichigan.Text = "Michigan";
            this.btnMichigan.UseVisualStyleBackColor = true;
            this.btnMichigan.Click += new System.EventHandler(this.btnMichigan_Click);
            // 
            // btnIllinois
            // 
            this.btnIllinois.Location = new System.Drawing.Point(43, 201);
            this.btnIllinois.Name = "btnIllinois";
            this.btnIllinois.Size = new System.Drawing.Size(75, 23);
            this.btnIllinois.TabIndex = 3;
            this.btnIllinois.Text = "Illinois";
            this.btnIllinois.UseVisualStyleBackColor = true;
            this.btnIllinois.Click += new System.EventHandler(this.btnIllinois_Click);
            // 
            // btnCalifornia
            // 
            this.btnCalifornia.Location = new System.Drawing.Point(43, 249);
            this.btnCalifornia.Name = "btnCalifornia";
            this.btnCalifornia.Size = new System.Drawing.Size(75, 23);
            this.btnCalifornia.TabIndex = 4;
            this.btnCalifornia.Text = "California";
            this.btnCalifornia.UseVisualStyleBackColor = true;
            this.btnCalifornia.Click += new System.EventHandler(this.btnCalifornia_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblIs
            // 
            this.lblIs.AutoSize = true;
            this.lblIs.Location = new System.Drawing.Point(179, 143);
            this.lblIs.Name = "lblIs";
            this.lblIs.Size = new System.Drawing.Size(14, 13);
            this.lblIs.TabIndex = 7;
            this.lblIs.Text = "is";
            // 
            // lblThecapitalof
            // 
            this.lblThecapitalof.AutoSize = true;
            this.lblThecapitalof.Location = new System.Drawing.Point(179, 46);
            this.lblThecapitalof.Name = "lblThecapitalof";
            this.lblThecapitalof.Size = new System.Drawing.Size(72, 13);
            this.lblThecapitalof.TabIndex = 8;
            this.lblThecapitalof.Text = "The capital of";
            // 
            // lblCapital
            // 
            this.lblCapital.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCapital.Location = new System.Drawing.Point(216, 157);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(111, 24);
            this.lblCapital.TabIndex = 9;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(216, 72);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(111, 24);
            this.lblState.TabIndex = 10;
            // 
            // frmStateCapitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 329);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.lblThecapitalof);
            this.Controls.Add(this.lblIs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalifornia);
            this.Controls.Add(this.btnIllinois);
            this.Controls.Add(this.btnMichigan);
            this.Controls.Add(this.btnMinnesota);
            this.Controls.Add(this.btnWisconsin);
            this.Name = "frmStateCapitals";
            this.Text = "State Capitals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWisconsin;
        private System.Windows.Forms.Button btnMinnesota;
        private System.Windows.Forms.Button btnMichigan;
        private System.Windows.Forms.Button btnIllinois;
        private System.Windows.Forms.Button btnCalifornia;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIs;
        private System.Windows.Forms.Label lblThecapitalof;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblState;
    }
}

