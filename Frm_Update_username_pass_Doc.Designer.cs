namespace myClinic
{
    partial class Frm_Update_username_pass_Doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Update_username_pass_Doc));
            this.TxtB_userName = new MetroFramework.Controls.MetroTextBox();
            this.TxtB_pass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Btn_update = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TxtB_userName
            // 
            this.TxtB_userName.Lines = new string[] {
        " "};
            this.TxtB_userName.Location = new System.Drawing.Point(177, 108);
            this.TxtB_userName.MaxLength = 32767;
            this.TxtB_userName.Name = "TxtB_userName";
            this.TxtB_userName.PasswordChar = '\0';
            this.TxtB_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_userName.SelectedText = "";
            this.TxtB_userName.Size = new System.Drawing.Size(221, 23);
            this.TxtB_userName.TabIndex = 0;
            this.TxtB_userName.Text = " ";
            this.TxtB_userName.UseSelectable = true;
            // 
            // TxtB_pass
            // 
            this.TxtB_pass.Lines = new string[] {
        " "};
            this.TxtB_pass.Location = new System.Drawing.Point(178, 147);
            this.TxtB_pass.MaxLength = 32767;
            this.TxtB_pass.Name = "TxtB_pass";
            this.TxtB_pass.PasswordChar = '\0';
            this.TxtB_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_pass.SelectedText = "";
            this.TxtB_pass.Size = new System.Drawing.Size(221, 23);
            this.TxtB_pass.TabIndex = 1;
            this.TxtB_pass.Text = " ";
            this.TxtB_pass.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(454, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "نام کاربری";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(454, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "رمز عبور";
            // 
            // Btn_update
            // 
            this.Btn_update.Location = new System.Drawing.Point(248, 212);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(75, 23);
            this.Btn_update.TabIndex = 4;
            this.Btn_update.Text = "ویرایش";
            this.Btn_update.UseSelectable = true;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Frm_Update_username_pass_Doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 316);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtB_pass);
            this.Controls.Add(this.TxtB_userName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Update_username_pass_Doc";
            this.Load += new System.EventHandler(this.Frm_Update_username_pass_Doc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtB_userName;
        private MetroFramework.Controls.MetroTextBox TxtB_pass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton Btn_update;
    }
}