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
using Excel = Microsoft.Office.Interop.Excel;

namespace myClinic
{
    public partial class Frm_getBackup_patients : MetroForm
    {
        public Frm_getBackup_patients()
        {
            InitializeComponent();
        }

        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        int checktypy=0;// برای چک کردن این که کدوم گذینه انتخاب شده؟ دریافت اکسل یا ارسال به اکسل
        private void Frm_getBackup_patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_myClinicDataSetExportExcel.Tbl_patieont' table. You can move, or remove it, as needed.
            this.tbl_patieontTableAdapter.Fill(this.dB_myClinicDataSetExportExcel.Tbl_patieont);
            // TODO: This line of code loads data into the 'dataSet_Patieont_excel.Tbl_patieont' table. You can move, or remove it, as needed.
            btn_saveToDb.Enabled = false;

            rb_sent_excel.PerformClick();

            DGV_Patient.Enabled = false;

            //DGV_Patient.ColumnCount = 9;
            DGV_Patient.AutoGenerateColumns = false;

            DGV_Patient.Columns[0].Name = "ID";
            DGV_Patient.Columns[0].DataPropertyName = "ID";
            DGV_Patient.Columns[0].HeaderText = "کد";
            DGV_Patient.Columns[0].Width = 40;

            DGV_Patient.Columns[1].Name = "name";
            DGV_Patient.Columns[1].DataPropertyName = "name";
            DGV_Patient.Columns[1].HeaderText = "نام بیمار";
            DGV_Patient.Columns[1].Width = 70;

            DGV_Patient.Columns[2].Name = "family";
            DGV_Patient.Columns[2].DataPropertyName = "family";
            DGV_Patient.Columns[2].HeaderText = "نام خانوادگی";
            DGV_Patient.Columns[2].Width = 70;

            DGV_Patient.Columns[3].Name = "tell";
            DGV_Patient.Columns[3].DataPropertyName = "tell";
            DGV_Patient.Columns[3].HeaderText = "شماره ثابت";
            DGV_Patient.Columns[3].Width = 60;

            DGV_Patient.Columns[4].Name = "mobile";
            DGV_Patient.Columns[4].DataPropertyName = "mobile";
            DGV_Patient.Columns[4].HeaderText = "موبایل";
            DGV_Patient.Columns[4].Width = 60;


            DGV_Patient.Columns[5].Name = "NationalCode";
            DGV_Patient.Columns[5].DataPropertyName = "NationalCode";
            DGV_Patient.Columns[5].HeaderText = "شماره ملی";
            DGV_Patient.Columns[5].Width = 60;


            DGV_Patient.Columns[6].Name = "address";
            DGV_Patient.Columns[6].DataPropertyName = "address";
            DGV_Patient.Columns[6].HeaderText = "آدرس";
            DGV_Patient.Columns[6].Width = 60;


            DGV_Patient.Columns[7].Name = "FileCode";
            DGV_Patient.Columns[7].DataPropertyName = "FileCode";
            DGV_Patient.Columns[7].HeaderText = "شماره پرونده";
            DGV_Patient.Columns[7].Width = 60;

            DGV_Patient.Columns[8].Name = "comment";
            DGV_Patient.Columns[8].DataPropertyName = "comment";
            DGV_Patient.Columns[8].HeaderText = "توضیحات";
            DGV_Patient.Columns[8].Width = 60;

            show_pation();
        }

        private void rb_get_excel_CheckedChanged(object sender, EventArgs e)
        {
            btn_get_sent_excel.Text = "اکسل را وارد کنید";

            DGV_sentToExcel.Enabled = false;
            DGV_Patient.Enabled = true ;
            checktypy = 1; 
        }

        private void rb_sent_excel_CheckedChanged(object sender, EventArgs e)
        {
            show_pation();

            btn_saveToDb.Enabled = false;
            
            btn_get_sent_excel.Text = "ذخیره در اکسل";

            DGV_sentToExcel.Enabled = true;
            DGV_Patient.Enabled = false;

            checktypy = 0; 
        }
        DataTable dt = new DataTable();
        private void show_pation()
        {

            DGV_Patient.DataSource = "";

            var Sort_Datagrid_p = db.Tbl_patieont.ToList().OrderByDescending(p => p.ID);

            DGV_Patient.DataSource = Sort_Datagrid_p.ToList();

        }

