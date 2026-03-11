namespace myClinic
{
    partial class Frm_Forget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Forget));
            this.TxtB_phone = new MetroFramework.Controls.MetroTextBox();
            this.Btn_sendPass = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.TxtB_username = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // TxtB_phone
            // 
            this.TxtB_phone.Lines = new string[0];
            this.TxtB_phone.Location = new System.Drawing.Point(23, 79);
            this.TxtB_phone.MaxLength = 32767;
            this.TxtB_phone.Name = "TxtB_phone";
            this.TxtB_phone.PasswordChar = '\0';
            this.TxtB_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_phone.SelectedText = "";
            this.TxtB_phone.Size = new System.Drawing.Size(131, 23);
            this.TxtB_phone.TabIndex = 0;
            this.TxtB_phone.UseSelectable = true;
            this.TxtB_phone.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            // 
            // Btn_sendPass
            // 
            this.Btn_sendPass.Enabled = false;
            this.Btn_sendPass.Location = new System.Drawing.Point(56, 134);
            this.Btn_sendPass.Name = "Btn_sendPass";
            this.Btn_sendPass.Size = new System.Drawing.Size(75, 23);
            this.Btn_sendPass.TabIndex = 1;
            this.Btn_sendPass.Text = "بازگردانی";
            this.Btn_sendPass.UseSelectable = true;
            this.Btn_sendPass.Click += new System.EventHandler(this.Btn_sendPass_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(32, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(171, 79);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(35, 23);
            this.htmlLabel1.TabIndex = 2;
            this.htmlLabel1.Text = "شماره";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(50, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(170, 40);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(61, 23);
            this.htmlLabel2.TabIndex = 4;
            this.htmlLabel2.Text = "کاربری نام";
            // 
            // TxtB_username
            // 
            this.TxtB_username.Lines = new string[0];
            this.TxtB_username.Location = new System.Drawing.Point(23, 40);
            this.TxtB_username.MaxLength = 32767;
            this.TxtB_username.Name = "TxtB_username";
            this.TxtB_username.PasswordChar = '\0';
            this.TxtB_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_username.SelectedText = "";
            this.TxtB_username.Size = new System.Drawing.Size(131, 23);
            this.TxtB_username.TabIndex = 3;
            this.TxtB_username.UseSelectable = true;
            this.TxtB_username.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            // 
            // Frm_Forget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 200);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.TxtB_username);
            this.Controls.Add(this.Btn_sendPass);
            this.Controls.Add(this.TxtB_phone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Forget";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.Frm_Forget_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtB_phone;
        private MetroFramework.Controls.MetroButton Btn_sendPass;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox TxtB_username;
    }
}