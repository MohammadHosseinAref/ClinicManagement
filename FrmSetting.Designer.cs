namespace myClinic
{
    partial class FrmSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioB_Doctors = new System.Windows.Forms.RadioButton();
            this.radioB_type = new System.Windows.Forms.RadioButton();
            this.groupB_Regester_doc_sec = new System.Windows.Forms.GroupBox();
            this.groupB_Register_sec = new System.Windows.Forms.GroupBox();
            this.TxtB_name_sec = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Btn_save_sec = new MetroFramework.Controls.MetroButton();
            this.groupB_Register_doc = new System.Windows.Forms.GroupBox();
            this.lbl_error_code = new System.Windows.Forms.Label();
            this.BtnChosePicDoc = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.TxtB_userName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.Btn_save_doc = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ComB_type_doc = new MetroFramework.Controls.MetroComboBox();
            this.TxtB_comment_doc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TxtB_cood_doc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtB_num_doc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtB_name_doc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DGV_sec = new MetroFramework.Controls.MetroGrid();
            this.DGV_doc = new MetroFramework.Controls.MetroGrid();
            this.Btn_delet_Doc = new MetroFramework.Controls.MetroButton();
            this.Btn_delet_sec = new MetroFramework.Controls.MetroButton();
            this.groupB_Update = new System.Windows.Forms.GroupBox();
            this.Btn_update = new MetroFramework.Controls.MetroButton();
            this.TxtB_update = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialogChosePic = new System.Windows.Forms.OpenFileDialog();
            this.pic_Back = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupB_Regester_doc_sec.SuspendLayout();
            this.groupB_Register_sec.SuspendLayout();
            this.groupB_Register_doc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_doc)).BeginInit();
            this.groupB_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioB_Doctors);
            this.groupBox1.Controls.Add(this.radioB_type);
            this.groupBox1.Location = new System.Drawing.Point(536, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioB_Doctors
            // 
            this.radioB_Doctors.AutoSize = true;
            this.radioB_Doctors.Location = new System.Drawing.Point(184, 19);
            this.radioB_Doctors.Name = "radioB_Doctors";
            this.radioB_Doctors.Size = new System.Drawing.Size(65, 17);
            this.radioB_Doctors.TabIndex = 2;
            this.radioB_Doctors.TabStop = true;
            this.radioB_Doctors.Text = "ثبت دکتر";
            this.radioB_Doctors.UseVisualStyleBackColor = true;
            this.radioB_Doctors.CheckedChanged += new System.EventHandler(this.radioB_Doctors_CheckedChanged);
            // 
            // radioB_type
            // 
            this.radioB_type.AutoSize = true;
            this.radioB_type.Location = new System.Drawing.Point(35, 19);
            this.radioB_type.Name = "radioB_type";
            this.radioB_type.Size = new System.Drawing.Size(90, 17);
            this.radioB_type.TabIndex = 1;
            this.radioB_type.TabStop = true;
            this.radioB_type.Text = "ثبت نوع درمان";
            this.radioB_type.UseVisualStyleBackColor = true;
            this.radioB_type.CheckedChanged += new System.EventHandler(this.radioB_type_CheckedChanged);
            // 
            // groupB_Regester_doc_sec
            // 
            this.groupB_Regester_doc_sec.Controls.Add(this.groupB_Register_sec);
            this.groupB_Regester_doc_sec.Controls.Add(this.groupB_Register_doc);
            this.groupB_Regester_doc_sec.Location = new System.Drawing.Point(131, 108);
            this.groupB_Regester_doc_sec.Name = "groupB_Regester_doc_sec";
            this.groupB_Regester_doc_sec.Size = new System.Drawing.Size(1190, 245);
            this.groupB_Regester_doc_sec.TabIndex = 4;
            this.groupB_Regester_doc_sec.TabStop = false;
            this.groupB_Regester_doc_sec.Text = "groupBox2";
            // 
            // groupB_Register_sec
            // 
            this.groupB_Register_sec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupB_Register_sec.Controls.Add(this.TxtB_name_sec);
            this.groupB_Register_sec.Controls.Add(this.metroLabel6);
            this.groupB_Register_sec.Controls.Add(this.Btn_save_sec);
            this.groupB_Register_sec.Location = new System.Drawing.Point(0, 0);
            this.groupB_Register_sec.Name = "groupB_Register_sec";
            this.groupB_Register_sec.Size = new System.Drawing.Size(511, 245);
            this.groupB_Register_sec.TabIndex = 1;
            this.groupB_Register_sec.TabStop = false;
            this.groupB_Register_sec.Text = "ثبت نوع";
            // 
            // TxtB_name_sec
            // 
            this.TxtB_name_sec.Lines = new string[0];
            this.TxtB_name_sec.Location = new System.Drawing.Point(118, 37);
            this.TxtB_name_sec.MaxLength = 32767;
            this.TxtB_name_sec.Name = "TxtB_name_sec";
            this.TxtB_name_sec.PasswordChar = '\0';
            this.TxtB_name_sec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_name_sec.SelectedText = "";
            this.TxtB_name_sec.Size = new System.Drawing.Size(189, 23);
            this.TxtB_name_sec.TabIndex = 2;
            this.TxtB_name_sec.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(352, 41);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(23, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "نام";
            // 
            // Btn_save_sec
            // 
            this.Btn_save_sec.Location = new System.Drawing.Point(146, 188);
            this.Btn_save_sec.Name = "Btn_save_sec";
            this.Btn_save_sec.Size = new System.Drawing.Size(125, 23);
            this.Btn_save_sec.TabIndex = 0;
            this.Btn_save_sec.Text = "ذخیره";
            this.Btn_save_sec.UseSelectable = true;
            this.Btn_save_sec.Click += new System.EventHandler(this.Btn_save_sec_Click);
            // 
            // groupB_Register_doc
            // 
            this.groupB_Register_doc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupB_Register_doc.Controls.Add(this.lbl_error_code);
            this.groupB_Register_doc.Controls.Add(this.BtnChosePicDoc);
            this.groupB_Register_doc.Controls.Add(this.pictureBox1);
            this.groupB_Register_doc.Controls.Add(this.lbl_Error);
            this.groupB_Register_doc.Controls.Add(this.TxtB_userName);
            this.groupB_Register_doc.Controls.Add(this.metroLabel8);
            this.groupB_Register_doc.Controls.Add(this.Btn_save_doc);
            this.groupB_Register_doc.Controls.Add(this.metroLabel5);
            this.groupB_Register_doc.Controls.Add(this.ComB_type_doc);
            this.groupB_Register_doc.Controls.Add(this.TxtB_comment_doc);
            this.groupB_Register_doc.Controls.Add(this.metroLabel4);
            this.groupB_Register_doc.Controls.Add(this.TxtB_cood_doc);
            this.groupB_Register_doc.Controls.Add(this.metroLabel3);
            this.groupB_Register_doc.Controls.Add(this.TxtB_num_doc);
            this.groupB_Register_doc.Controls.Add(this.metroLabel2);
            this.groupB_Register_doc.Controls.Add(this.TxtB_name_doc);
            this.groupB_Register_doc.Controls.Add(this.metroLabel1);
            this.groupB_Register_doc.Enabled = false;
            this.groupB_Register_doc.Location = new System.Drawing.Point(510, 0);
            this.groupB_Register_doc.Name = "groupB_Register_doc";
            this.groupB_Register_doc.Size = new System.Drawing.Size(680, 245);
            this.groupB_Register_doc.TabIndex = 0;
            this.groupB_Register_doc.TabStop = false;
            this.groupB_Register_doc.Text = "ثبت دکتر";
            // 
            // lbl_error_code
            // 
            this.lbl_error_code.AutoSize = true;
            this.lbl_error_code.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_code.Location = new System.Drawing.Point(242, 222);
            this.lbl_error_code.Name = "lbl_error_code";
            this.lbl_error_code.Size = new System.Drawing.Size(178, 13);
            this.lbl_error_code.TabIndex = 16;
            this.lbl_error_code.Text = "نام کاربری تکراریست لطفا تغییر دهید";
            this.lbl_error_code.Visible = false;
            // 
            // BtnChosePicDoc
            // 
            this.BtnChosePicDoc.Location = new System.Drawing.Point(57, 187);
            this.BtnChosePicDoc.Name = "BtnChosePicDoc";
            this.BtnChosePicDoc.Size = new System.Drawing.Size(75, 23);
            this.BtnChosePicDoc.TabIndex = 15;
            this.BtnChosePicDoc.Text = "انتخاب تصویر";
            this.BtnChosePicDoc.UseSelectable = true;
            this.BtnChosePicDoc.Click += new System.EventHandler(this.BtnChosePicDoc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myClinic.Properties.Resources.iconAdd;
            this.pictureBox1.Location = new System.Drawing.Point(18, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(242, 131);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(178, 13);
            this.lbl_Error.TabIndex = 13;
            this.lbl_Error.Text = "نام کاربری تکراریست لطفا تغییر دهید";
            this.lbl_Error.Visible = false;
            // 
            // TxtB_userName
            // 
            this.TxtB_userName.Lines = new string[0];
            this.TxtB_userName.Location = new System.Drawing.Point(426, 127);
            this.TxtB_userName.MaxLength = 32767;
            this.TxtB_userName.Name = "TxtB_userName";
            this.TxtB_userName.PasswordChar = '\0';
            this.TxtB_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_userName.SelectedText = "";
            this.TxtB_userName.Size = new System.Drawing.Size(130, 23);
            this.TxtB_userName.TabIndex = 12;
            this.TxtB_userName.UseSelectable = true;
            this.TxtB_userName.TextChanged += new System.EventHandler(this.TxtB_userName_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(596, 131);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "نام کاربری";
            // 
            // Btn_save_doc
            // 
            this.Btn_save_doc.Enabled = false;
            this.Btn_save_doc.Location = new System.Drawing.Point(344, 188);
            this.Btn_save_doc.Name = "Btn_save_doc";
            this.Btn_save_doc.Size = new System.Drawing.Size(143, 23);
            this.Btn_save_doc.TabIndex = 10;
            this.Btn_save_doc.Text = "ذخیره";
            this.Btn_save_doc.UseSelectable = true;
            this.Btn_save_doc.Click += new System.EventHandler(this.Btn_save_doc_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(344, 89);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "تخصص";
            // 
            // ComB_type_doc
            // 
            this.ComB_type_doc.FormattingEnabled = true;
            this.ComB_type_doc.ItemHeight = 23;
            this.ComB_type_doc.Location = new System.Drawing.Point(205, 83);
            this.ComB_type_doc.Name = "ComB_type_doc";
            this.ComB_type_doc.Size = new System.Drawing.Size(130, 29);
            this.ComB_type_doc.TabIndex = 8;
            this.ComB_type_doc.UseSelectable = true;
            // 
            // TxtB_comment_doc
            // 
            this.TxtB_comment_doc.Lines = new string[0];
            this.TxtB_comment_doc.Location = new System.Drawing.Point(205, 156);
            this.TxtB_comment_doc.MaxLength = 32767;
            this.TxtB_comment_doc.Name = "TxtB_comment_doc";
            this.TxtB_comment_doc.PasswordChar = '\0';
            this.TxtB_comment_doc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_comment_doc.SelectedText = "";
            this.TxtB_comment_doc.Size = new System.Drawing.Size(351, 23);
            this.TxtB_comment_doc.TabIndex = 7;
            this.TxtB_comment_doc.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(596, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "توضیحات";
            // 
            // TxtB_cood_doc
            // 
            this.TxtB_cood_doc.Lines = new string[0];
            this.TxtB_cood_doc.Location = new System.Drawing.Point(426, 89);
            this.TxtB_cood_doc.MaxLength = 32767;
            this.TxtB_cood_doc.Name = "TxtB_cood_doc";
            this.TxtB_cood_doc.PasswordChar = '\0';
            this.TxtB_cood_doc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_cood_doc.SelectedText = "";
            this.TxtB_cood_doc.Size = new System.Drawing.Size(130, 23);
            this.TxtB_cood_doc.TabIndex = 5;
            this.TxtB_cood_doc.UseSelectable = true;
            this.TxtB_cood_doc.TextChanged += new System.EventHandler(this.TxtB_cood_doc_TextChanged);
            this.TxtB_cood_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_cood_doc_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(562, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "کد نظام پزشکی";
            // 
            // TxtB_num_doc
            // 
            this.TxtB_num_doc.Lines = new string[0];
            this.TxtB_num_doc.Location = new System.Drawing.Point(205, 37);
            this.TxtB_num_doc.MaxLength = 32767;
            this.TxtB_num_doc.Name = "TxtB_num_doc";
            this.TxtB_num_doc.PasswordChar = '\0';
            this.TxtB_num_doc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_num_doc.SelectedText = "";
            this.TxtB_num_doc.Size = new System.Drawing.Size(130, 23);
            this.TxtB_num_doc.TabIndex = 3;
            this.TxtB_num_doc.UseSelectable = true;
            this.TxtB_num_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_cood_doc_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(354, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "شماره";
            // 
            // TxtB_name_doc
            // 
            this.TxtB_name_doc.Lines = new string[0];
            this.TxtB_name_doc.Location = new System.Drawing.Point(426, 37);
            this.TxtB_name_doc.MaxLength = 32767;
            this.TxtB_name_doc.Name = "TxtB_name_doc";
            this.TxtB_name_doc.PasswordChar = '\0';
            this.TxtB_name_doc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_name_doc.SelectedText = "";
            this.TxtB_name_doc.Size = new System.Drawing.Size(130, 23);
            this.TxtB_name_doc.TabIndex = 1;
            this.TxtB_name_doc.UseSelectable = true;
            this.TxtB_name_doc.TextChanged += new System.EventHandler(this.TxtB_name_doc_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(632, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(23, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "نام";
            // 
            // DGV_sec
            // 
            this.DGV_sec.AllowUserToResizeRows = false;
            this.DGV_sec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_sec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_sec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_sec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_sec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_sec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_sec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_sec.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_sec.EnableHeadersVisualStyles = false;
            this.DGV_sec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_sec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_sec.Location = new System.Drawing.Point(205, 382);
            this.DGV_sec.Name = "DGV_sec";
            this.DGV_sec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_sec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_sec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_sec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_sec.Size = new System.Drawing.Size(346, 150);
            this.DGV_sec.TabIndex = 5;
            this.DGV_sec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_sec_CellContentClick);
            this.DGV_sec.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_sec_RowEnter);
            // 
            // DGV_doc
            // 
            this.DGV_doc.AllowUserToResizeRows = false;
            this.DGV_doc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_doc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_doc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_doc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_doc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_doc.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_doc.EnableHeadersVisualStyles = false;
            this.DGV_doc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_doc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_doc.Location = new System.Drawing.Point(648, 382);
            this.DGV_doc.Name = "DGV_doc";
            this.DGV_doc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_doc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_doc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_doc.Size = new System.Drawing.Size(548, 162);
            this.DGV_doc.TabIndex = 6;
            this.DGV_doc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_doc_RowEnter);
            // 
            // Btn_delet_Doc
            // 
            this.Btn_delet_Doc.Location = new System.Drawing.Point(843, 561);
            this.Btn_delet_Doc.Name = "Btn_delet_Doc";
            this.Btn_delet_Doc.Size = new System.Drawing.Size(143, 23);
            this.Btn_delet_Doc.TabIndex = 11;
            this.Btn_delet_Doc.Text = "حذف";
            this.Btn_delet_Doc.UseSelectable = true;
            this.Btn_delet_Doc.Click += new System.EventHandler(this.Btn_delet_Doc_Click);
            // 
            // Btn_delet_sec
            // 
            this.Btn_delet_sec.Location = new System.Drawing.Point(367, 538);
            this.Btn_delet_sec.Name = "Btn_delet_sec";
            this.Btn_delet_sec.Size = new System.Drawing.Size(143, 23);
            this.Btn_delet_sec.TabIndex = 12;
            this.Btn_delet_sec.Text = "حذف";
            this.Btn_delet_sec.UseSelectable = true;
            this.Btn_delet_sec.Click += new System.EventHandler(this.Btn_delet_sec_Click);
            // 
            // groupB_Update
            // 
            this.groupB_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupB_Update.Controls.Add(this.Btn_update);
            this.groupB_Update.Controls.Add(this.TxtB_update);
            this.groupB_Update.Controls.Add(this.metroLabel7);
            this.groupB_Update.Location = new System.Drawing.Point(1112, 586);
            this.groupB_Update.Name = "groupB_Update";
            this.groupB_Update.Size = new System.Drawing.Size(235, 83);
            this.groupB_Update.TabIndex = 13;
            this.groupB_Update.TabStop = false;
            this.groupB_Update.Text = "groupBox2";
            // 
            // Btn_update
            // 
            this.Btn_update.Location = new System.Drawing.Point(34, 54);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(134, 23);
            this.Btn_update.TabIndex = 2;
            this.Btn_update.Text = "ویرابش";
            this.Btn_update.UseSelectable = true;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // TxtB_update
            // 
            this.TxtB_update.Lines = new string[0];
            this.TxtB_update.Location = new System.Drawing.Point(34, 20);
            this.TxtB_update.MaxLength = 32767;
            this.TxtB_update.Name = "TxtB_update";
            this.TxtB_update.PasswordChar = '\0';
            this.TxtB_update.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_update.SelectedText = "";
            this.TxtB_update.Size = new System.Drawing.Size(134, 23);
            this.TxtB_update.TabIndex = 1;
            this.TxtB_update.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(186, 20);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(23, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "نام";
            // 
            // openFileDialogChosePic
            // 
            this.openFileDialogChosePic.FileName = "openFileDialog1";
            // 
            // pic_Back
            // 
            this.pic_Back.BackColor = System.Drawing.Color.Transparent;
            this.pic_Back.BackgroundImage = global::myClinic.Properties.Resources.back_btn;
            this.pic_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Back.Location = new System.Drawing.Point(0, 6);
            this.pic_Back.Name = "pic_Back";
            this.pic_Back.Size = new System.Drawing.Size(19, 36);
            this.pic_Back.TabIndex = 14;
            this.pic_Back.TabStop = false;
            this.pic_Back.Click += new System.EventHandler(this.pic_Back_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.pic_Back);
            this.Controls.Add(this.groupB_Update);
            this.Controls.Add(this.Btn_delet_sec);
            this.Controls.Add(this.Btn_delet_Doc);
            this.Controls.Add(this.DGV_doc);
            this.Controls.Add(this.DGV_sec);
            this.Controls.Add(this.groupB_Regester_doc_sec);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupB_Regester_doc_sec.ResumeLayout(false);
            this.groupB_Register_sec.ResumeLayout(false);
            this.groupB_Register_sec.PerformLayout();
            this.groupB_Register_doc.ResumeLayout(false);
            this.groupB_Register_doc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_doc)).EndInit();
            this.groupB_Update.ResumeLayout(false);
            this.groupB_Update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioB_Doctors;
        private System.Windows.Forms.RadioButton radioB_type;
        private System.Windows.Forms.GroupBox groupB_Regester_doc_sec;
        private System.Windows.Forms.GroupBox groupB_Register_sec;
        private System.Windows.Forms.GroupBox groupB_Register_doc;
        private MetroFramework.Controls.MetroTextBox TxtB_comment_doc;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtB_cood_doc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtB_num_doc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtB_name_doc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox ComB_type_doc;
        private MetroFramework.Controls.MetroTextBox TxtB_name_sec;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton Btn_save_sec;
        private MetroFramework.Controls.MetroButton Btn_save_doc;
        private MetroFramework.Controls.MetroGrid DGV_sec;
        private MetroFramework.Controls.MetroGrid DGV_doc;
        private MetroFramework.Controls.MetroButton Btn_delet_Doc;
        private MetroFramework.Controls.MetroButton Btn_delet_sec;
        private System.Windows.Forms.GroupBox groupB_Update;
        private MetroFramework.Controls.MetroButton Btn_update;
        private MetroFramework.Controls.MetroTextBox TxtB_update;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox TxtB_userName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Label lbl_Error;
        private MetroFramework.Controls.MetroButton BtnChosePicDoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialogChosePic;
        private System.Windows.Forms.PictureBox pic_Back;
        private System.Windows.Forms.Label lbl_error_code;

    }
}