        private void btn_get_sent_excel_Click(object sender, EventArgs e)
        {

            if(checktypy==1) // یعنی وارد کردن اکسل به فرم
            {
                btn_saveToDb.Enabled = true;
                openFileDialog1.Filter = "Excel | *.xlsx";
                Excel.Application xapp = new Excel.Application();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Excel.Workbook xlworkbook = xapp.Workbooks.Open(openFileDialog1.FileName);

                        Excel._Worksheet xlworksheet = xlworkbook.Sheets[1];

                        Excel.Range xlRange = xlworksheet.UsedRange;


                        dt.Columns.Add("ID", typeof(string));
                        dt.Columns.Add("name", typeof(string));
                        dt.Columns.Add("family", typeof(string));
                        dt.Columns.Add("tell", typeof(string));
                        dt.Columns.Add("mobile", typeof(string));
                        dt.Columns.Add("NationalCode", typeof(string));
                        dt.Columns.Add("address", typeof(string));
                        dt.Columns.Add("FileCode", typeof(string));
                        dt.Columns.Add("comment", typeof(string));

                        int rowcount = xlRange.Rows.Count;
                        int colCount = xlRange.Columns.Count;

                        for (int i = 1; i <= rowcount; i++)
                        {
                            dt.Rows.Add(dt.NewRow());

                            for (int j = 1; j <= colCount; j++)
                            {
                                String s = Convert.ToString(xlRange.Cells[i + 1, j].value2);

                                dt.Rows[i - 1][j - 1] = s;
                            }
                        }
                        xlworkbook.Close();

                        DGV_Patient.DataSource = dt;

                        DGV_Patient.Refresh();
                    }catch (Exception)
                    {
                        MessageBox.Show(C_String.msgtext(21));
                    }

                       
                }

            }else if (checktypy == 0)
            {
                timerProgress.Enabled = true;
                timerProgress.Interval = 300;
                timerProgress.Start();
                ExportDataSetToExcel(dB_myClinicDataSetExportExcel);
                timerProgress.Stop();
                Progress_save_Excel.Visible = false;
            }
        }

        private void ExportDataSetToExcel(DataSet ds)
        {
            Excel.Application xlApp = new Excel.Application();
            // create a new workbook of excel
            Excel.Workbook excelworkbook = xlApp.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
            // sheet definition :
            Excel.Worksheet xlworksheet = (Excel.Worksheet)excelworkbook.Worksheets[1];

            xlworksheet.DisplayRightToLeft = true;
            /////////////////////////////////////////////////////////////////////////////////

            DataTable table = ds.Tables[0]; // first table of dataset
            // Excel.Worksheets excelworksheet = excelworkbook.Sheets.Add();
            xlworksheet.Name = table.TableName;


            for (int i = 1; i < table.Columns.Count + 1; i++)
            {
                xlworksheet.Cells[1, i] = table.Columns[i - 1].ColumnName; // read lable columns
            }
            // read data 
            for (int j = 0; j < table.Rows.Count; j++)
            {
                for (int k = 0; k < table.Columns.Count; k++)
                {
                    xlworksheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                }
            }
            try
            {
                //String namefile = "Excel1.xlsx";
                //SaveFileDialog fileDialog = new SaveFileDialog();

                //fileDialog.FileName = namefile;
                //if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    using (Stream s = File.Open(fileDialog.FileName, FileMode.CreateNew))
                //    {
                //        excelworkbook.SaveAs(Path.GetDirectoryName(fileDialog.FileName));
                //        // @"D:\SokriExcelOUT.xlsx"
                //        //System.Diagnostics.Process.Start(Path.GetDirectoryName(fileDialog.FileName));
                //    }
                //}

                excelworkbook.SaveAs(@"F:excel\ExcelOUT.xlsx");
                System.Diagnostics.Process.Start(@"F:excel\ExcelOUT.xlsx");
            }
            catch (Exception er)
            {

                MessageBox.Show("Error, File not created..try again ----- " + er.Message);
            }



        }
        private void btn_saveToDb_Click(object sender, EventArgs e)
        {
            using (var usersDB = new Model.DB_myClinicEntities4())
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    usersDB.Tbl_patieont .Add(new Model.Tbl_patieont()
                    {
                      //  ID = int.Parse( dr["ID"].ToString() ),
                        name = dr["name"].ToString(),
                        family = dr["family"].ToString(),
                        tell = dr["tell"].ToString(),
                        mobile = dr["mobile"].ToString(),
                        NationalCode = dr["NationalCode"].ToString(),
                        address = dr["address"].ToString(),
                        //FileCode = Convert.ToInt16(dr["FileCode"]),
                        comment = dr["comment"].ToString()
                    });
                }
                int ii = usersDB.SaveChanges();
                if (ii != 0)
                {
                    MessageBox.Show(C_String.msgtext(22));
                }else
                {
                    MessageBox.Show(C_String.msgtext(23));
                }
            }
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (Progress_save_Excel.Value < Progress_save_Excel.Maximum)
            {
                Progress_save_Excel.Value += 20;

            }
            else
            {
                Progress_save_Excel.Visible = false;
            }
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain f = new FrmMain();
            f.Show();
        }
    }
}
