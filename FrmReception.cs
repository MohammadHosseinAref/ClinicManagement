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
using System.Globalization;
namespace myClinic
{
    public partial class FrmReception : Form
    {
        public FrmReception()
        {
            InitializeComponent();
        }
        public void Clear_txt_pation()
        {
            txtB_name.Clear();
            txtB_family.Clear();
            txtB_mobil.Clear();
            txtB_tell.Clear();
            txtB_Ncood.Clear();
            txtB_address.Clear();
            txtB_comment.Clear();
        }

        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        public void showData_Tbl_Patient(DataGridView dgv)
        {
            dgv.DataSource = "";

            var Sort_Datagrid_p = db.Tbl_patieont.ToList().OrderByDescending(p => p.ID);

            dgv.DataSource = Sort_Datagrid_p.ToList();
        }
        public void refresh_Tbl_Patient()
        {
            //            Model.DB_myClinicEntities4 db2 = ne
            DGV_Patient.DataSource = null;

            Model.DB_myClinicEntities4 db2 = new Model.DB_myClinicEntities4();

            var Sort_Datagrid_p = db2.Tbl_patieont.ToList().OrderByDescending(p => p.ID);

            DGV_Patient.DataSource = Sort_Datagrid_p.ToList();
        }
        public void refreshdatagridview()
        {
            DGV_Patient.DataSource = "";

            //DGV_Patient.ColumnCount = 9;

            //DGV_Patient.AutoGenerateColumns = false;

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

            var Sort_Datagrid_p = db.Tbl_patieont.ToList().OrderByDescending(p => p.ID);

            DGV_Patient.DataSource = Sort_Datagrid_p.ToList();
        }


        public void show_name_pation_in_Comb()
        {
            cmB_namePatient.DataSource = db.Tbl_patieont.ToList();
            cmB_namePatient.DisplayMember = "name";
            cmB_namePatient.ValueMember = "ID";
        }
        public void showData_visitTime(DataGridView dgv)
        {
            dgv.DataSource = "";

            var Sort_Datagrid_p = db.sp_view(1).ToList().OrderByDescending(p => p.id_visitTime);

            dgv.DataSource = Sort_Datagrid_p.ToList();
        }
        public void refresh_visitTime()
        {
            DGV_visitTime.DataSource = "";

            var Sort_Datagrid_p = db.sp_view(1).ToList().OrderByDescending(p => p.id_visitTime);

            DGV_visitTime.DataSource = Sort_Datagrid_p.ToList();
        }

        public void Clear_txt_visit()
        {
            rTxtB_comment.Clear();
            //txtB_date.Clear();
            txtB_time_Hourse.Clear();
            txtB_time_Minute.Clear();
        }
        private void TSM_back_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain fm = new FrmMain();
            fm.Show();
        }

