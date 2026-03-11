namespace myClinic
{
    partial class FrmUpdateDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateDoc));
            this.Btn_update_doc = new MetroFramework.Controls.MetroButton();
            this.txtB_comment_U = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtB_cood_U = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtB_tell_U = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtB_name_U = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ComB_type = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.picB_update = new System.Windows.Forms.PictureBox();
            this.Btn_Update_pic = new MetroFramework.Controls.MetroButton();
            this.openFileDialogUpdate = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picB_update)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_update_doc
            // 
            this.Btn_update_doc.Location = new System.Drawing.Point(202, 255);
            this.Btn_update_doc.Name = "Btn_update_doc";
            this.Btn_update_doc.Size = new System.Drawing.Size(264, 23);
            this.Btn_update_doc.TabIndex = 29;
            this.Btn_update_doc.Text = "ویرایش";
            this.Btn_update_doc.UseSelectable = true;
            this.Btn_update_doc.Click += new System.EventHandler(this.Btn_update_doc_Click);
            // 
            // txtB_comment_U
            // 
            this.txtB_comment_U.Lines = new string[0];
            this.txtB_comment_U.Location = new System.Drawing.Point(160, 176);
            this.txtB_comment_U.MaxLength = 32767;
            this.txtB_comment_U.Name = "txtB_comment_U";
            this.txtB_comment_U.PasswordChar = '\0';
            this.txtB_comment_U.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB_comment_U.SelectedText = "";
            this.txtB_comment_U.Size = new System.Drawing.Size(339, 23);
            this.txtB_comment_U.TabIndex = 28;
            this.txtB_comment_U.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(539, 180);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "توضیحات";
            // 
            // txtB_cood_U
            // 
            this.txtB_cood_U.Lines = new string[0];
            this.txtB_cood_U.Location = new System.Drawing.Point(388, 110);
            this.txtB_cood_U.MaxLength = 32767;
            this.txtB_cood_U.Name = "txtB_cood_U";
            this.txtB_cood_U.PasswordChar = '\0';
            this.txtB_cood_U.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB_cood_U.SelectedText = "";
            this.txtB_cood_U.Size = new System.Drawing.Size(111, 23);
            this.txtB_cood_U.TabIndex = 24;
            this.txtB_cood_U.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(505, 110);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "کد نظام پزشکی";
            // 
            // txtB_tell_U
            // 
            this.txtB_tell_U.Lines = new string[0];
            this.txtB_tell_U.Location = new System.Drawing.Point(160, 46);
            this.txtB_tell_U.MaxLength = 32767;
            this.txtB_tell_U.Name = "txtB_tell_U";
            this.txtB_tell_U.PasswordChar = '\0';
            this.txtB_tell_U.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB_tell_U.SelectedText = "";
            this.txtB_tell_U.Size = new System.Drawing.Size(111, 23);
            this.txtB_tell_U.TabIndex = 18;
            this.txtB_tell_U.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(277, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "شماره همراه";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtB_name_U
            // 
            this.txtB_name_U.Lines = new string[0];
            this.txtB_name_U.Location = new System.Drawing.Point(388, 46);
            this.txtB_name_U.MaxLength = 32767;
            this.txtB_name_U.Name = "txtB_name_U";
            this.txtB_name_U.PasswordChar = '\0';
            this.txtB_name_U.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB_name_U.SelectedText = "";
            this.txtB_name_U.Size = new System.Drawing.Size(111, 23);
            this.txtB_name_U.TabIndex = 16;
            this.txtB_name_U.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(547, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "نام بیمار";
            // 
            // ComB_type
            // 
            this.ComB_type.FormattingEnabled = true;
            this.ComB_type.ItemHeight = 23;
            this.ComB_type.Location = new System.Drawing.Point(160, 110);
            this.ComB_type.Name = "ComB_type";
            this.ComB_type.Size = new System.Drawing.Size(111, 29);
            this.ComB_type.TabIndex = 30;
            this.ComB_type.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(301, 114);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "تخصص";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picB_update
            // 
            this.picB_update.Location = new System.Drawing.Point(22, 89);
            this.picB_update.Name = "picB_update";
            this.picB_update.Size = new System.Drawing.Size(132, 110);
            this.picB_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB_update.TabIndex = 32;
            this.picB_update.TabStop = false;
            // 
            // Btn_Update_pic
            // 
            this.Btn_Update_pic.Location = new System.Drawing.Point(38, 206);
            this.Btn_Update_pic.Name = "Btn_Update_pic";
            this.Btn_Update_pic.Size = new System.Drawing.Size(87, 23);
            this.Btn_Update_pic.TabIndex = 33;
            this.Btn_Update_pic.Text = "انتخاب تصویر";
            this.Btn_Update_pic.UseSelectable = true;
            this.Btn_Update_pic.Click += new System.EventHandler(this.Btn_Update_pic_Click);
            // 
            // openFileDialogUpdate
            // 
            this.openFileDialogUpdate.FileName = "openFileDialog1";
            // 
            // FrmUpdateDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 348);
            this.Controls.Add(this.Btn_Update_pic);
            this.Controls.Add(this.picB_update);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ComB_type);
            this.Controls.Add(this.Btn_update_doc);
            this.Controls.Add(this.txtB_comment_U);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtB_cood_U);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtB_tell_U);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtB_name_U);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpdateDoc";
            this.Load += new System.EventHandler(this.FrmUpdateDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Btn_update_doc;
        private MetroFramework.Controls.MetroTextBox txtB_comment_U;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtB_cood_U;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtB_tell_U;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtB_name_U;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ComB_type;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox picB_update;
        private MetroFramework.Controls.MetroButton Btn_Update_pic;
        private System.Windows.Forms.OpenFileDialog openFileDialogUpdate;
    }
}