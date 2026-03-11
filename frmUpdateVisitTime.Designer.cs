namespace myClinic
{
    partial class frmUpdateVisitTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateVisitTime));
            this.comB_doctors_U = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtB_comment_U = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Btn_update_Visit = new MetroFramework.Controls.MetroButton();
            this.TxtB_name_patient_U = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.PersianCalenderUpdate = new BPersianCalender.BPersianCalenderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_upMinute = new System.Windows.Forms.Button();
            this.btn_upHourse = new System.Windows.Forms.Button();
            this.btn_downMinute = new System.Windows.Forms.Button();
            this.btn_downHourse = new System.Windows.Forms.Button();
            this.txtB_time_Minute = new MetroFramework.Controls.MetroTextBox();
            this.txtB_time_Hourse = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // comB_doctors_U
            // 
            this.comB_doctors_U.FormattingEnabled = true;
            this.comB_doctors_U.ItemHeight = 23;
            this.comB_doctors_U.Location = new System.Drawing.Point(23, 77);
            this.comB_doctors_U.Name = "comB_doctors_U";
            this.comB_doctors_U.Size = new System.Drawing.Size(328, 29);
            this.comB_doctors_U.TabIndex = 55;
            this.comB_doctors_U.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(370, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "نام دکتر";
            // 
            // TxtB_comment_U
            // 
            this.TxtB_comment_U.Lines = new string[0];
            this.TxtB_comment_U.Location = new System.Drawing.Point(23, 203);
            this.TxtB_comment_U.MaxLength = 32767;
            this.TxtB_comment_U.Name = "TxtB_comment_U";
            this.TxtB_comment_U.PasswordChar = '\0';
            this.TxtB_comment_U.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_comment_U.SelectedText = "";
            this.TxtB_comment_U.Size = new System.Drawing.Size(328, 23);
            this.TxtB_comment_U.TabIndex = 62;
            this.TxtB_comment_U.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(160, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 63;
            this.metroLabel2.Text = "تاریخ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(374, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 64;
            this.metroLabel3.Text = "ساعت";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(362, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 65;
            this.metroLabel4.Text = "توضیحات";
            // 
            // Btn_update_Visit
            // 
            this.Btn_update_Visit.Location = new System.Drawing.Point(62, 257);
            this.Btn_update_Visit.Name = "Btn_update_Visit";
            this.Btn_update_Visit.Size = new System.Drawing.Size(264, 23);
            this.Btn_update_Visit.TabIndex = 66;
            this.Btn_update_Visit.Text = "ویرایش";
            this.Btn_update_Visit.UseSelectable = true;
            this.Btn_update_Visit.Click += new System.EventHandler(this.Btn_update_Visit_Click);
            // 
            // TxtB_name_patient_U
            // 
            this.TxtB_name_patient_U.Lines = new string[0];
            this.TxtB_name_patient_U.Location = new System.Drawing.Point(23, 31);
            this.TxtB_name_patient_U.MaxLength = 32767;
            this.TxtB_name_patient_U.Name = "TxtB_name_patient_U";
            this.TxtB_name_patient_U.PasswordChar = '\0';
            this.TxtB_name_patient_U.ReadOnly = true;
            this.TxtB_name_patient_U.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_name_patient_U.SelectedText = "";
            this.TxtB_name_patient_U.Size = new System.Drawing.Size(328, 23);
            this.TxtB_name_patient_U.TabIndex = 67;
            this.TxtB_name_patient_U.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(370, 35);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 68;
            this.metroLabel5.Text = "نام بیمار";
            // 
            // PersianCalenderUpdate
            // 
            this.PersianCalenderUpdate.Location = new System.Drawing.Point(23, 129);
            this.PersianCalenderUpdate.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalenderUpdate.Name = "PersianCalenderUpdate";
            this.PersianCalenderUpdate.NowDateSelected = false;
            this.PersianCalenderUpdate.ReadOnly = true;
            this.PersianCalenderUpdate.SelectedDate = null;
            this.PersianCalenderUpdate.Shamsi = null;
            this.PersianCalenderUpdate.Size = new System.Drawing.Size(121, 20);
            this.PersianCalenderUpdate.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = ":";
            // 
            // btn_upMinute
            // 
            this.btn_upMinute.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_upMinute.BackgroundImage = global::myClinic.Properties.Resources.up;
            this.btn_upMinute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_upMinute.Location = new System.Drawing.Point(327, 110);
            this.btn_upMinute.Name = "btn_upMinute";
            this.btn_upMinute.Size = new System.Drawing.Size(23, 23);
            this.btn_upMinute.TabIndex = 79;
            this.btn_upMinute.UseVisualStyleBackColor = false;
            this.btn_upMinute.Click += new System.EventHandler(this.btn_upMinute_Click);
            // 
            // btn_upHourse
            // 
            this.btn_upHourse.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_upHourse.BackgroundImage = global::myClinic.Properties.Resources.up;
            this.btn_upHourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_upHourse.Location = new System.Drawing.Point(285, 110);
            this.btn_upHourse.Name = "btn_upHourse";
            this.btn_upHourse.Size = new System.Drawing.Size(23, 23);
            this.btn_upHourse.TabIndex = 78;
            this.btn_upHourse.UseVisualStyleBackColor = false;
            this.btn_upHourse.Click += new System.EventHandler(this.btn_upHourse_Click);
            // 
            // btn_downMinute
            // 
            this.btn_downMinute.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_downMinute.BackgroundImage = global::myClinic.Properties.Resources.down1;
            this.btn_downMinute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_downMinute.Location = new System.Drawing.Point(327, 168);
            this.btn_downMinute.Name = "btn_downMinute";
            this.btn_downMinute.Size = new System.Drawing.Size(23, 23);
            this.btn_downMinute.TabIndex = 77;
            this.btn_downMinute.UseVisualStyleBackColor = false;
            this.btn_downMinute.Click += new System.EventHandler(this.btn_downMinute_Click);
            // 
            // btn_downHourse
            // 
            this.btn_downHourse.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_downHourse.BackgroundImage = global::myClinic.Properties.Resources.down1;
            this.btn_downHourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_downHourse.Location = new System.Drawing.Point(285, 168);
            this.btn_downHourse.Name = "btn_downHourse";
            this.btn_downHourse.Size = new System.Drawing.Size(23, 23);
            this.btn_downHourse.TabIndex = 76;
            this.btn_downHourse.UseVisualStyleBackColor = false;
            this.btn_downHourse.Click += new System.EventHandler(this.btn_downHourse_Click);
            // 
            // txtB_time_Minute
            // 
            this.txtB_time_Minute.Lines = new string[0];
            this.txtB_time_Minute.Location = new System.Drawing.Point(327, 138);
            this.txtB_time_Minute.MaxLength = 32767;
            this.txtB_time_Minute.Name = "txtB_time_Minute";
            this.txtB_time_Minute.PasswordChar = '\0';
            this.txtB_time_Minute.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB_time_Minute.SelectedText = "";
            this.txtB_time_Minute.Size = new System.Drawing.Size(23, 23);
            this.txtB_time_Minute.TabIndex = 75;
            this.txtB_time_Minute.UseSelectable = true;
            this.txtB_time_Minute.TextChanged += new System.EventHandler(this.txtB_time_Minute_TextChanged);
            this.txtB_time_Minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_time_Minute_KeyPress);
            // 
            // txtB_time_Hourse
            // 
            this.txtB_time_Hourse.Lines = new string[0];
            this.txtB_time_Hourse.Location = new System.Drawing.Point(285, 139);
            this.txtB_time_Hourse.MaxLength = 32767;
            this.txtB_time_Hourse.Name = "txtB_time_Hourse";
            this.txtB_time_Hourse.PasswordChar = '\0';
            this.txtB_time_Hourse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB_time_Hourse.SelectedText = "";
            this.txtB_time_Hourse.Size = new System.Drawing.Size(23, 23);
            this.txtB_time_Hourse.TabIndex = 74;
            this.txtB_time_Hourse.UseSelectable = true;
            this.txtB_time_Hourse.TextChanged += new System.EventHandler(this.txtB_time_Hourse_TextChanged);
            this.txtB_time_Hourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_time_Hourse_KeyPress);
            // 
            // frmUpdateVisitTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_upMinute);
            this.Controls.Add(this.btn_upHourse);
            this.Controls.Add(this.btn_downMinute);
            this.Controls.Add(this.btn_downHourse);
            this.Controls.Add(this.txtB_time_Minute);
            this.Controls.Add(this.txtB_time_Hourse);
            this.Controls.Add(this.PersianCalenderUpdate);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.TxtB_name_patient_U);
            this.Controls.Add(this.Btn_update_Visit);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtB_comment_U);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comB_doctors_U);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateVisitTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmUpdateVisitTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox comB_doctors_U;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtB_comment_U;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton Btn_update_Visit;
        private MetroFramework.Controls.MetroTextBox TxtB_name_patient_U;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private BPersianCalender.BPersianCalenderTextBox PersianCalenderUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_upMinute;
        private System.Windows.Forms.Button btn_upHourse;
        private System.Windows.Forms.Button btn_downMinute;
        private System.Windows.Forms.Button btn_downHourse;
        private MetroFramework.Controls.MetroTextBox txtB_time_Minute;
        private MetroFramework.Controls.MetroTextBox txtB_time_Hourse;
    }
}