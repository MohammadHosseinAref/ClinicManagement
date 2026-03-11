namespace myClinic
{
    partial class Frm_getBackup_patients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_getBackup_patients));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_sent_excel = new System.Windows.Forms.RadioButton();
            this.rb_get_excel = new System.Windows.Forms.RadioButton();
            this.DGV_Patient = new MetroFramework.Controls.MetroGrid();
            this.btn_get_sent_excel = new Glass.GlassButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DGV_sentToExcel = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpatieontBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_myClinicDataSetExportExcel = new myClinic.DB_myClinicDataSetExportExcel();
            this.btn_saveToDb = new Glass.GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_patieontTableAdapter = new myClinic.DB_myClinicDataSetExportExcelTableAdapters.Tbl_patieontTableAdapter();
            this.Progress_save_Excel = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.pic_Back = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_sentToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpatieontBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_myClinicDataSetExportExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_sent_excel);
            this.groupBox1.Controls.Add(this.rb_get_excel);
            this.groupBox1.Location = new System.Drawing.Point(571, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rb_sent_excel
            // 
            this.rb_sent_excel.AutoSize = true;
            this.rb_sent_excel.Location = new System.Drawing.Point(150, 19);
            this.rb_sent_excel.Name = "rb_sent_excel";
            this.rb_sent_excel.Size = new System.Drawing.Size(94, 17);
            this.rb_sent_excel.TabIndex = 2;
            this.rb_sent_excel.Text = "ارسال به اکسل";
            this.rb_sent_excel.UseVisualStyleBackColor = true;
            this.rb_sent_excel.CheckedChanged += new System.EventHandler(this.rb_sent_excel_CheckedChanged);
            // 
            // rb_get_excel
            // 
            this.rb_get_excel.AutoSize = true;
            this.rb_get_excel.Checked = true;
            this.rb_get_excel.Location = new System.Drawing.Point(18, 19);
            this.rb_get_excel.Name = "rb_get_excel";
            this.rb_get_excel.Size = new System.Drawing.Size(97, 17);
            this.rb_get_excel.TabIndex = 1;
            this.rb_get_excel.TabStop = true;
            this.rb_get_excel.Text = "دریافت از اکسل";
            this.rb_get_excel.UseVisualStyleBackColor = true;
            this.rb_get_excel.CheckedChanged += new System.EventHandler(this.rb_get_excel_CheckedChanged);
            // 
            // DGV_Patient
            // 
            this.DGV_Patient.AllowUserToResizeRows = false;
            this.DGV_Patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Patient.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Patient.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Patient.EnableHeadersVisualStyles = false;
            this.DGV_Patient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_Patient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_Patient.Location = new System.Drawing.Point(355, 423);
            this.DGV_Patient.Name = "DGV_Patient";
            this.DGV_Patient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Patient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Patient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Patient.Size = new System.Drawing.Size(698, 137);
            this.DGV_Patient.TabIndex = 7;
            // 
            // btn_get_sent_excel
            // 
            this.btn_get_sent_excel.Location = new System.Drawing.Point(970, 597);
            this.btn_get_sent_excel.Name = "btn_get_sent_excel";
            this.btn_get_sent_excel.Size = new System.Drawing.Size(207, 60);
            this.btn_get_sent_excel.TabIndex = 8;
            this.btn_get_sent_excel.Text = "ذخیره در اکسل";
            this.btn_get_sent_excel.Click += new System.EventHandler(this.btn_get_sent_excel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DGV_sentToExcel
            // 
            this.DGV_sentToExcel.AllowUserToResizeRows = false;
            this.DGV_sentToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_sentToExcel.AutoGenerateColumns = false;
            this.DGV_sentToExcel.BackgroundColor = System.Drawing.Color.White;
            this.DGV_sentToExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_sentToExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_sentToExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_sentToExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_sentToExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_sentToExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.tellDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.nationalCodeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.fileCodeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.DGV_sentToExcel.DataSource = this.tblpatieontBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_sentToExcel.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_sentToExcel.EnableHeadersVisualStyles = false;
            this.DGV_sentToExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_sentToExcel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_sentToExcel.Location = new System.Drawing.Point(234, 250);
            this.DGV_sentToExcel.Name = "DGV_sentToExcel";
            this.DGV_sentToExcel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_sentToExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_sentToExcel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_sentToExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_sentToExcel.Size = new System.Drawing.Size(943, 137);
            this.DGV_sentToExcel.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // tellDataGridViewTextBoxColumn
            // 
            this.tellDataGridViewTextBoxColumn.DataPropertyName = "tell";
            this.tellDataGridViewTextBoxColumn.HeaderText = "tell";
            this.tellDataGridViewTextBoxColumn.Name = "tellDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "NationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "NationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // fileCodeDataGridViewTextBoxColumn
            // 
            this.fileCodeDataGridViewTextBoxColumn.DataPropertyName = "FileCode";
            this.fileCodeDataGridViewTextBoxColumn.HeaderText = "FileCode";
            this.fileCodeDataGridViewTextBoxColumn.Name = "fileCodeDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // tblpatieontBindingSource
            // 
            this.tblpatieontBindingSource.DataMember = "Tbl_patieont";
            this.tblpatieontBindingSource.DataSource = this.dB_myClinicDataSetExportExcel;
            // 
            // dB_myClinicDataSetExportExcel
            // 
            this.dB_myClinicDataSetExportExcel.DataSetName = "DB_myClinicDataSetExportExcel";
            this.dB_myClinicDataSetExportExcel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_saveToDb
            // 
            this.btn_saveToDb.Location = new System.Drawing.Point(234, 597);
            this.btn_saveToDb.Name = "btn_saveToDb";
            this.btn_saveToDb.Size = new System.Drawing.Size(207, 60);
            this.btn_saveToDb.TabIndex = 10;
            this.btn_saveToDb.Text = "ذخیره در دیتابیس";
            this.btn_saveToDb.Click += new System.EventHandler(this.btn_saveToDb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "دریافت از اکسل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ارسال به اکسل";
            // 
            // tbl_patieontTableAdapter
            // 
            this.tbl_patieontTableAdapter.ClearBeforeFill = true;
            // 
            // Progress_save_Excel
            // 
            // 
            // 
            // 
            this.Progress_save_Excel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Progress_save_Excel.Location = new System.Drawing.Point(651, 6);
            this.Progress_save_Excel.Name = "Progress_save_Excel";
            this.Progress_save_Excel.PieBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Progress_save_Excel.PieBorderLight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Progress_save_Excel.ProgressColor = System.Drawing.Color.Black;
            this.Progress_save_Excel.Size = new System.Drawing.Size(121, 88);
            this.Progress_save_Excel.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.Progress_save_Excel.TabIndex = 13;
            // 
            // timerProgress
            // 
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // pic_Back
            // 
            this.pic_Back.BackColor = System.Drawing.Color.Transparent;
            this.pic_Back.BackgroundImage = global::myClinic.Properties.Resources.back_btn;
            this.pic_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Back.Location = new System.Drawing.Point(1, 6);
            this.pic_Back.Name = "pic_Back";
            this.pic_Back.Size = new System.Drawing.Size(19, 36);
            this.pic_Back.TabIndex = 66;
            this.pic_Back.TabStop = false;
            this.pic_Back.Click += new System.EventHandler(this.pic_Back_Click);
            // 
            // Frm_getBackup_patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.pic_Back);
            this.Controls.Add(this.Progress_save_Excel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_saveToDb);
            this.Controls.Add(this.DGV_sentToExcel);
            this.Controls.Add(this.btn_get_sent_excel);
            this.Controls.Add(this.DGV_Patient);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_getBackup_patients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_getBackup_patients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_sentToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpatieontBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_myClinicDataSetExportExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_sent_excel;
        private System.Windows.Forms.RadioButton rb_get_excel;
        private MetroFramework.Controls.MetroGrid DGV_Patient;
        private Glass.GlassButton btn_get_sent_excel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroGrid DGV_sentToExcel;
        private Glass.GlassButton btn_saveToDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DB_myClinicDataSetExportExcel dB_myClinicDataSetExportExcel;
        private System.Windows.Forms.BindingSource tblpatieontBindingSource;
        private DB_myClinicDataSetExportExcelTableAdapters.Tbl_patieontTableAdapter tbl_patieontTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.CircularProgress Progress_save_Excel;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.PictureBox pic_Back;
    }
}