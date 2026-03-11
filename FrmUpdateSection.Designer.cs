namespace myClinic
{
    partial class FrmUpdateSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateSection));
            this.Btn_update_sec = new MetroFramework.Controls.MetroButton();
            this.txtB_name_U = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Btn_update_sec
            // 
            this.Btn_update_sec.Location = new System.Drawing.Point(58, 127);
            this.Btn_update_sec.Name = "Btn_update_sec";
            this.Btn_update_sec.Size = new System.Drawing.Size(212, 23);
            this.Btn_update_sec.TabIndex = 39;
            this.Btn_update_sec.Text = "ویرایش";
            this.Btn_update_sec.UseSelectable = true;
            this.Btn_update_sec.Click += new System.EventHandler(this.Btn_update_sec_Click);
            // 
            // txtB_name_U
            // 
            this.txtB_name_U.Lines = new string[0];
            this.txtB_name_U.Location = new System.Drawing.Point(58, 73);
            this.txtB_name_U.MaxLength = 32767;
            this.txtB_name_U.Name = "txtB_name_U";
            this.txtB_name_U.PasswordChar = '\0';
            this.txtB_name_U.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB_name_U.SelectedText = "";
            this.txtB_name_U.Size = new System.Drawing.Size(212, 23);
            this.txtB_name_U.TabIndex = 33;
            this.txtB_name_U.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(290, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(23, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "نام";
            // 
            // FrmUpdateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 202);
            this.Controls.Add(this.Btn_update_sec);
            this.Controls.Add(this.txtB_name_U);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpdateSection";
            this.Load += new System.EventHandler(this.FrmUpdateSection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Btn_update_sec;
        private MetroFramework.Controls.MetroTextBox txtB_name_U;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}