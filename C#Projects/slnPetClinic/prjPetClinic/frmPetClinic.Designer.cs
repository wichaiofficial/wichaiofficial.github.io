
namespace prjPetClinic
{
    partial class frmPetClinic
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblPrice3 = new System.Windows.Forms.Label();
            this.lblPrice4 = new System.Windows.Forms.Label();
            this.chkVaccination = new System.Windows.Forms.CheckBox();
            this.chkMicro = new System.Windows.Forms.CheckBox();
            this.chkSurgical = new System.Windows.Forms.CheckBox();
            this.chkDiagnostics = new System.Windows.Forms.CheckBox();
            this.chkWellness = new System.Windows.Forms.CheckBox();
            this.chkNutrition = new System.Windows.Forms.CheckBox();
            this.chkDental = new System.Windows.Forms.CheckBox();
            this.chkBehavioral = new System.Windows.Forms.CheckBox();
            this.lblPrice8 = new System.Windows.Forms.Label();
            this.lblPrice7 = new System.Windows.Forms.Label();
            this.lblPrice6 = new System.Windows.Forms.Label();
            this.lblPrice5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(38, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(154, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Select Pet Services :";
            // 
            // lblPrice1
            // 
            this.lblPrice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice1.Location = new System.Drawing.Point(192, 70);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(36, 13);
            this.lblPrice1.TabIndex = 2;
            this.lblPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice2
            // 
            this.lblPrice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice2.Location = new System.Drawing.Point(192, 102);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(36, 13);
            this.lblPrice2.TabIndex = 4;
            this.lblPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice3
            // 
            this.lblPrice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice3.Location = new System.Drawing.Point(192, 134);
            this.lblPrice3.Name = "lblPrice3";
            this.lblPrice3.Size = new System.Drawing.Size(36, 13);
            this.lblPrice3.TabIndex = 6;
            this.lblPrice3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice4
            // 
            this.lblPrice4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice4.Location = new System.Drawing.Point(192, 166);
            this.lblPrice4.Name = "lblPrice4";
            this.lblPrice4.Size = new System.Drawing.Size(36, 13);
            this.lblPrice4.TabIndex = 8;
            this.lblPrice4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkVaccination
            // 
            this.chkVaccination.AutoSize = true;
            this.chkVaccination.Location = new System.Drawing.Point(42, 69);
            this.chkVaccination.Name = "chkVaccination";
            this.chkVaccination.Size = new System.Drawing.Size(87, 17);
            this.chkVaccination.TabIndex = 1;
            this.chkVaccination.Text = "Vaccinations";
            this.chkVaccination.UseVisualStyleBackColor = true;
            this.chkVaccination.CheckedChanged += new System.EventHandler(this.chkVaccination_CheckedChanged);
            // 
            // chkMicro
            // 
            this.chkMicro.AutoSize = true;
            this.chkMicro.Location = new System.Drawing.Point(42, 101);
            this.chkMicro.Name = "chkMicro";
            this.chkMicro.Size = new System.Drawing.Size(92, 17);
            this.chkMicro.TabIndex = 3;
            this.chkMicro.Text = "Microchipping";
            this.chkMicro.UseVisualStyleBackColor = true;
            this.chkMicro.CheckedChanged += new System.EventHandler(this.chkMicro_CheckedChanged);
            // 
            // chkSurgical
            // 
            this.chkSurgical.AutoSize = true;
            this.chkSurgical.Location = new System.Drawing.Point(42, 133);
            this.chkSurgical.Name = "chkSurgical";
            this.chkSurgical.Size = new System.Drawing.Size(108, 17);
            this.chkSurgical.TabIndex = 5;
            this.chkSurgical.Text = "Surgical Services";
            this.chkSurgical.UseVisualStyleBackColor = true;
            this.chkSurgical.CheckedChanged += new System.EventHandler(this.chkSurgical_CheckedChanged);
            // 
            // chkDiagnostics
            // 
            this.chkDiagnostics.AutoSize = true;
            this.chkDiagnostics.Location = new System.Drawing.Point(42, 165);
            this.chkDiagnostics.Name = "chkDiagnostics";
            this.chkDiagnostics.Size = new System.Drawing.Size(133, 17);
            this.chkDiagnostics.TabIndex = 7;
            this.chkDiagnostics.Text = "Advanced Diagnostics";
            this.chkDiagnostics.UseVisualStyleBackColor = true;
            this.chkDiagnostics.CheckedChanged += new System.EventHandler(this.chkDiagnostics_CheckedChanged);
            // 
            // chkWellness
            // 
            this.chkWellness.AutoSize = true;
            this.chkWellness.Location = new System.Drawing.Point(302, 165);
            this.chkWellness.Name = "chkWellness";
            this.chkWellness.Size = new System.Drawing.Size(69, 17);
            this.chkWellness.TabIndex = 15;
            this.chkWellness.Text = "Wellness";
            this.chkWellness.UseVisualStyleBackColor = true;
            this.chkWellness.CheckedChanged += new System.EventHandler(this.chkWellness_CheckedChanged);
            // 
            // chkNutrition
            // 
            this.chkNutrition.AutoSize = true;
            this.chkNutrition.Location = new System.Drawing.Point(302, 133);
            this.chkNutrition.Name = "chkNutrition";
            this.chkNutrition.Size = new System.Drawing.Size(128, 17);
            this.chkNutrition.TabIndex = 13;
            this.chkNutrition.Text = "Nutritional Counseling";
            this.chkNutrition.UseVisualStyleBackColor = true;
            this.chkNutrition.CheckedChanged += new System.EventHandler(this.chkNutrition_CheckedChanged);
            // 
            // chkDental
            // 
            this.chkDental.AutoSize = true;
            this.chkDental.Location = new System.Drawing.Point(302, 101);
            this.chkDental.Name = "chkDental";
            this.chkDental.Size = new System.Drawing.Size(82, 17);
            this.chkDental.TabIndex = 11;
            this.chkDental.Text = "Dental Care";
            this.chkDental.UseVisualStyleBackColor = true;
            this.chkDental.CheckedChanged += new System.EventHandler(this.chkDental_CheckedChanged);
            // 
            // chkBehavioral
            // 
            this.chkBehavioral.AutoSize = true;
            this.chkBehavioral.Location = new System.Drawing.Point(302, 69);
            this.chkBehavioral.Name = "chkBehavioral";
            this.chkBehavioral.Size = new System.Drawing.Size(142, 17);
            this.chkBehavioral.TabIndex = 9;
            this.chkBehavioral.Text = "Behavioral Consultations";
            this.chkBehavioral.UseVisualStyleBackColor = true;
            this.chkBehavioral.CheckedChanged += new System.EventHandler(this.chkBehvioral_CheckedChanged);
            // 
            // lblPrice8
            // 
            this.lblPrice8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice8.Location = new System.Drawing.Point(460, 166);
            this.lblPrice8.Name = "lblPrice8";
            this.lblPrice8.Size = new System.Drawing.Size(36, 13);
            this.lblPrice8.TabIndex = 16;
            this.lblPrice8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice7
            // 
            this.lblPrice7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice7.Location = new System.Drawing.Point(460, 134);
            this.lblPrice7.Name = "lblPrice7";
            this.lblPrice7.Size = new System.Drawing.Size(36, 13);
            this.lblPrice7.TabIndex = 14;
            this.lblPrice7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice6
            // 
            this.lblPrice6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice6.Location = new System.Drawing.Point(460, 102);
            this.lblPrice6.Name = "lblPrice6";
            this.lblPrice6.Size = new System.Drawing.Size(36, 13);
            this.lblPrice6.TabIndex = 12;
            this.lblPrice6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice5
            // 
            this.lblPrice5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice5.Location = new System.Drawing.Point(460, 70);
            this.lblPrice5.Name = "lblPrice5";
            this.lblPrice5.Size = new System.Drawing.Size(36, 13);
            this.lblPrice5.TabIndex = 10;
            this.lblPrice5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(75, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(192, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Cost :";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(145, 239);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblDisplay.TabIndex = 18;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPetClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(530, 335);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkWellness);
            this.Controls.Add(this.chkNutrition);
            this.Controls.Add(this.chkDental);
            this.Controls.Add(this.chkBehavioral);
            this.Controls.Add(this.lblPrice8);
            this.Controls.Add(this.lblPrice7);
            this.Controls.Add(this.lblPrice6);
            this.Controls.Add(this.lblPrice5);
            this.Controls.Add(this.chkDiagnostics);
            this.Controls.Add(this.chkSurgical);
            this.Controls.Add(this.chkMicro);
            this.Controls.Add(this.chkVaccination);
            this.Controls.Add(this.lblPrice4);
            this.Controls.Add(this.lblPrice3);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmPetClinic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Clinic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblPrice3;
        private System.Windows.Forms.Label lblPrice4;
        private System.Windows.Forms.CheckBox chkVaccination;
        private System.Windows.Forms.CheckBox chkMicro;
        private System.Windows.Forms.CheckBox chkSurgical;
        private System.Windows.Forms.CheckBox chkDiagnostics;
        private System.Windows.Forms.CheckBox chkWellness;
        private System.Windows.Forms.CheckBox chkNutrition;
        private System.Windows.Forms.CheckBox chkDental;
        private System.Windows.Forms.CheckBox chkBehavioral;
        private System.Windows.Forms.Label lblPrice8;
        private System.Windows.Forms.Label lblPrice7;
        private System.Windows.Forms.Label lblPrice6;
        private System.Windows.Forms.Label lblPrice5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDisplay;
    }
}

