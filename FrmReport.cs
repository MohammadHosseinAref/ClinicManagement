using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace myClinic
{
    public partial class FrmReport : MetroForm
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        String shamsi, hourse ;
        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReportDoctors.Tbl_Doctore' table. You can move, or remove it, as needed.
            this.Tbl_DoctoreTableAdapter.Fill(this.DataSetReportDoctors.Tbl_Doctore);
            // TODO: This line of code loads data into the 'DataSetReportPatieont.Tbl_patieont' table. You can move, or remove it, as needed.
            this.Tbl_patieontTableAdapter.Fill(this.DataSetReportPatieont.Tbl_patieont);
            // TODO: This line of code loads data into the 'DataSetReportVisitTime.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetReportVisitTime.DataTable1);

            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            // set foermat
            shamsi = String.Format("{0}/{1}/{2}" , pc.GetYear(DateTime.Now) , pc.GetMonth(DateTime.Now) , pc.GetDayOfMonth(DateTime.Now));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pDate" , shamsi));

            hourse = DateTime.Now.ToLongTimeString();

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pHourse" , hourse));

            //--------------

            reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pDate", shamsi));
            reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pTime", hourse));

            //----------------------

            reportViewer3.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pDate", shamsi));
            reportViewer3.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pTime", hourse));


            this.reportViewer1.RefreshReport(); 
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            //--------------------------------
            Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

            com_Doc.DataSource = db.Tbl_Doctore.ToList();

            com_Doc.DisplayMember = "name";
            com_Doc.ValueMember = "name"; //ID
            this.reportViewer4.RefreshReport();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain f = new FrmMain();
            f.Show();
        }

        int c = 0;
        private void btn_reportDoc_Click(object sender, EventArgs e)
        {
            
            if (c == 0)
            {
                /*
                reportViewer4.Visible = true;
                Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

                var rows = db.sp_view(1).Where(x => x.name_doctors.Contains(com_Doc.SelectedValue.ToString())).ToList();

                reportViewer4.LocalReport.ReportPath = "ReportVisitDocByName.rdlc";
                reportViewer4.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pNameDoc", com_Doc.SelectedValue.ToString()));

                reportViewer4.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", rows));

                reportViewer4.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pDate", shamsi));
                reportViewer4.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pTime", hourse));

                 
                reportViewer4.RefreshReport();
                */
                c++;
            }
            else
            {
                MessageBox.Show(C_String.msgtext(16));
            }
        }

    }
}
