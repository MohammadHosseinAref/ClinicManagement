namespace myClinic
{
    partial class Frm_choseBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_choseBackup));
            this.btn_getBackup_patients = new Glass.GlassButton();
            this.glassButton2 = new Glass.GlassButton();
            this.SuspendLayout();
            // 
            // btn_getBackup_patients
            // 
            this.btn_getBackup_patients.Location = new System.Drawing.Point(13, 140);
            this.btn_getBackup_patients.Name = "btn_getBackup_patients";
            this.btn_getBackup_patients.Size = new System.Drawing.Size(272, 23);
            this.btn_getBackup_patients.TabIndex = 0;
            this.btn_getBackup_patients.Text = "بیماران";
            this.btn_getBackup_patients.Click += new System.EventHandler(this.btn_getBackup_patients_Click);
            // 
            // glassButton2
            // 
            this.glassButton2.Location = new System.Drawing.Point(13, 198);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(272, 23);
            this.glassButton2.TabIndex = 1;
            this.glassButton2.Text = "پزشکان";
            // 
            // Frm_choseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.btn_getBackup_patients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_choseBackup";
            this.ResumeLayout(false);

        }

        #endregion

        private Glass.GlassButton btn_getBackup_patients;
        private Glass.GlassButton glassButton2;
    }
}