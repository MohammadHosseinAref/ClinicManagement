namespace myClinic
{
    partial class Frm_Trial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Trial));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtB_Code = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Login = new MetroFramework.Controls.MetroButton();
            this.btn_Exite = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(284, 107);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(23, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "کد";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // TxtB_Code
            // 
            this.TxtB_Code.Lines = new string[0];
            this.TxtB_Code.Location = new System.Drawing.Point(67, 102);
            this.TxtB_Code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtB_Code.MaxLength = 32767;
            this.TxtB_Code.Name = "TxtB_Code";
            this.TxtB_Code.PasswordChar = '\0';
            this.TxtB_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Code.SelectedText = "";
            this.TxtB_Code.Size = new System.Drawing.Size(209, 28);
            this.TxtB_Code.TabIndex = 3;
            this.TxtB_Code.UseSelectable = true;
            this.TxtB_Code.Click += new System.EventHandler(this.TxtB_Code_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(213, 214);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 31);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "ورود";
            this.Btn_Login.UseSelectable = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // btn_Exite
            // 
            this.btn_Exite.Location = new System.Drawing.Point(67, 214);
            this.btn_Exite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Exite.Name = "btn_Exite";
            this.btn_Exite.Size = new System.Drawing.Size(100, 31);
            this.btn_Exite.TabIndex = 6;
            this.btn_Exite.Text = "خروج";
            this.btn_Exite.UseSelectable = true;
            this.btn_Exite.Click += new System.EventHandler(this.btn_Exite_Click);
            // 
            // Frm_Trial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btn_Exite);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtB_Code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Trial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Trial";
            this.Load += new System.EventHandler(this.Frm_Trial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtB_Code;
        private MetroFramework.Controls.MetroButton Btn_Login;
        private MetroFramework.Controls.MetroButton btn_Exite;
    }
}