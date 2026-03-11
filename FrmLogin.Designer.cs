namespace myClinic
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.ComB_typeLogin = new MetroFramework.Controls.MetroComboBox();
            this.TxtB_Username = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtB_Password = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Login = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Lbl_error = new System.Windows.Forms.Label();
            this.linkLbl_forget = new System.Windows.Forms.LinkLabel();
            this.lbl_lock = new System.Windows.Forms.Label();
            this.btn_regestery = new MetroFramework.Controls.MetroButton();
            this.pic_EyesOpens = new System.Windows.Forms.PictureBox();
            this.pic_EyesCloused = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EyesOpens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EyesCloused)).BeginInit();
            this.SuspendLayout();
            // 
            // ComB_typeLogin
            // 
            this.ComB_typeLogin.FormattingEnabled = true;
            this.ComB_typeLogin.ItemHeight = 23;
            this.ComB_typeLogin.Location = new System.Drawing.Point(61, 74);
            this.ComB_typeLogin.Name = "ComB_typeLogin";
            this.ComB_typeLogin.Size = new System.Drawing.Size(121, 29);
            this.ComB_typeLogin.TabIndex = 6;
            this.ComB_typeLogin.UseSelectable = true;
            // 
            // TxtB_Username
            // 
            this.TxtB_Username.Lines = new string[] {
        "admin"};
            this.TxtB_Username.Location = new System.Drawing.Point(61, 142);
            this.TxtB_Username.MaxLength = 32767;
            this.TxtB_Username.Name = "TxtB_Username";
            this.TxtB_Username.PasswordChar = '\0';
            this.TxtB_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Username.SelectedText = "";
            this.TxtB_Username.Size = new System.Drawing.Size(121, 23);
            this.TxtB_Username.TabIndex = 0;
            this.TxtB_Username.Text = "admin";
            this.TxtB_Username.UseSelectable = true;
            this.TxtB_Username.TextChanged += new System.EventHandler(this.TxtB_Username_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(196, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "نام کاربری";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(196, 191);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "رمز عبور";
            // 
            // TxtB_Password
            // 
            this.TxtB_Password.Lines = new string[] {
        "admin"};
            this.TxtB_Password.Location = new System.Drawing.Point(61, 187);
            this.TxtB_Password.MaxLength = 32767;
            this.TxtB_Password.Name = "TxtB_Password";
            this.TxtB_Password.PasswordChar = '*';
            this.TxtB_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_Password.SelectedText = "";
            this.TxtB_Password.Size = new System.Drawing.Size(121, 23);
            this.TxtB_Password.TabIndex = 1;
            this.TxtB_Password.Text = "admin";
            this.TxtB_Password.UseSelectable = true;
            this.TxtB_Password.TextChanged += new System.EventHandler(this.TxtB_Username_TextChanged);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(84, 233);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 25);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "ورود";
            this.Btn_Login.UseSelectable = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(196, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "سطح دسترسی";
            // 
            // Lbl_error
            // 
            this.Lbl_error.AutoSize = true;
            this.Lbl_error.BackColor = System.Drawing.Color.White;
            this.Lbl_error.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error.ForeColor = System.Drawing.Color.Red;
            this.Lbl_error.Location = new System.Drawing.Point(96, 273);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(44, 15);
            this.Lbl_error.TabIndex = 8;
            this.Lbl_error.Text = "label1";
            this.Lbl_error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_error.Visible = false;
            // 
            // linkLbl_forget
            // 
            this.linkLbl_forget.AutoSize = true;
            this.linkLbl_forget.Location = new System.Drawing.Point(80, 320);
            this.linkLbl_forget.Name = "linkLbl_forget";
            this.linkLbl_forget.Size = new System.Drawing.Size(120, 13);
            this.linkLbl_forget.TabIndex = 9;
            this.linkLbl_forget.TabStop = true;
            this.linkLbl_forget.Text = "رمز عبور را فراموش کردم";
            this.linkLbl_forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_forget_LinkClicked);
            // 
            // lbl_lock
            // 
            this.lbl_lock.AutoSize = true;
            this.lbl_lock.BackColor = System.Drawing.Color.White;
            this.lbl_lock.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lock.ForeColor = System.Drawing.Color.Silver;
            this.lbl_lock.Location = new System.Drawing.Point(10, 28);
            this.lbl_lock.Name = "lbl_lock";
            this.lbl_lock.Size = new System.Drawing.Size(17, 16);
            this.lbl_lock.TabIndex = 12;
            this.lbl_lock.Text = "...";
            this.lbl_lock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_lock.Visible = false;
            // 
            // btn_regestery
            // 
            this.btn_regestery.Location = new System.Drawing.Point(55, 33);
            this.btn_regestery.Name = "btn_regestery";
            this.btn_regestery.Size = new System.Drawing.Size(157, 25);
            this.btn_regestery.TabIndex = 13;
            this.btn_regestery.Text = "وارد کردن کد برنامه";
            this.btn_regestery.UseSelectable = true;
            this.btn_regestery.Visible = false;
            this.btn_regestery.Click += new System.EventHandler(this.btn_regestery_Click);
            // 
            // pic_EyesOpens
            // 
            this.pic_EyesOpens.Image = global::myClinic.Properties.Resources.eyesOpen;
            this.pic_EyesOpens.Location = new System.Drawing.Point(33, 186);
            this.pic_EyesOpens.Name = "pic_EyesOpens";
            this.pic_EyesOpens.Size = new System.Drawing.Size(21, 23);
            this.pic_EyesOpens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_EyesOpens.TabIndex = 11;
            this.pic_EyesOpens.TabStop = false;
            this.pic_EyesOpens.Visible = false;
            // 
            // pic_EyesCloused
            // 
            this.pic_EyesCloused.Image = global::myClinic.Properties.Resources.eyeCloused;
            this.pic_EyesCloused.Location = new System.Drawing.Point(33, 186);
            this.pic_EyesCloused.Name = "pic_EyesCloused";
            this.pic_EyesCloused.Size = new System.Drawing.Size(21, 23);
            this.pic_EyesCloused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_EyesCloused.TabIndex = 10;
            this.pic_EyesCloused.TabStop = false;
            this.pic_EyesCloused.MouseEnter += new System.EventHandler(this.pic_EyesCloused_MouseEnter);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 343);
            this.Controls.Add(this.btn_regestery);
            this.Controls.Add(this.lbl_lock);
            this.Controls.Add(this.pic_EyesOpens);
            this.Controls.Add(this.pic_EyesCloused);
            this.Controls.Add(this.linkLbl_forget);
            this.Controls.Add(this.Lbl_error);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtB_Password);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtB_Username);
            this.Controls.Add(this.ComB_typeLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseEnter += new System.EventHandler(this.FrmLogin_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pic_EyesOpens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EyesCloused)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ComB_typeLogin;
        private MetroFramework.Controls.MetroTextBox TxtB_Username;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtB_Password;
        private MetroFramework.Controls.MetroButton Btn_Login;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label Lbl_error;
        private System.Windows.Forms.LinkLabel linkLbl_forget;
        private System.Windows.Forms.PictureBox pic_EyesCloused;
        private System.Windows.Forms.PictureBox pic_EyesOpens;
        private System.Windows.Forms.Label lbl_lock;
        private MetroFramework.Controls.MetroButton btn_regestery;
    }
}