        private void TSM_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmReception_Load(object sender, EventArgs e)
        {
            //set data source in com box section
            comB_section.DataSource = db.Tbl_section.ToList();
            comB_section.DisplayMember = "sectionType";
            comB_section.ValueMember = "ID";
            //-------------
            comB_sectionForCount.DisplayMember = "sectionType";
            comB_sectionForCount.ValueMember = "ID";

            comB_sectionForCount.DataSource = db.Tbl_section.ToList();
            //-------------

            //set data source in com box namePatient 
            cmB_namePatient.DataSource = db.Tbl_patieont.ToList();
            cmB_namePatient.DisplayMember = "name";
            cmB_namePatient.ValueMember = "ID";
            //--------------

            // set data in data gride view Patient
            DGV_Patient.ColumnCount = 9;
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
            DGV_Patient.Columns[2].Width = 90;

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
            DGV_Patient.Columns[5].Width = 75;


            DGV_Patient.Columns[6].Name = "address";
            DGV_Patient.Columns[6].DataPropertyName = "address";
            DGV_Patient.Columns[6].HeaderText = "آدرس";
            DGV_Patient.Columns[6].Width = 60;


            DGV_Patient.Columns[7].Name = "FileCode";
            DGV_Patient.Columns[7].DataPropertyName = "FileCode";
            DGV_Patient.Columns[7].HeaderText = "شماره پرونده";
            DGV_Patient.Columns[7].Width = 65;

            DGV_Patient.Columns[8].Name = "comment";
            DGV_Patient.Columns[8].DataPropertyName = "comment";
            DGV_Patient.Columns[8].HeaderText = "توضیحات";
            DGV_Patient.Columns[8].Width = 60;

            DataGridViewCheckBoxColumn DGV_checkbox = new DataGridViewCheckBoxColumn();
            DGV_checkbox.DataPropertyName = "checkboxcolumn";
            DGV_checkbox.Name = "checkboxcolumn";
            DGV_checkbox.Width = 45;
            DGV_checkbox.HeaderText = "انتخاب";

            DGV_Patient.Columns.Insert(9, DGV_checkbox);

            //DataGridViewButtonColumn DGV_button = new DataGridViewButtonColumn();

            //DGV_button.DataPropertyName = "buttoncolumn";
            //DGV_button.Name = "buttoncolumn";
            //DGV_button.Width = 45;
            //DGV_button.HeaderText = "خذف";
            //DGV_Patient.Columns.Insert(9, DGV_button);

            showData_Tbl_Patient(DGV_Patient);

            Clear_txt_pation();
            //---------------------------------
//            DGV_Patient.Columns["checkboxcolumn"].Visible = false;

            // DATAGRID VIEW
            DGV_visitTime.ColumnCount = 13;
            DGV_visitTime.AutoGenerateColumns = false;

            DGV_visitTime.Columns[0].Name = "FileCode";
            DGV_visitTime.Columns[0].DataPropertyName = "FileCode";
            DGV_visitTime.Columns[0].HeaderText = "شماره پرونده بیمار";
            DGV_visitTime.Columns[0].Width = 40;

            DGV_visitTime.Columns[1].Name = "famiy_patient";
            DGV_visitTime.Columns[1].DataPropertyName = "famiy_patient";
            DGV_visitTime.Columns[1].HeaderText = "نام  خانوادگی بیمار";
            DGV_visitTime.Columns[1].Width = 80;


            DGV_visitTime.Columns[2].Name = "name_patient";
            DGV_visitTime.Columns[2].DataPropertyName = "name_patient";
            DGV_visitTime.Columns[2].HeaderText = "نام بیمار";
            DGV_visitTime.Columns[2].Width = 80;


            DGV_visitTime.Columns[3].Name = "NationalCode";
            DGV_visitTime.Columns[3].DataPropertyName = "NationalCode";
            DGV_visitTime.Columns[3].HeaderText = "کد ملی بیمار";
            DGV_visitTime.Columns[3].Width = 50;

            DGV_visitTime.Columns[4].Name = "mobile";
            DGV_visitTime.Columns[4].DataPropertyName = "mobile";
            DGV_visitTime.Columns[4].HeaderText = "شماره تماس بیمار";
            DGV_visitTime.Columns[4].Width = 60;

            DGV_visitTime.Columns[5].Name = "name_doctors";
            DGV_visitTime.Columns[5].DataPropertyName = "name_doctors";
            DGV_visitTime.Columns[5].HeaderText = "نام دکتر";
            DGV_visitTime.Columns[5].Width = 80;

            DGV_visitTime.Columns[6].Name = "cood_doc";
            DGV_visitTime.Columns[6].DataPropertyName = "cood_doc";
            DGV_visitTime.Columns[6].HeaderText = "کد دکتر";
            DGV_visitTime.Columns[6].Width = 50;

            DGV_visitTime.Columns[7].Name = "sectionType";
            DGV_visitTime.Columns[7].DataPropertyName = "sectionType";
            DGV_visitTime.Columns[7].HeaderText = "تخصص دکتر";
            DGV_visitTime.Columns[7].Width = 80;

            DGV_visitTime.Columns[8].Name = "visitTimeShamsi";
            DGV_visitTime.Columns[8].DataPropertyName = "visitTimeShamsi";
            DGV_visitTime.Columns[8].HeaderText = "تاریخ ویزیت";
            DGV_visitTime.Columns[8].Width = 70;

            DGV_visitTime.Columns[9].Name = "time_visit";
            DGV_visitTime.Columns[9].DataPropertyName = "time_visit";
            DGV_visitTime.Columns[9].HeaderText = "ساعت ویزیت";
            DGV_visitTime.Columns[9].Width = 70;

            DGV_visitTime.Columns[10].Name = "comment_visit";
            DGV_visitTime.Columns[10].DataPropertyName = "comment_visit";
            DGV_visitTime.Columns[10].HeaderText = "توضیحات";
            DGV_visitTime.Columns[10].Width = 90;


            DGV_visitTime.Columns[11].Name = "id_visitTime";
            DGV_visitTime.Columns[11].DataPropertyName = "id_visitTime";
            DGV_visitTime.Columns[11].HeaderText = "کد";
            DGV_visitTime.Columns[11].Width = 40;

            DGV_visitTime.Columns[12].Name = "date_visit";
            DGV_visitTime.Columns[12].DataPropertyName = "date_visit";
            DGV_visitTime.Columns[12].HeaderText = "تاریخ میلادی";
            DGV_visitTime.Columns[12].Width = 70;

            DataGridViewCheckBoxColumn DGV_checkbox_visit = new DataGridViewCheckBoxColumn();
            DGV_checkbox_visit.DataPropertyName = "checkbox_visit";
            DGV_checkbox_visit.Name = "checkbox_visit";
            DGV_checkbox_visit.Width = 43;
            DGV_checkbox_visit.HeaderText = "انتخاب";

            DGV_visitTime.Columns.Insert(13, DGV_checkbox_visit);


            showData_visitTime(DGV_visitTime);
            //----------

            TxtB_update.Clear();
        }


