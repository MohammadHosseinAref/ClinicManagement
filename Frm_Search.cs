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
    public partial class Frm_Search : MetroForm
    {
        public Frm_Search()
        {
            InitializeComponent();
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        private void Frm_Search_Load(object sender, EventArgs e)
        {
            RadioB_Search_Type.PerformClick();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //DGV_show_Data.Rows.Clear();
            if (RadioB_Search_Type.Checked)
            {
                DGV_show_Data.DataSource = null;

                DGV_show_Data.ColumnCount = 2;
                DGV_show_Data.AutoGenerateColumns = false;

                DGV_show_Data.Columns[0].Name = "ID";
                DGV_show_Data.Columns[0].DataPropertyName = "ID";
                DGV_show_Data.Columns[0].HeaderText = "کد";
                DGV_show_Data.Columns[0].Width = 40;

                DGV_show_Data.Columns[1].Name = "sectionType";
                DGV_show_Data.Columns[1].DataPropertyName = "sectionType";
                DGV_show_Data.Columns[1].HeaderText = "نام ";
                DGV_show_Data.Columns[1].Width = 170;

                var querysearch = db.Tbl_section.Where(s => s.sectionType.Contains(TxtB_name.Text));
                DGV_show_Data.DataSource = querysearch.ToList();
            }
            else if (RadioB_Search_pat.Checked)
            {
                DGV_show_Data.DataSource = null;
                TxtB_name.Clear();

                DGV_show_Data.ColumnCount = 9;
                DGV_show_Data.AutoGenerateColumns = false;

                DGV_show_Data.Columns[0].Name = "ID";
                DGV_show_Data.Columns[0].DataPropertyName = "ID";
                DGV_show_Data.Columns[0].HeaderText = "کد";
                DGV_show_Data.Columns[0].Width = 40;

                DGV_show_Data.Columns[1].Name = "name";
                DGV_show_Data.Columns[1].DataPropertyName = "name";
                DGV_show_Data.Columns[1].HeaderText = "نام بیمار";
                DGV_show_Data.Columns[1].Width = 70;

                DGV_show_Data.Columns[2].Name = "family";
                DGV_show_Data.Columns[2].DataPropertyName = "family";
                DGV_show_Data.Columns[2].HeaderText = "نام خانوادگی";
                DGV_show_Data.Columns[2].Width = 70;

                DGV_show_Data.Columns[3].Name = "tell";
                DGV_show_Data.Columns[3].DataPropertyName = "tell";
                DGV_show_Data.Columns[3].HeaderText = "شماره ثابت";
                DGV_show_Data.Columns[3].Width = 60;

                DGV_show_Data.Columns[4].Name = "mobile";
                DGV_show_Data.Columns[4].DataPropertyName = "mobile";
                DGV_show_Data.Columns[4].HeaderText = "موبایل";
                DGV_show_Data.Columns[4].Width = 60;


                DGV_show_Data.Columns[5].Name = "NationalCode";
                DGV_show_Data.Columns[5].DataPropertyName = "NationalCode";
                DGV_show_Data.Columns[5].HeaderText = "شماره ملی";
                DGV_show_Data.Columns[5].Width = 60;


                DGV_show_Data.Columns[6].Name = "address";
                DGV_show_Data.Columns[6].DataPropertyName = "address";
                DGV_show_Data.Columns[6].HeaderText = "آدرس";
                DGV_show_Data.Columns[6].Width = 60;


                DGV_show_Data.Columns[7].Name = "FileCode";
                DGV_show_Data.Columns[7].DataPropertyName = "FileCode";
                DGV_show_Data.Columns[7].HeaderText = "شماره پرونده";
                DGV_show_Data.Columns[7].Width = 60;

                DGV_show_Data.Columns[8].Name = "comment";
                DGV_show_Data.Columns[8].DataPropertyName = "comment";
                DGV_show_Data.Columns[8].HeaderText = "توضیحات";
                DGV_show_Data.Columns[8].Width = 60;

                var querysearch = db.Tbl_patieont.Where(s => s.name.Contains(TxtB_name.Text)
                || s.family.Contains(TxtB_name.Text) );

                DGV_show_Data.DataSource = querysearch.ToList();
            }
            else if (RadioB_Search_Visit.Checked)
            {
                DGV_show_Data.DataSource = null;
                TxtB_name.Clear();

                DGV_show_Data.ColumnCount = 12;
                DGV_show_Data.AutoGenerateColumns = false;

                DGV_show_Data.Columns[0].Name = "FileCode";
                DGV_show_Data.Columns[0].DataPropertyName = "FileCode";
                DGV_show_Data.Columns[0].HeaderText = "شماره پرونده بیمار";
                DGV_show_Data.Columns[0].Width = 40;

                DGV_show_Data.Columns[1].Name = "famiy_patient";
                DGV_show_Data.Columns[1].DataPropertyName = "famiy_patient";
                DGV_show_Data.Columns[1].HeaderText = "نام  خانوادگی بیمار";
                DGV_show_Data.Columns[1].Width = 80;


                DGV_show_Data.Columns[2].Name = "name_patient";
                DGV_show_Data.Columns[2].DataPropertyName = "name_patient";
                DGV_show_Data.Columns[2].HeaderText = "نام بیمار";
                DGV_show_Data.Columns[2].Width = 80;


                DGV_show_Data.Columns[3].Name = "NationalCode";
                DGV_show_Data.Columns[3].DataPropertyName = "NationalCode";
                DGV_show_Data.Columns[3].HeaderText = "کد ملی بیمار";
                DGV_show_Data.Columns[3].Width = 50;

                DGV_show_Data.Columns[4].Name = "mobile";
                DGV_show_Data.Columns[4].DataPropertyName = "mobile";
                DGV_show_Data.Columns[4].HeaderText = "شماره تماس بیمار";
                DGV_show_Data.Columns[4].Width = 60;

                DGV_show_Data.Columns[5].Name = "name_doctors";
                DGV_show_Data.Columns[5].DataPropertyName = "name_doctors";
                DGV_show_Data.Columns[5].HeaderText = "نام دکتر";
                DGV_show_Data.Columns[5].Width = 80;

                DGV_show_Data.Columns[6].Name = "cood_doc";
                DGV_show_Data.Columns[6].DataPropertyName = "cood_doc";
                DGV_show_Data.Columns[6].HeaderText = "کد دکتر";
                DGV_show_Data.Columns[6].Width = 50;

                DGV_show_Data.Columns[7].Name = "sectionType";
                DGV_show_Data.Columns[7].DataPropertyName = "sectionType";
                DGV_show_Data.Columns[7].HeaderText = "تخصص دکتر";
                DGV_show_Data.Columns[7].Width = 80;

                DGV_show_Data.Columns[8].Name = "date_visit";
                DGV_show_Data.Columns[8].DataPropertyName = "date_visit";
                DGV_show_Data.Columns[8].HeaderText = "تاریخ ویزیت";
                DGV_show_Data.Columns[8].Width = 70;

                DGV_show_Data.Columns[9].Name = "time_visit";
                DGV_show_Data.Columns[9].DataPropertyName = "time_visit";
                DGV_show_Data.Columns[9].HeaderText = "ساعت ویزیت";
                DGV_show_Data.Columns[9].Width = 70;

                DGV_show_Data.Columns[10].Name = "comment_visit";
                DGV_show_Data.Columns[10].DataPropertyName = "comment_visit";
                DGV_show_Data.Columns[10].HeaderText = "توضیحات";
                DGV_show_Data.Columns[10].Width = 90;


                DGV_show_Data.Columns[11].Name = "id_visitTime";
                DGV_show_Data.Columns[11].DataPropertyName = "id_visitTime";
                DGV_show_Data.Columns[11].HeaderText = "کد";
                DGV_show_Data.Columns[11].Width = 40;

                var querysearch = db.sp_view(1).Where(s => s.name_patient.Contains(TxtB_name.Text)
                    || s.famiy_patient.Contains(TxtB_name.Text));
                DGV_show_Data.DataSource = querysearch.ToList();

            }
            else if (RadioB_Search_Doc.Checked)
            {
                DGV_show_Data.DataSource = null;

                DGV_show_Data.ColumnCount = 6;
                DGV_show_Data.AutoGenerateColumns = false;

                DGV_show_Data.Columns[0].Name = "ID";
                DGV_show_Data.Columns[0].DataPropertyName = "ID";
                DGV_show_Data.Columns[0].HeaderText = "کد";
                DGV_show_Data.Columns[0].Width = 40;

                DGV_show_Data.Columns[1].Name = "name";
                DGV_show_Data.Columns[1].DataPropertyName = "name";
                DGV_show_Data.Columns[1].HeaderText = "نام";
                DGV_show_Data.Columns[1].Width = 80;

                DGV_show_Data.Columns[2].Name = "sectionType";
                DGV_show_Data.Columns[2].DataPropertyName = "sectionType";
                DGV_show_Data.Columns[2].HeaderText = "تخصص";
                DGV_show_Data.Columns[2].Width = 80;

                DGV_show_Data.Columns[3].Name = "phone";
                DGV_show_Data.Columns[3].DataPropertyName = "phone";
                DGV_show_Data.Columns[3].HeaderText = "شماره تماس";
                DGV_show_Data.Columns[3].Width = 90;


                DGV_show_Data.Columns[4].Name = "cood_D";
                DGV_show_Data.Columns[4].DataPropertyName = "cood_D";
                DGV_show_Data.Columns[4].HeaderText = "کد نظام پزشکی";
                DGV_show_Data.Columns[4].Width = 80;


                DGV_show_Data.Columns[5].Name = "coment";
                DGV_show_Data.Columns[5].DataPropertyName = "coment";
                DGV_show_Data.Columns[5].HeaderText = "توضیحات";
                DGV_show_Data.Columns[5].Width = 70;

                var querysearch = db.Tbl_Doctore.Where(s => s.name.Contains(TxtB_name.Text));
                DGV_show_Data.DataSource = querysearch.ToList();
            }
        }

        private void btn_refresh_grid_Click(object sender, EventArgs e)
        {
            DGV_show_Data.Refresh();
            DGV_show_Data.Columns.Clear();
        }
    }
}
