namespace myClinic
{
    partial class Frm_Registery
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
            this.btn_Exite = new MetroFramework.Controls.MetroButton();
            this.Btn_Login = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtB_Code = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btn_Exite
            // 
            this.btn_Exite.Location = new System.Drawing.Point(50, 163);
            this.btn_Exite.Name = "btn_Exite";
            this.btn_Exite.Size = new System.Drawing.Size(75, 25);
            this.btn_Exite.TabIndex = 10;
            this.btn_Exite.Text = "ورود";
            this.btn_Exite.UseSelectable = true;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(160, 163);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 25);
            this.Btn_Login.TabIndex = 9;
            this.Btn_Login.Text = "ورود";
            this.Btn_Login.UseSelectable = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(213, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(22, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "کد";
            // 
            // TxtB_Code
            // 
            this.TxtB_Code.Lines = new string[0];
            this.TxtB_Code.Location = new System.Drawing.Point(50, 72);
            this.TxtB_Code.MaxLength = 32767;
            this.TxtB_Code.Name = "TxtB_Code";
            this.TxtB_Code.PasswordChar = '\0';
            this.TxtB_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Code.SelectedText = "";
            this.TxtB_Code.Size = new System.Drawing.Size(157, 23);
            this.TxtB_Code.TabIndex = 7;
            this.TxtB_Code.UseSelectable = true;
            // 
            // Frm_Registery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Exite);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtB_Code);
            this.Name = "Frm_Registery";
            this.Text = "Frm_Registery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Exite;
        private MetroFramework.Controls.MetroButton Btn_Login;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtB_Code;
    }
}