        private void btn_save_Patient_Click(object sender, EventArgs e)
        {
            if (txtB_name.Text == "" && txtB_family.Text == "" && txtB_mobil.Text == ""
                && txtB_tell.Text == "" && txtB_Ncood.Text == "")
            {
                MessageBox.Show(C_String.msgtext(1));
            }
            else if(txtB_Ncood.Text.Length != 10 ){
                MessageBox.Show(C_String.msgtext(12));
            }
            else
            {
                try
                {
                    var queryNCood = db.Tbl_patieont.Where(u => u.NationalCode == txtB_Ncood.Text).Select(u => u.NationalCode).Single();
                    
                    if (txtB_Ncood.Text == queryNCood.ToString())
                    {
                        MessageBox.Show(C_String.msgtext(11));
                    }
                }catch(Exception ){
                    Random random = new Random();
                    int RNumber = random.Next(1, 100);
                    char c0 = txtB_Ncood.Text[0];
                    char c9 = txtB_Ncood.Text[9];
                    char c02 = txtB_Ncood.Text[0];
                    char c5 = txtB_Ncood.Text[5];

                    int f = c0 + c02;

                    String fcode = f + RNumber.ToString() + c9 + c5;
                    Model.Tbl_patieont newrow_patient = new Model.Tbl_patieont();

                    newrow_patient.name = txtB_name.Text;
                    newrow_patient.family = txtB_family.Text;
                    newrow_patient.mobile = txtB_mobil.Text;
                    newrow_patient.tell = txtB_tell.Text;
                    newrow_patient.NationalCode = txtB_Ncood.Text;
                    newrow_patient.address = txtB_address.Text;
                    newrow_patient.FileCode = int.Parse(fcode);
                    newrow_patient.comment = txtB_comment.Text;

                    db.Tbl_patieont.Add(newrow_patient);

                    db.SaveChanges();

                    showData_Tbl_Patient(DGV_Patient);

                    show_name_pation_in_Comb();
                    
                    Clear_txt_pation();
                }
                 //   else
                   //{
                     
                    //}
                
             //   style_datagridView(DGV_Patient);
            }
        }

        private void btn_Clear_txt_Patient_Click(object sender, EventArgs e)
        {
            Clear_txt_pation();
        }

        private void picB_search_Patient_Click(object sender, EventArgs e)
        {
            if (txtB_search_Patient.Visible == false)
            {
                txtB_search_Patient.Visible = true;

                groupB_Search_setting.Visible = true;
                groupB_advanceSetting.Visible = true;

                groupB_advanceSetting.Enabled = false;
                RB_nurmal_search.PerformClick();
            }
            else
            {
                txtB_search_Patient.Visible = false;

                groupB_Search_setting.Visible = false;
                groupB_advanceSetting.Visible = false;
            }
        }

        private void RB_Advanced_search_CheckedChanged(object sender, EventArgs e)
        {

            groupB_advanceSetting.Enabled= true;

            txtB_search_Patient.Enabled = false;
        }

        private void RB_nurmal_search_CheckedChanged(object sender, EventArgs e)
        {
            groupB_advanceSetting.Enabled = false;

            txtB_search_Patient.Enabled = true;
        }
        private void txtB_search_Patient_TextChanged(object sender, EventArgs e)
        {
            var querysearch = db.Tbl_patieont.Where(s => s.name.Contains(txtB_search_Patient.Text)
                || s.family.Contains(txtB_search_Patient.Text) || s.NationalCode.Contains(txtB_search_Patient.Text));

            DGV_Patient.DataSource = querysearch.ToList();

            Clear_txt_pation();
        }

