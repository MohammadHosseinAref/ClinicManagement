namespace myClinic
{
    partial class Frm_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Search));
            this.groupB_type_search = new System.Windows.Forms.GroupBox();
            this.RadioB_Search_Type = new MetroFramework.Controls.MetroRadioButton();
            this.RadioB_Search_Doc = new MetroFramework.Controls.MetroRadioButton();
            this.RadioB_Search_Visit = new MetroFramework.Controls.MetroRadioButton();
            this.RadioB_Search_pat = new MetroFramework.Controls.MetroRadioButton();
            this.groupB_search = new System.Windows.Forms.GroupBox();
            this.btn_refresh_grid = new MetroFramework.Controls.MetroButton();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.TxtB_name = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_name = new MetroFramework.Controls.MetroLabel();
            this.DGV_show_Data = new MetroFramework.Controls.MetroGrid();
            this.groupB_type_search.SuspendLayout();
            this.groupB_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_show_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupB_type_search
            // 
            this.groupB_type_search.Controls.Add(this.RadioB_Search_Type);
            this.groupB_type_search.Controls.Add(this.RadioB_Search_Doc);
            this.groupB_type_search.Controls.Add(this.RadioB_Search_Visit);
            this.groupB_type_search.Controls.Add(this.RadioB_Search_pat);
            this.groupB_type_search.Location = new System.Drawing.Point(242, 51);
            this.groupB_type_search.Name = "groupB_type_search";
            this.groupB_type_search.Size = new System.Drawing.Size(309, 96);
            this.groupB_type_search.TabIndex = 0;
            this.groupB_type_search.TabStop = false;
            // 
            // RadioB_Search_Type
            // 
            this.RadioB_Search_Type.AutoSize = true;
            this.RadioB_Search_Type.Location = new System.Drawing.Point(16, 19);
            this.RadioB_Search_Type.Name = "RadioB_Search_Type";
            this.RadioB_Search_Type.Size = new System.Drawing.Size(142, 15);
            this.RadioB_Search_Type.TabIndex = 3;
            this.RadioB_Search_Type.Text = "جستجوی امکانات کلینیک";
            this.RadioB_Search_Type.UseSelectable = true;
            // 
            // RadioB_Search_Doc
            // 
            this.RadioB_Search_Doc.AutoSize = true;
            this.RadioB_Search_Doc.Location = new System.Drawing.Point(176, 53);
            this.RadioB_Search_Doc.Name = "RadioB_Search_Doc";
            this.RadioB_Search_Doc.Size = new System.Drawing.Size(89, 15);
            this.RadioB_Search_Doc.TabIndex = 2;
            this.RadioB_Search_Doc.Text = "جستجو پزشک";
            this.RadioB_Search_Doc.UseSelectable = true;
            // 
            // RadioB_Search_Visit
            // 
            this.RadioB_Search_Visit.AutoSize = true;
            this.RadioB_Search_Visit.Location = new System.Drawing.Point(176, 19);
            this.RadioB_Search_Visit.Name = "RadioB_Search_Visit";
            this.RadioB_Search_Visit.Size = new System.Drawing.Size(127, 15);
            this.RadioB_Search_Visit.TabIndex = 1;
            this.RadioB_Search_Visit.Text = "جستجوی وقت ویزیت";
            this.RadioB_Search_Visit.UseSelectable = true;
            // 
            // RadioB_Search_pat
            // 
            this.RadioB_Search_pat.AutoSize = true;
            this.RadioB_Search_pat.Location = new System.Drawing.Point(16, 53);
            this.RadioB_Search_pat.Name = "RadioB_Search_pat";
            this.RadioB_Search_pat.Size = new System.Drawing.Size(92, 15);
            this.RadioB_Search_pat.TabIndex = 0;
            this.RadioB_Search_pat.Text = "جستجوی بیمار";
            this.RadioB_Search_pat.UseSelectable = true;
            // 
            // groupB_search
            // 
            this.groupB_search.Controls.Add(this.btn_refresh_grid);
            this.groupB_search.Controls.Add(this.btn_search);
            this.groupB_search.Controls.Add(this.TxtB_name);
            this.groupB_search.Controls.Add(this.Lbl_name);
            this.groupB_search.Location = new System.Drawing.Point(242, 162);
            this.groupB_search.Name = "groupB_search";
            this.groupB_search.Size = new System.Drawing.Size(309, 105);
            this.groupB_search.TabIndex = 1;
            this.groupB_search.TabStop = false;
            // 
            // btn_refresh_grid
            // 
            this.btn_refresh_grid.Location = new System.Drawing.Point(16, 76);
            this.btn_refresh_grid.Name = "btn_refresh_grid";
            this.btn_refresh_grid.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh_grid.TabIndex = 3;
            this.btn_refresh_grid.Text = "لغو";
            this.btn_refresh_grid.UseSelectable = true;
            this.btn_refresh_grid.Click += new System.EventHandler(this.btn_refresh_grid_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(115, 76);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "جستجو";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // TxtB_name
            // 
            this.TxtB_name.Icon = global::myClinic.Properties.Resources.search_p;
            this.TxtB_name.Lines = new string[0];
            this.TxtB_name.Location = new System.Drawing.Point(29, 30);
            this.TxtB_name.MaxLength = 32767;
            this.TxtB_name.Name = "TxtB_name";
            this.TxtB_name.PasswordChar = '\0';
            this.TxtB_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtB_name.SelectedText = "";
            this.TxtB_name.Size = new System.Drawing.Size(207, 23);
            this.TxtB_name.TabIndex = 1;
            this.TxtB_name.UseSelectable = true;
            // 
            // Lbl_name
            // 
            this.Lbl_name.AutoSize = true;
            this.Lbl_name.Location = new System.Drawing.Point(253, 30);
            this.Lbl_name.Name = "Lbl_name";
            this.Lbl_name.Size = new System.Drawing.Size(23, 19);
            this.Lbl_name.TabIndex = 0;
            this.Lbl_name.Text = "نام";
            // 
            // DGV_show_Data
            // 
            this.DGV_show_Data.AllowUserToResizeRows = false;
            this.DGV_show_Data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_show_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_show_Data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_show_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_show_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_show_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_show_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_show_Data.EnableHeadersVisualStyles = false;
            this.DGV_show_Data.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_show_Data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_show_Data.Location = new System.Drawing.Point(23, 273);
            this.DGV_show_Data.Name = "DGV_show_Data";
            this.DGV_show_Data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_show_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_show_Data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_show_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_show_Data.Size = new System.Drawing.Size(737, 150);
            this.DGV_show_Data.TabIndex = 2;
            // 
            // Frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 455);
            this.Controls.Add(this.DGV_show_Data);
            this.Controls.Add(this.groupB_search);
            this.Controls.Add(this.groupB_type_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Search";
            this.Opacity = 0.98D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Frm_Search_Load);
            this.groupB_type_search.ResumeLayout(false);
            this.groupB_type_search.PerformLayout();
            this.groupB_search.ResumeLayout(false);
            this.groupB_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_show_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupB_type_search;
        private MetroFramework.Controls.MetroRadioButton RadioB_Search_Type;
        private MetroFramework.Controls.MetroRadioButton RadioB_Search_Doc;
        private MetroFramework.Controls.MetroRadioButton RadioB_Search_Visit;
        private MetroFramework.Controls.MetroRadioButton RadioB_Search_pat;
        private System.Windows.Forms.GroupBox groupB_search;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroTextBox TxtB_name;
        private MetroFramework.Controls.MetroLabel Lbl_name;
        private MetroFramework.Controls.MetroGrid DGV_show_Data;
        private MetroFramework.Controls.MetroButton btn_refresh_grid;
    }
}