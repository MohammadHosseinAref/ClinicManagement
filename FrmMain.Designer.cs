namespace myClinic
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.btn_startAgain = new MetroFramework.Controls.MetroButton();
            this.Btn_sent = new MetroFramework.Controls.MetroButton();
            this.btn_chooseBakup = new MetroFramework.Controls.MetroButton();
            this.btn_Report = new MetroFramework.Controls.MetroButton();
            this.Btn_Update_UserName_pass = new MetroFramework.Controls.MetroButton();
            this.Btn_showVisit = new MetroFramework.Controls.MetroButton();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add_pat_visit = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Add = new System.Windows.Forms.FlowLayoutPanel();
            this.picB_Doc = new System.Windows.Forms.PictureBox();
            this.btn_Menue_Add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackgroundImage = global::myClinic.Properties.Resources.exit;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(878, 504);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(138, 141);
            this.btn_exit.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_exit, "خروج");
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_startAgain
            // 
            this.btn_startAgain.BackgroundImage = global::myClinic.Properties.Resources.StartAgain;
            this.btn_startAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_startAgain.Location = new System.Drawing.Point(62, 504);
            this.btn_startAgain.Name = "btn_startAgain";
            this.btn_startAgain.Size = new System.Drawing.Size(138, 141);
            this.btn_startAgain.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn_startAgain, "ورود مجدد");
            this.btn_startAgain.UseSelectable = true;
            this.btn_startAgain.Click += new System.EventHandler(this.btn_startAgain_Click);
            // 
            // Btn_sent
            // 
            this.Btn_sent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_sent.BackgroundImage = global::myClinic.Properties.Resources.sent_icon;
            this.Btn_sent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_sent.Location = new System.Drawing.Point(878, 330);
            this.Btn_sent.Name = "Btn_sent";
            this.Btn_sent.Size = new System.Drawing.Size(138, 141);
            this.Btn_sent.TabIndex = 13;
            this.toolTip1.SetToolTip(this.Btn_sent, "ارسال به بخش ");
            this.Btn_sent.UseSelectable = true;
            this.Btn_sent.Click += new System.EventHandler(this.Btn_sent_Click);
            // 
            // btn_chooseBakup
            // 
            this.btn_chooseBakup.BackgroundImage = global::myClinic.Properties.Resources.Backup;
            this.btn_chooseBakup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chooseBakup.Location = new System.Drawing.Point(62, 330);
            this.btn_chooseBakup.Name = "btn_chooseBakup";
            this.btn_chooseBakup.Size = new System.Drawing.Size(138, 141);
            this.btn_chooseBakup.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn_chooseBakup, "پشتیبان گیری");
            this.btn_chooseBakup.UseSelectable = true;
            this.btn_chooseBakup.Click += new System.EventHandler(this.btn_chooseBakup_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackgroundImage = global::myClinic.Properties.Resources.report;
            this.btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Report.Location = new System.Drawing.Point(914, 99);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(138, 141);
            this.btn_Report.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_Report, "گزارشگیری");
            this.btn_Report.UseSelectable = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // Btn_Update_UserName_pass
            // 
            this.Btn_Update_UserName_pass.BackgroundImage = global::myClinic.Properties.Resources.updat;
            this.Btn_Update_UserName_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Update_UserName_pass.CausesValidation = false;
            this.Btn_Update_UserName_pass.Location = new System.Drawing.Point(549, 99);
            this.Btn_Update_UserName_pass.Name = "Btn_Update_UserName_pass";
            this.Btn_Update_UserName_pass.Size = new System.Drawing.Size(138, 141);
            this.Btn_Update_UserName_pass.TabIndex = 9;
            this.toolTip1.SetToolTip(this.Btn_Update_UserName_pass, "ویرایش");
            this.Btn_Update_UserName_pass.UseSelectable = true;
            this.Btn_Update_UserName_pass.Visible = false;
            this.Btn_Update_UserName_pass.Click += new System.EventHandler(this.Btn_Update_UserName_pass_Click);
            // 
            // Btn_showVisit
            // 
            this.Btn_showVisit.BackgroundImage = global::myClinic.Properties.Resources.showvidit1;
            this.Btn_showVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_showVisit.Location = new System.Drawing.Point(228, 99);
            this.Btn_showVisit.Name = "Btn_showVisit";
            this.Btn_showVisit.Size = new System.Drawing.Size(138, 141);
            this.Btn_showVisit.TabIndex = 8;
            this.toolTip1.SetToolTip(this.Btn_showVisit, "مشاهده لیست نوبت دهی");
            this.Btn_showVisit.UseSelectable = true;
            this.Btn_showVisit.Visible = false;
            this.Btn_showVisit.Click += new System.EventHandler(this.Btn_showVisit_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_about.BackgroundImage")));
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_about.Location = new System.Drawing.Point(704, 99);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(138, 141);
            this.btn_about.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_about, "درباره");
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(393, 99);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(138, 141);
            this.btn_search.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_search, "جستجو");
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add_pat_visit
            // 
            this.btn_add_pat_visit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add_pat_visit.BackgroundImage")));
            this.btn_add_pat_visit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_pat_visit.Location = new System.Drawing.Point(3, 3);
            this.btn_add_pat_visit.Name = "btn_add_pat_visit";
            this.btn_add_pat_visit.Size = new System.Drawing.Size(60, 52);
            this.btn_add_pat_visit.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_add_pat_visit, "اضافه کردن بیمار و وقت");
            this.btn_add_pat_visit.UseVisualStyleBackColor = true;
            this.btn_add_pat_visit.Click += new System.EventHandler(this.btn_add_pat_visit_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setting.BackgroundImage = global::myClinic.Properties.Resources.setting;
            this.btn_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_setting.Location = new System.Drawing.Point(863, 99);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(138, 141);
            this.btn_setting.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_setting, "تنظیمات");
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // flowLayoutPanel_Add
            // 
            this.flowLayoutPanel_Add.Controls.Add(this.btn_add_pat_visit);
            this.flowLayoutPanel_Add.Location = new System.Drawing.Point(85, 240);
            this.flowLayoutPanel_Add.Name = "flowLayoutPanel_Add";
            this.flowLayoutPanel_Add.Size = new System.Drawing.Size(66, 59);
            this.flowLayoutPanel_Add.TabIndex = 5;
            this.flowLayoutPanel_Add.Visible = false;
            // 
            // picB_Doc
            // 
            this.picB_Doc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picB_Doc.Location = new System.Drawing.Point(878, 246);
            this.picB_Doc.Name = "picB_Doc";
            this.picB_Doc.Size = new System.Drawing.Size(138, 141);
            this.picB_Doc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB_Doc.TabIndex = 10;
            this.picB_Doc.TabStop = false;
            this.picB_Doc.MouseEnter += new System.EventHandler(this.picB_Doc_MouseEnter);
            // 
            // btn_Menue_Add
            // 
            this.btn_Menue_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menue_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Menue_Add.BackgroundImage")));
            this.btn_Menue_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Menue_Add.Location = new System.Drawing.Point(62, 99);
            this.btn_Menue_Add.Name = "btn_Menue_Add";
            this.btn_Menue_Add.Size = new System.Drawing.Size(138, 141);
            this.btn_Menue_Add.TabIndex = 2;
            this.btn_Menue_Add.UseVisualStyleBackColor = false;
            this.btn_Menue_Add.MouseEnter += new System.EventHandler(this.btn_Menue_Add_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(204, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 417);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 668);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_startAgain);
            this.Controls.Add(this.Btn_sent);
            this.Controls.Add(this.btn_chooseBakup);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.picB_Doc);
            this.Controls.Add(this.Btn_Update_UserName_pass);
            this.Controls.Add(this.Btn_showVisit);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.flowLayoutPanel_Add);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_Menue_Add);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseEnter += new System.EventHandler(this.FrmMain_MouseEnter);
            this.flowLayoutPanel_Add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Menue_Add;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Add;
        private System.Windows.Forms.Button btn_add_pat_visit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_about;
        private MetroFramework.Controls.MetroButton Btn_showVisit;
        private MetroFramework.Controls.MetroButton Btn_Update_UserName_pass;
        private System.Windows.Forms.PictureBox picB_Doc;
        private MetroFramework.Controls.MetroButton btn_Report;
        private MetroFramework.Controls.MetroButton btn_chooseBakup;
        private MetroFramework.Controls.MetroButton Btn_sent;
        private MetroFramework.Controls.MetroButton btn_startAgain;
        private MetroFramework.Controls.MetroButton btn_exit;
    }
}