        private void btn_search_advance_Click(object sender, EventArgs e)
        {
            if (txtB_search_N_F_P.Text.Length > 0)
            {
                var querysearch = db.Tbl_patieont.Where(s => s.name.Contains(txtB_search_N_F_P.Text)
                    || s.family.Contains(txtB_search_N_F_P.Text));
                DGV_Patient.DataSource = querysearch.ToList();

                txtB_search_N_F_P.Clear();

                Clear_txt_pation();
            }
            else if (txtB_search_M_T_P.Text.Length > 0)
            {
                var querysearch = db.Tbl_patieont.Where(s => s.mobile.Contains(txtB_search_M_T_P.Text)
                    || s.tell.Contains(txtB_search_M_T_P.Text));
                DGV_Patient.DataSource = querysearch.ToList();

                txtB_search_M_T_P.Clear();

                Clear_txt_pation();
            }
            else if (txtB_search_NC_P.Text.Length > 0)
            {
                var querysearch = db.Tbl_patieont.Where(s => s.NationalCode.Contains(txtB_search_NC_P.Text));
                DGV_Patient.DataSource = querysearch.ToList();

                txtB_search_NC_P.Clear();

                Clear_txt_pation();
            }

            else if (txtB_search_FI_P.Text.Length > 0)
            {
                int Fcood = int.Parse(txtB_search_FI_P.Text);
             
                var querysearch = db.Tbl_patieont.Where(s => s.FileCode==Fcood);
                DGV_Patient.DataSource = querysearch.ToList();

                txtB_search_FI_P.Clear();

                Clear_txt_pation();
            }
            else if (txtB_search_N_F_P.Text.Length == 0 && txtB_search_M_T_P.Text.Length == 0 && txtB_search_NC_P.Text.Length == 0)
            {
                MessageBox.Show(C_String.msgtext(4));
            }
            else
            {

                var querysearch = db.Tbl_patieont.Where(s => s.name.Contains(txtB_search_N_F_P.Text)
                    || s.family.Contains(txtB_search_N_F_P.Text) || s.mobile.Contains(txtB_search_M_T_P.Text)
                    || s.tell.Contains(txtB_search_M_T_P.Text) || s.NationalCode.Contains(txtB_search_NC_P.Text));
                DGV_Patient.DataSource = querysearch.ToList();

                Clear_txt_pation();
            }
        }

        private void btn_Cancel_search_advance_Click(object sender, EventArgs e)
        {
            showData_Tbl_Patient(DGV_Patient);

            Clear_txt_pation();
        }

        private void btn_delet_Patient_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataGridViewRow> selectedRows = (from row in DGV_Patient.Rows.Cast<DataGridViewRow>()
                                                      where Convert.ToBoolean
                                                      (row.Cells["checkboxcolumn"].Value) == true
                                                      select row).ToList();
                var ids = selectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();

