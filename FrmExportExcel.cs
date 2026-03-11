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
    public partial class FrmExportExcel : MetroForm
    {
        public FrmExportExcel()
        {
            InitializeComponent();
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

                excelworkbook.SaveAs(@"F:\ExcelOUT.xlsx");
                System.Diagnostics.Process.Start(@"F:\ExcelOUT.xlsx");
            }
            catch (Exception er)
            {

                MessageBox.Show("Error, File not created..try again ----- " + er.Message);
            }



        }
        private void FrmExportExcel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ExportDataSetToExcel(DataSet_Patieont_excel);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
//            ExportDataSetToExcel(dB_myClinicDataSet2);
        }
    }
}
