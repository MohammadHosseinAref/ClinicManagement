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
    public partial class Frm_show_visit_Doc : MetroForm
    {
        public Frm_show_visit_Doc()
        {
            InitializeComponent();
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        public void showData_visitTime()
        {
            DGV_showVistDoc.DataSource = "";

            var data = db.sp_view(1).ToList().Where(x => x.name_doctors == C_Data.name);
//            var Sort_Datagrid_p = db.sp_view(1).ToList().OrderByDescending(p => p.id_visitTime);

            DGV_showVistDoc.DataSource = data.ToList();
        }
        private void Frm_show_visit_Doc_Load(object sender, EventArgs e)
        {
            lbl_nameDoc.Text = C_Data.name;

            // DATAGRID VIEW
            DGV_showVistDoc.ColumnCount = 11;
            DGV_showVistDoc.AutoGenerateColumns = false;

            DGV_showVistDoc.Columns[0].Name = "FileCode";
            DGV_showVistDoc.Columns[0].DataPropertyName = "FileCode";
            DGV_showVistDoc.Columns[0].HeaderText = "شماره پرونده بیمار";
            DGV_showVistDoc.Columns[0].Width = 150;

            DGV_showVistDoc.Columns[1].Name = "famiy_patient";
            DGV_showVistDoc.Columns[1].DataPropertyName = "famiy_patient";
            DGV_showVistDoc.Columns[1].HeaderText = "نام  خانوادگی بیمار";
            DGV_showVistDoc.Columns[1].Width = 150;

            DGV_showVistDoc.Columns[2].Name = "name_patient";
            DGV_showVistDoc.Columns[2].DataPropertyName = "name_patient";
            DGV_showVistDoc.Columns[2].HeaderText = "نام بیمار";
            DGV_showVistDoc.Columns[2].Width = 80;

            DGV_showVistDoc.Columns[3].Name = "mobile";
            DGV_showVistDoc.Columns[3].DataPropertyName = "mobile";
            DGV_showVistDoc.Columns[3].HeaderText = "شماره تماس بیمار";
            DGV_showVistDoc.Columns[3].Width = 150;

            DGV_showVistDoc.Columns[4].Name = "name_doctors";
            DGV_showVistDoc.Columns[4].DataPropertyName = "name_doctors";
            DGV_showVistDoc.Columns[4].HeaderText = "نام دکتر";
            DGV_showVistDoc.Columns[4].Width = 90;

            DGV_showVistDoc.Columns[5].Name = "cood_doc";
            DGV_showVistDoc.Columns[5].DataPropertyName = "cood_doc";
            DGV_showVistDoc.Columns[5].HeaderText = "کد دکتر";
            DGV_showVistDoc.Columns[5].Width = 90;

            DGV_showVistDoc.Columns[6].Name = "sectionType";
            DGV_showVistDoc.Columns[6].DataPropertyName = "sectionType";
            DGV_showVistDoc.Columns[6].HeaderText = "تخصص دکتر";
            DGV_showVistDoc.Columns[6].Width = 100;

            DGV_showVistDoc.Columns[7].Name = "date_visit";
            DGV_showVistDoc.Columns[7].DataPropertyName = "date_visit";
            DGV_showVistDoc.Columns[7].HeaderText = "تاریخ ویزیت";
            DGV_showVistDoc.Columns[7].Width = 90;

            DGV_showVistDoc.Columns[8].Name = "time_visit";
            DGV_showVistDoc.Columns[8].DataPropertyName = "time_visit";
            DGV_showVistDoc.Columns[8].HeaderText = "ساعت ویزیت";
            DGV_showVistDoc.Columns[8].Width = 100;

            DGV_showVistDoc.Columns[9].Name = "comment_visit";
            DGV_showVistDoc.Columns[9].DataPropertyName = "comment_visit";
            DGV_showVistDoc.Columns[9].HeaderText = "توضیحات";
            DGV_showVistDoc.Columns[9].Width = 110;


            DGV_showVistDoc.Columns[10].Name = "id_visitTime";
            DGV_showVistDoc.Columns[10].DataPropertyName = "id_visitTime";
            DGV_showVistDoc.Columns[10].HeaderText = "کد";
            DGV_showVistDoc.Columns[10].Width = 50;

            DataGridViewCheckBoxColumn DGV_checkbox_visit = new DataGridViewCheckBoxColumn();
            DGV_checkbox_visit.DataPropertyName = "checkbox_visit";
            DGV_checkbox_visit.Name = "checkbox_visit";
            DGV_checkbox_visit.Width = 43;
            DGV_checkbox_visit.HeaderText = "انتخاب";

            DGV_showVistDoc.Columns.Insert(11, DGV_checkbox_visit);

            showData_visitTime();
        }
        int id_visit;
        private void DGV_showVistDoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            id_visit = int.Parse(DGV_showVistDoc.Rows[e.RowIndex].Cells["id_visitTime"].Value.ToString());
        }

        private void Btn_deletVisit_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in DGV_showVistDoc.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean
                                                  (row.Cells["checkbox_visit"].Value) == true
                                                  select row).ToList();
            var ids = selectedRows.Select(x => (int)x.Cells["id_visitTime"].Value).ToList();

            var r = db.Tbl_visitTime.Where(x => ids.Contains(x.ID));// records of sql table based on ids'
            int c = r.Count();

            if (c == 0)
            {
                MessageBox.Show(C_String.msgtext(8), C_String.msgtext(7));
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(C_String.msgtext(5) + c.ToString() + C_String.msgtext(6), C_String.msgtext(7), MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var item in r)
                    {
                        db.Tbl_visitTime.Remove(item);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }

                db.SaveChanges();

                showData_visitTime();
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