                var r = db.Tbl_patieont.Where(x => ids.Contains(x.ID));// records of sql table based on ids'
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
                            db.Tbl_patieont.Remove(item);

                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }


                    db.SaveChanges();

                    showData_Tbl_Patient(DGV_Patient);

                    show_name_pation_in_Comb();

                    Clear_txt_pation();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(C_String.msgtext(9));
            }
        }
        int idSelect_sec;
        private void btn_searchDocForPatient_Click(object sender, EventArgs e)
        {

            txtB_time_Hourse.Text = DateTime.Now.Hour.ToString();
            txtB_time_Minute.Text = DateTime.Now.Minute.ToString();

            groupB_visittime.Enabled = true;

            idSelect_sec = int.Parse(comB_section.SelectedValue.ToString());

            comB_doctors.DataSource = db.SP_getname_doc(idSelect_sec, idSelect_sec).ToList();

            comB_doctors.DisplayMember = "name";
            comB_doctors.ValueMember = "id_doctore";
        }

        private void btn_saveVisittime_Click(object sender, EventArgs e)
        {
            if (PersianCalender.Text.Length == 0)
            {
                MessageBox.Show(C_String.msgtext(25));
            }
            else
            {
                Model.Tbl_visitTime newrowvisittime = new Model.Tbl_visitTime();

                DateTime t = Convert.ToDateTime(PersianCalender.Miladi);
                // رکوردی را میاورد که دکتر در اون تاریخ با اون بیمار وقت گرفته است 
                var recordVisitDoc = db.Tbl_visitTime.ToList().Find(a => a.id_doc ==
                    int.Parse(comB_doctors.SelectedValue.ToString()) && a.id_pat ==
                    int.Parse(cmB_namePatient.SelectedValue.ToString()) && a.date.Equals(t));

                String ti = txtB_time_Minute.Text + " : " + txtB_time_Hourse.Text;

                if (txtB_time_Minute.Text.Length == 1)
                {
                    ti = "0" + txtB_time_Minute.Text + " : " + txtB_time_Hourse.Text;
                }
                // رکوردی که دکتر در این تاریخ وقت گرفته است 
                var recordVisitDocTime = db.Tbl_visitTime.ToList().Find(
                    a => a.id_doc == int.Parse(comB_doctors.SelectedValue.ToString())
                    && a.date.Equals(PersianCalender.Miladi) && a.time.Equals(ti));

                if (recordVisitDoc != null)
                {
                    //this if =>> بررسی این که یک دکتر توی یک روز نتواند با یک بیمار دوبار قرار ملاقات بگزارد
                    if (recordVisitDoc.date.Equals(PersianCalender.Miladi) && recordVisitDoc.id_pat.Equals(int.Parse(cmB_namePatient.SelectedValue.ToString())))
                    {
                        MessageBox.Show(C_String.msgtext(17));
                    }
                }

                else if (recordVisitDocTime != null)
                {
                    // جک کردن ویزیت دکتر در یک ساعت و یک تاریخ
                    if (recordVisitDocTime.date.Equals(PersianCalender.Miladi) && recordVisitDocTime.time.Equals(ti))
                    {
                        var getnamepation = db.Tbl_patieont.Where(s => s.ID == recordVisitDocTime.id_pat).Select(s => s.name).Single();

                        MessageBox.Show(C_String.msgtext(18) + getnamepation + C_String.msgtext(19) + C_String.msgtext(20) + recordVisitDocTime.ID);
                    }
                }
                else
                {
                    if (txtB_time_Hourse.Text.Length != 2 || txtB_time_Minute.Text.Length != 2)
                    {
                        MessageBox.Show(C_String.msgtext(24));
                    }
                    else
                    {
                        int id_pat = int.Parse(cmB_namePatient.SelectedValue.ToString());

                        int id_doc = int.Parse(comB_doctors.SelectedValue.ToString());

                        String h = txtB_time_Hourse.Text;
                        String m = txtB_time_Minute.Text;

                        //            String timeVisit = txtB_time_Hourse.Text + " : " + txtB_time_Minute.Text;

                        newrowvisittime.id_pat = id_pat;
                        newrowvisittime.id_doc = id_doc;
                        newrowvisittime.time = ti;// "0" + txtB_time_Minute.Text + " : " + txtB_time_Hourse.Text;// time_Visit;
                        newrowvisittime.date = Convert.ToDateTime(PersianCalender.Miladi);
                        newrowvisittime.comment = rTxtB_comment.Text;
                        newrowvisittime.id_sec = idSelect_sec;

                        db.Tbl_visitTime.Add(newrowvisittime);
                        db.SaveChanges();

                        showData_visitTime(DGV_visitTime);

                        groupB_visittime.Enabled = false;

                        Clear_txt_visit();
                    }
                }
            }
            
        }

        private void picB_refresh_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmReception fr = new FrmReception();
            fr.Show();
        }

        private void picB_search_visit_Click(object sender, EventArgs e)
        {
            if (txtB_search_Visit.Visible == false)
            {
                txtB_search_Visit.Visible = true;

                groupB_Search_Visit_setting.Visible = true;
                groupB_advanceSetting_Visit.Visible = true;

                groupB_advanceSetting_Visit.Enabled = false;
                RB_nurmal_search_Visit.PerformClick();
            }
            else
            {
                txtB_search_Visit.Visible = false;

                groupB_Search_Visit_setting.Visible = false;
                groupB_advanceSetting_Visit.Visible = false;
            }
        }

        private void RB_nurmal_search_Visit_CheckedChanged(object sender, EventArgs e)
        {
            groupB_advanceSetting_Visit.Enabled = false;

            txtB_search_Visit.Enabled = true;
        }

        private void RB_Advanced_search_Visit_CheckedChanged(object sender, EventArgs e)
        {
            groupB_advanceSetting_Visit.Enabled = true;

            txtB_search_Visit.Enabled = false;

        }

        private void btn_deletVisitTime_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in DGV_visitTime.Rows.Cast<DataGridViewRow>()
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

                showData_visitTime(DGV_visitTime);
            }
        }

        private void txtB_search_Visit_TextChanged(object sender, EventArgs e)
        {
            var querysearch = db.sp_view(1).Where(s => s.name_patient.Contains(txtB_search_Visit.Text)
                || s.famiy_patient.Contains(txtB_search_Visit.Text) || s.NationalCode.Contains(txtB_search_Visit.Text));
            DGV_visitTime.DataSource = querysearch.ToList();
        }

        private void btn_search_advance_Visit_Click(object sender, EventArgs e)
        {
            if (txtB_search_N_F_V.Text.Length > 0)
            {
                var querysearch = db.sp_view(1).Where(s => s.name_patient.Contains(txtB_search_N_F_V.Text)
                    || s.famiy_patient.Contains(txtB_search_N_F_V.Text));
                DGV_visitTime.DataSource = querysearch.ToList();

                txtB_search_N_F_V.Clear();
            }
            else if (txtB_search_N_Doc_V.Text.Length > 0)
            {
                var querysearch = db.sp_view(1).Where(s => s.name_doctors.Contains(txtB_search_N_Doc_V.Text));
                DGV_visitTime.DataSource = querysearch.ToList();

                txtB_search_N_Doc_V.Clear();
            }
            else if (txtB_search_N_F_V.Text.Length == 0 && txtB_search_N_Doc_V.Text.Length == 0)
            {
                MessageBox.Show(C_String.msgtext(4));
            }
            else if (txtB_search_N_F_V.Text.Length != 0 || txtB_search_N_Doc_V.Text.Length != 0)
            {
                var querysearch = db.sp_view(1).Where(s =>
                s.name_patient.Contains(txtB_search_N_F_V.Text) ||
                s.famiy_patient.Contains(txtB_search_N_F_V.Text) ||
                s.name_doctors.Contains(txtB_search_N_Doc_V.Text));

                DGV_visitTime.DataSource = querysearch.ToList();

                txtB_search_N_F_V.Clear();

                txtB_search_N_Doc_V.Clear();
            }
        }

        private void btn_Cancel_search_advance_Visit_Click(object sender, EventArgs e)
        {
            showData_visitTime(DGV_visitTime);
        }

        int id_dgv_patient , checkformupdate;
        String name_Patient, family_Patient, tell_Patient, mobile_Patient, NationalCode_Patient
                , address_Patient, FileCode_Patient, comment_Patient;

        private void DGV_Patient_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            id_dgv_patient = (int)DGV_Patient.Rows[e.RowIndex].Cells["ID"].Value;

            GroupB_Update.Text = "ویرایش بیمار";

            checkformupdate = 1;

            name_Patient = DGV_Patient.Rows[e.RowIndex].Cells["name"].Value.ToString();
            family_Patient = DGV_Patient.Rows[e.RowIndex].Cells["family"].Value.ToString();
            tell_Patient = DGV_Patient.Rows[e.RowIndex].Cells["tell"].Value.ToString();
            mobile_Patient = DGV_Patient.Rows[e.RowIndex].Cells["mobile"].Value.ToString();
            NationalCode_Patient = DGV_Patient.Rows[e.RowIndex].Cells["NationalCode"].Value.ToString();
            address_Patient = DGV_Patient.Rows[e.RowIndex].Cells["address"].Value.ToString();
            FileCode_Patient = DGV_Patient.Rows[e.RowIndex].Cells["FileCode"].Value.ToString();
            comment_Patient = DGV_Patient.Rows[e.RowIndex].Cells["address"].Value.ToString();

            TxtB_update.Text = name_Patient;

         }
        
        String date_visit, time_Visit, comment , type_sec;
        int id_visit;
        //private void DGV_visitTime_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    GroupB_Update.Text = "ویرایش وقت بیمار";

        //    checkformupdate = 2;
        //    id_visit = int.Parse( DGV_visitTime.Rows[e.RowIndex].Cells["id_visitTime"].Value.ToString());

        //    name_Patient = DGV_visitTime.Rows[e.RowIndex].Cells["name_patient"].Value.ToString();
        //    family_Patient = DGV_visitTime.Rows[e.RowIndex].Cells["famiy_patient"].Value.ToString();
        //    date_visit = DGV_visitTime.Rows[e.RowIndex].Cells["date_visit"].Value.ToString();
        //    time_Visit = DGV_visitTime.Rows[e.RowIndex].Cells["time_visit"].Value.ToString();
        //    comment = DGV_visitTime.Rows[e.RowIndex].Cells["comment_visit"].Value.ToString();
        //    type_sec = DGV_visitTime.Rows[e.RowIndex].Cells["sectionType"].Value.ToString();

        //    TxtB_update.Text = name_Patient;
        //}

        private void DGV_visitTime_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            GroupB_Update.Text = "ویرایش وقت بیمار";

            checkformupdate = 2;
            id_visit = int.Parse(DGV_visitTime.Rows[e.RowIndex].Cells["id_visitTime"].Value.ToString());

            name_Patient = DGV_visitTime.Rows[e.RowIndex].Cells["name_patient"].Value.ToString();
            family_Patient = DGV_visitTime.Rows[e.RowIndex].Cells["famiy_patient"].Value.ToString();
            date_visit = DGV_visitTime.Rows[e.RowIndex].Cells["visitTimeShamsi"].Value.ToString();
            time_Visit = DGV_visitTime.Rows[e.RowIndex].Cells["time_visit"].Value.ToString();
            comment = DGV_visitTime.Rows[e.RowIndex].Cells["comment_visit"].Value.ToString();
            type_sec = DGV_visitTime.Rows[e.RowIndex].Cells["sectionType"].Value.ToString();

            TxtB_update.Text = name_Patient;
        }
        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (TxtB_update.Text.Length == 0)
            {
                MessageBox.Show(C_String.msgtext(8));
            }
            else
            {
                if (checkformupdate == 1)
                {
                    frmUpdatePatient frm = new frmUpdatePatient();

                    C_Data.name = name_Patient;
                    C_Data.family = family_Patient;
                    C_Data.mobil = mobile_Patient;
                    C_Data.tell = tell_Patient;
                    C_Data.Ncood = NationalCode_Patient;
                    C_Data.addres = address_Patient;
                    C_Data.coment = comment_Patient;
                    C_Data.id = id_dgv_patient;

                    frm.f = this;

                    frm.ShowDialog();
                }
                else if (checkformupdate == 2)
                {
                    frmUpdateVisitTime frm = new frmUpdateVisitTime();

                    C_Data.name = name_Patient;
                    C_Data.family = family_Patient;
                    C_Data.date = date_visit;
                    C_Data.time = time_Visit;
                    C_Data.coment = comment;
                    C_Data.type_sec = type_sec;
                    C_Data.id = id_visit;

                    frm.f = this;
                    frm.ShowDialog();
                }
            }
        }

        private void txtB_mobil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Only Numbers 
            {
                e.Handled = true; 
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtB_Ncood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Only Numbers 
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtB_search_NC_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Only Numbers 
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain f = new FrmMain();
            f.Show();
        }

        private void btn_upHourse_Click(object sender, EventArgs e)
        {
            if (btn_downHourse.Enabled == false)
            {
                btn_downHourse.Enabled = true;
            }

            int hourse = int.Parse(txtB_time_Hourse.Text);

            hourse++;

            txtB_time_Hourse.Text = hourse.ToString();


            if (int.Parse(txtB_time_Hourse.Text) >= 24)
            {
                btn_upHourse.Enabled = false;
            }
        }
        private void txtB_time_Hourse_TextChanged(object sender, EventArgs e)
        {
            if (txtB_time_Hourse.Text.Length > 0)
            {
                if (int.Parse(txtB_time_Hourse.Text) >= 25 || int.Parse(txtB_time_Hourse.Text) <= 0)
                {
                    txtB_time_Hourse.Text = "12";
                }
                else
                {
                    if (btn_upHourse.Enabled == false)
                    {
                        btn_upHourse.Enabled = true;

                    }
                }
            }
        }

        private void btn_downHourse_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtB_time_Hourse.Text) < 0)
            {
                btn_downHourse.Enabled = false;
            }

            if (btn_upHourse.Enabled == false)
            {
                btn_upHourse.Enabled = true;
            }

            int hourse = int.Parse(txtB_time_Hourse.Text);

            hourse--;

            txtB_time_Hourse.Text = hourse.ToString();
        }

        private void btn_upMinute_Click(object sender, EventArgs e)
        {
            if (btn_downMinute.Enabled == false)
            {
                btn_downMinute.Enabled = true;
            }

            int minute = int.Parse(txtB_time_Minute.Text);

            minute++;

            txtB_time_Minute.Text = minute.ToString();


            if (int.Parse(txtB_time_Minute.Text) >= 60)
            {
                btn_upMinute.Enabled = false;
            }
        }

        private void btn_downMinute_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtB_time_Minute.Text) < 0)
            {
                btn_downMinute.Enabled = false;
            }

            if (btn_upMinute.Enabled == false)
            {
                btn_upMinute.Enabled = true;
            }

            int minute = int.Parse(txtB_time_Minute.Text);

            minute--;

            txtB_time_Minute.Text = minute.ToString();
        }

        private void txtB_time_Minute_TextChanged(object sender, EventArgs e)
        {
            if (txtB_time_Minute.Text.Length > 0)
            {
                if (int.Parse(txtB_time_Minute.Text) >= 61 || int.Parse(txtB_time_Minute.Text) <= 0)
                {
                    txtB_time_Minute.Text = "00";
                    //                p.Handled = false;
                }
                else
                {
                    if (btn_upMinute.Enabled == false)
                    {
                        btn_upMinute.Enabled = true;

                    }
                }
            }

        }

        private void txtB_time_Minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Only Numbers 
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void picB_showpanelCound_MouseEnter(object sender, EventArgs e)
        {
            panel_ShowCound.Visible = true;
            picB_ClousedpanelCound.Visible = true;
        }


        private void elContainer1_Click(object sender, EventArgs e)
        {
            picB_ClousedpanelCound.Visible = false;
            panel_ShowCound.Visible = false;
            GroupB_Show_report.Visible = false;
        }

        private void comB_sectionForCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comB_sectionForCount.SelectedValue.ToString());

            if (id == 0)
            {
                id = 1;
            }
            var count = db.SP_count(id).Single().ToString();

            lbl_Count.Text = count.ToString();
        }

        private void btn_Show_count_Click(object sender, EventArgs e)
        {
            if (TxtB_years.Text.Length == 0 && TxtB_month.Text.Length == 0)
            {
                MessageBox.Show(C_String.msgtext(1));
            }
            else
            {

                int pyear = Convert.ToInt32(13 + TxtB_years.Text);
                int pmonth = Convert.ToInt32(TxtB_month.Text);
                int pday = 31;
                if (pmonth >= 1 && pmonth <= 6) pday = 31;
                else if (pmonth >= 7 && pmonth <= 11) pday = 30;
                else if (pmonth == 12) pday = IsJalaliDateLeap(pyear, pmonth, 30) ? 30 : 29;

                DateTime jstartdate = JalaliToGregorean(pyear, pmonth, 1);
                DateTime jendtime = JalaliToGregorean(pyear, pmonth, pday);

                // چک کردن اینکه آیا کاربر تمایل دارد به گذارش گیری با نوع یا نه 
                if (CheckB_section.Checked == false)
                {
                    TxtB_show_visit.Text = db.Tbl_visitTime.Where(x => x.date >= jstartdate && x.date <= jendtime)
                        .Count().ToString();
                }
                //کاربر تمایل دارد به گزارش گیری با نوع
                else 
                {
                    int idsec=int.Parse(ComB_section_report.SelectedValue.ToString());

                    TxtB_show_visit.Text = db.Tbl_visitTime.Where(x => x.date >= jstartdate && x.date <=
                        jendtime && x.id_sec == idsec )
                 .Count().ToString();
                }
            }
        }


        // سال کبیسه 
        public static DateTime JalaliToGregorean(int pyear, int pmonth, int pday)
        {
            PersianCalendar pcal = new PersianCalendar();
            return pcal.ToDateTime(pyear, pmonth, pday, 0, 0, 0, 0);
        }
        public static bool IsJalaliDateLeap(int pyear, int pmonth, int pday)
        {
            try
            {
                PersianCalendar pcal = new PersianCalendar();
                pcal.ToDateTime(pyear, pmonth, pday, 0, 0, 0, 0);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void picB_show_panel_MouseEnter(object sender, EventArgs e)
        {
            GroupB_Show_report.Visible = true;
            CheckB_section.Checked = false;
            TxtB_years.Text = "96";
            TxtB_month.Text = (DateTime.Now.Month).ToString();

            ComB_section_report.DataSource = db.Tbl_section.ToList();
            ComB_section_report.DisplayMember = "sectionType";
            ComB_section_report.ValueMember = "ID";
        }

        private void btn_up_yers_Click(object sender, EventArgs e)
        {
            if (btn_down_years.Enabled == false)
            {
                btn_down_years.Enabled = true;
            }

            int years = int.Parse(TxtB_years.Text);

            years++;

            TxtB_years.Text = years.ToString();


            if (int.Parse(TxtB_years.Text) >= 99)
            {
                btn_up_yers.Enabled = false;
            }
        }

        private void btn_down_years_Click(object sender, EventArgs e)
        {
            if (int.Parse(TxtB_years.Text) < 95)
            {
                btn_down_years.Enabled = false;
            }

            if (btn_up_yers.Enabled == false)
            {
                btn_up_yers.Enabled = true;
            }

            int years = int.Parse(TxtB_years.Text);

            years--;

            TxtB_years.Text = years.ToString();
        }

        private void btn_up_month_Click(object sender, EventArgs e)
        {
            if (btn_down_month.Enabled == false)
            {
                btn_down_month.Enabled = true;
            }

            int month = int.Parse(TxtB_month.Text);

            month++;

            TxtB_month.Text = month.ToString();


            if (int.Parse(TxtB_month.Text) >= 12)
            {
                btn_up_month.Enabled = false;
            }
        }

        private void btn_down_month_Click(object sender, EventArgs e)
        {
            if (int.Parse(TxtB_month.Text) <= 2)
            {
                btn_down_month.Enabled = false;
            }

            if (btn_up_month.Enabled == false)
            {
                btn_up_month.Enabled = true;
            }

            int month = int.Parse(TxtB_month.Text);

            month--;

            TxtB_month.Text = month.ToString();

        }

        private void TxtB_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Only Numbers 
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void TxtB_month_TextChanged(object sender, EventArgs e)
        {
            if (TxtB_month.Text.Length > 0)
            {
                if (int.Parse(TxtB_month.Text) >= 13 || int.Parse(TxtB_month.Text) <= 0)
                {
                    TxtB_month.Text = "6";
                }
                else
                {
                    if (btn_up_month.Enabled == false)
                    {
                        btn_up_month.Enabled = true;

                    }
                }
            }
        }

        private void CheckB_section_Click(object sender, EventArgs e)
        {
            if (CheckB_section.Checked == false)
            {
                ComB_section_report.Enabled = true;
            }
            else
            {
                ComB_section_report.Enabled = false;
            }
        }
    }
}
