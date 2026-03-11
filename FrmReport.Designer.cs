namespace myClinic
{
    partial class FrmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportVisitTime = new myClinic.DataSetReportVisitTime();
            this.Tbl_patieontBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportPatieont = new myClinic.DataSetReportPatieont();
            this.Tbl_DoctoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportDoctors = new myClinic.DataSetReportDoctors();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_reportDoc = new MetroFramework.Controls.MetroButton();
            this.com_Doc = new MetroFramework.Controls.MetroComboBox();
            this.DataTable1TableAdapter = new myClinic.DataSetReportVisitTimeTableAdapters.DataTable1TableAdapter();
            this.Tbl_patieontTableAdapter = new myClinic.DataSetReportPatieontTableAdapters.Tbl_patieontTableAdapter();
            this.Tbl_DoctoreTableAdapter = new myClinic.DataSetReportDoctorsTableAdapters.Tbl_DoctoreTableAdapter();
            this.pic_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportVisitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_patieontBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportPatieont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_DoctoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportDoctors)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetReportVisitTime;
            // 
            // DataSetReportVisitTime
            // 
            this.DataSetReportVisitTime.DataSetName = "DataSetReportVisitTime";
            this.DataSetReportVisitTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_patieontBindingSource
            // 
            this.Tbl_patieontBindingSource.DataMember = "Tbl_patieont";
            this.Tbl_patieontBindingSource.DataSource = this.DataSetReportPatieont;
            // 
            // DataSetReportPatieont
            // 
            this.DataSetReportPatieont.DataSetName = "DataSetReportPatieont";
            this.DataSetReportPatieont.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_DoctoreBindingSource
            // 
            this.Tbl_DoctoreBindingSource.DataMember = "Tbl_Doctore";
            this.Tbl_DoctoreBindingSource.DataSource = this.DataSetReportDoctors;
            // 
            // DataSetReportDoctors
            // 
            this.DataSetReportDoctors.DataSetName = "DataSetReportDoctors";
            this.DataSetReportDoctors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(38, 31);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1264, 55);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(38, 92);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1272, 604);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "گزارش ویزیت ها";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "myClinic.ReportVisitTime.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1258, 565);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Font = new System.Drawing.Font("Snap ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "گزارش بیماران";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Tbl_patieontBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "myClinic.ReportPatieont.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1258, 565);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1264, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "گزارش پزشکان";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Tbl_DoctoreBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "myClinic.ReportDoctors.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1258, 565);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Controls.Add(this.btn_reportDoc);
            this.tabPage4.Controls.Add(this.com_Doc);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1264, 578);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "گزارش پزشک";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Location = new System.Drawing.Point(18, 35);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(1243, 537);
            this.reportViewer4.TabIndex = 2;
            this.reportViewer4.Visible = false;
            // 
            // btn_reportDoc
            // 
            this.btn_reportDoc.Location = new System.Drawing.Point(1059, 6);
            this.btn_reportDoc.Name = "btn_reportDoc";
            this.btn_reportDoc.Size = new System.Drawing.Size(75, 23);
            this.btn_reportDoc.TabIndex = 1;
            this.btn_reportDoc.Text = "دریافت";
            this.btn_reportDoc.UseSelectable = true;
            this.btn_reportDoc.Click += new System.EventHandler(this.btn_reportDoc_Click);
            // 
            // com_Doc
            // 
            this.com_Doc.FormattingEnabled = true;
            this.com_Doc.ItemHeight = 23;
            this.com_Doc.Location = new System.Drawing.Point(1139, 3);
            this.com_Doc.Name = "com_Doc";
            this.com_Doc.Size = new System.Drawing.Size(121, 29);
            this.com_Doc.TabIndex = 0;
            this.com_Doc.UseSelectable = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Tbl_patieontTableAdapter
            // 
            this.Tbl_patieontTableAdapter.ClearBeforeFill = true;
            // 
            // Tbl_DoctoreTableAdapter
            // 
            this.Tbl_DoctoreTableAdapter.ClearBeforeFill = true;
            // 
            // pic_Back
            // 
            this.pic_Back.BackColor = System.Drawing.Color.Transparent;
            this.pic_Back.BackgroundImage = global::myClinic.Properties.Resources.back_btn;
            this.pic_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Back.Location = new System.Drawing.Point(0, 5);
            this.pic_Back.Name = "pic_Back";
            this.pic_Back.Size = new System.Drawing.Size(19, 36);
            this.pic_Back.TabIndex = 4;
            this.pic_Back.TabStop = false;
            this.pic_Back.Click += new System.EventHandler(this.pic_Back_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 705);
            this.Controls.Add(this.pic_Back);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportVisitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_patieontBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportPatieont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_DoctoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportDoctors)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetReportVisitTime DataSetReportVisitTime;
        private DataSetReportVisitTimeTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Tbl_patieontBindingSource;
        private DataSetReportPatieont DataSetReportPatieont;
        private DataSetReportPatieontTableAdapters.Tbl_patieontTableAdapter Tbl_patieontTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource Tbl_DoctoreBindingSource;
        private DataSetReportDoctors DataSetReportDoctors;
        private DataSetReportDoctorsTableAdapters.Tbl_DoctoreTableAdapter Tbl_DoctoreTableAdapter;
        private System.Windows.Forms.PictureBox pic_Back;
        private System.Windows.Forms.TabPage tabPage4;
        private MetroFramework.Controls.MetroButton btn_reportDoc;
        private MetroFramework.Controls.MetroComboBox com_Doc;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;

    }
}