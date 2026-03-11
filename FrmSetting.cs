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
    public partial class FrmSetting : MetroForm
    {
        public FrmSetting()
        {
            InitializeComponent();
        }

        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        public void dataComboboxSec()
        {
            //set data source in com box section
            ComB_type_doc.DataSource = "".ToList();
            ComB_type_doc.DataSource = db.Tbl_section.ToList();
            ComB_type_doc.DisplayMember = "sectionType";
            ComB_type_doc.ValueMember = "ID";
        }
        public void showData_Grid_Doc()
        {
            DGV_doc.DataSource = "";

            var Sort_Datagrid_p = db.SP_doctors().ToList().OrderByDescending(p => p.ID);
            DGV_doc.DataSource = Sort_Datagrid_p.ToList();
        }
        public void showData_Grid_sec()
        {
            DGV_sec.DataSource = "";

            var Sort_Datagrid_p = db.Tbl_section.ToList().OrderByDescending(p => p.ID);
            DGV_sec.DataSource = Sort_Datagrid_p.ToList();
        }
        private void clear_txt_doc()
        {
            TxtB_name_doc.Clear();

            TxtB_num_doc.Clear();

            TxtB_cood_doc.Clear();

            TxtB_comment_doc.Clear();
        }
        private void clear_txt_sec()
        {
            TxtB_name_sec.Clear();
        }
        private void FrmSetting_Load(object sender, EventArgs e)
        {
            dataComboboxSec();
            //-----------------------------

            DGV_sec.ColumnCount = 2;
            DGV_sec.AutoGenerateColumns = false;

            DGV_sec.Columns[0].Name = "ID";
            DGV_sec.Columns[0].DataPropertyName = "ID";
            DGV_sec.Columns[0].HeaderText = "کد";
            DGV_sec.Columns[0].Width = 40;

            DGV_sec.Columns[1].Name = "sectionType";
            DGV_sec.Columns[1].DataPropertyName = "sectionType";
            DGV_sec.Columns[1].HeaderText = "نام";
            DGV_sec.Columns[1].Width = 100;

            DataGridViewCheckBoxColumn DGV_checkbox = new DataGridViewCheckBoxColumn();
            DGV_checkbox.DataPropertyName = "checkbox_sec";
            DGV_checkbox.Name = "checkbox_sec";
            DGV_checkbox.Width = 45;
            DGV_checkbox.HeaderText = "انتخاب";

            DGV_sec.Columns.Insert(2, DGV_checkbox);

            var Sort_Datagrid_p = db.Tbl_section.ToList().OrderByDescending(p => p.ID);
            DGV_sec.DataSource = Sort_Datagrid_p.ToList();
            //-------------------
            DGV_doc.ColumnCount = 6;
            DGV_doc.AutoGenerateColumns = false;

            DGV_doc.Columns[0].Name = "ID";
            DGV_doc.Columns[0].DataPropertyName = "ID";
            DGV_doc.Columns[0].HeaderText = "کد";
            DGV_doc.Columns[0].Width = 40;

            DGV_doc.Columns[1].Name = "name";
            DGV_doc.Columns[1].DataPropertyName = "name";
            DGV_doc.Columns[1].HeaderText = "نام";
            DGV_doc.Columns[1].Width = 80;

            DGV_doc.Columns[2].Name = "sectionType";
            DGV_doc.Columns[2].DataPropertyName = "sectionType";
            DGV_doc.Columns[2].HeaderText = "تخصص";
            DGV_doc.Columns[2].Width = 80;

            DGV_doc.Columns[3].Name = "phone";
            DGV_doc.Columns[3].DataPropertyName = "phone";
            DGV_doc.Columns[3].HeaderText = "شماره تماس";
            DGV_doc.Columns[3].Width = 90;


            DGV_doc.Columns[4].Name = "cood_D";
            DGV_doc.Columns[4].DataPropertyName = "cood_D";
            DGV_doc.Columns[4].HeaderText = "کد نظام پزشکی";
            DGV_doc.Columns[4].Width = 80;


            DGV_doc.Columns[5].Name = "coment";
            DGV_doc.Columns[5].DataPropertyName = "coment";
            DGV_doc.Columns[5].HeaderText = "توضیحات";
            DGV_doc.Columns[5].Width = 70;

            //DataGridViewCheckBoxColumn dch = new DataGridViewCheckBoxColumn();

            //dch.DataPropertyName = "ch";
            //DGV_doc.Columns.Insert(7, dch);


            DataGridViewCheckBoxColumn DGV_checkbox_doc = new DataGridViewCheckBoxColumn();
            DGV_checkbox_doc.DataPropertyName = "checkbox_doc";
            DGV_checkbox_doc.Name = "checkbox_doc";
            DGV_checkbox_doc.Width = 45;
            DGV_checkbox_doc.HeaderText = "انتخاب";

            DGV_doc.Columns.Insert(6, DGV_checkbox_doc);

//            var Sort_Datagrid_p = db.sp_view(2).ToList().OrderByDescending(p => p.pho);
//            DGV_doc.DataSource = Sort_Datagrid_p.ToList();

            var Sort_Datagrid_D = db.SP_doctors().ToList().OrderByDescending(p => p.ID);
            DGV_doc.DataSource = Sort_Datagrid_D.ToList();
        }

        private void Btn_save_doc_Click(object sender, EventArgs e)
        {
            if (TxtB_name_doc.Text.Length == 0 || TxtB_num_doc.Text.Length == 0 || TxtB_cood_doc.Text.Length == 0 ||
            TxtB_userName.Text.Length == 0 || TxtB_cood_doc.Text.Length == 0)
            {
                MessageBox.Show(C_String.msgtext(1), C_String.msgtext(7), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {

                Model.Tbl_Doctore newrow = new Model.Tbl_Doctore();
                try
                {

                    newrow.name = TxtB_name_doc.Text;

                    newrow.phone = TxtB_num_doc.Text;

                    newrow.cood_D = TxtB_cood_doc.Text;

                    newrow.ID_sec = int.Parse(ComB_type_doc.SelectedValue.ToString());

                    newrow.coment = TxtB_comment_doc.Text;
                    try
                    {
                        newrow.imageDoc = System.IO.File.ReadAllBytes(openFileDialogChosePic.FileName);
                    }
                    catch
                    {
                        MessageBox.Show(C_String.msgtext(15));
                        BtnChosePicDoc_Click(null, null);
                    }
                    newrow.userName = TxtB_name_doc.Text;

                    //byte[] b2 = System.Text.Encoding.UTF8.GetBytes(TxtB_cood_doc.Text);

                    //System.Security.Cryptography.SHA1 h2 = System.Security.Cryptography.SHA1.Create();

                    //byte[] hashed2 = h2.ComputeHash(b2);

                    //newrow.password = hashed2.ToString();

                    newrow.password = hashing(TxtB_cood_doc.Text);

                    db.Tbl_Doctore.Add(newrow);

                    int i = db.SaveChanges();
                    if (i == 0)
                    {
                        MessageBox.Show("عملیات ناموفق");
                    }
                    showData_Grid_Doc();

                    pictureBox1.Image = Properties.Resources.iconAdd;

                    clear_txt_doc();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
        public static String hashing(String a)
        {
            byte[] b = System.Text.Encoding.UTF8.GetBytes(a);

            System.Security.Cryptography.SHA1 h = System.Security.Cryptography.SHA1.Create();

            byte[] hashed = h.ComputeHash(b);

            String p = Convert.ToBase64String(hashed);

            return p;
        }

        private void Btn_save_sec_Click(object sender, EventArgs e)
        {
            if (TxtB_name_sec.Text.Length == 0)
            {
                MessageBox.Show(C_String.msgtext(4));
            }
            else
            {
                Model.Tbl_section newrow = new Model.Tbl_section();

                newrow.sectionType = TxtB_name_sec.Text;

                db.Tbl_section.Add(newrow);

                db.SaveChanges();

                showData_Grid_sec();

                dataComboboxSec();

                clear_txt_sec();
            }
        }

        private void Btn_delet_Doc_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in DGV_doc.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean
                                                  (row.Cells["checkbox_doc"].Value) == true
                                                  select row).ToList();
            var ids = selectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();

            var r = db.Tbl_Doctore.Where(x => ids.Contains(x.ID));// records of sql table based on ids'
            int c = r.Count();

            if (c == 0)
            {
                MessageBox.Show(C_String.msgtext(8), C_String.msgtext(7));
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show(C_String.msgtext(5) + c.ToString() + C_String.msgtext(6), C_String.msgtext(7), MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var items in r)
                        {
                            db.Tbl_Doctore.Remove(items);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                    db.SaveChanges();

                    showData_Grid_Doc();
                }catch(Exception )
                {
                    MessageBox.Show(C_String.msgtext(13));
                }
            }
        }

        private void Btn_delet_sec_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in DGV_sec.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean
                                                  (row.Cells["checkbox_sec"].Value) == true
                                                  select row).ToList();
            var ids = selectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();

            var r = db.Tbl_section.Where(x => ids.Contains(x.ID));// records of sql table based on ids'
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
                    foreach (var items in r)
                    {
                        db.Tbl_section.Remove(items);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }

                db.SaveChanges();

                showData_Grid_sec();

            }
        }

        private void radioB_Doctors_CheckedChanged(object sender, EventArgs e)
        {
            groupB_Register_doc.Enabled = true;

            groupB_Register_sec.Enabled = false;
        }

        private void radioB_type_CheckedChanged(object sender, EventArgs e)
        {
            groupB_Register_doc.Enabled = false;

            groupB_Register_sec.Enabled = true;
        }
        int id_dgv, checkformupdate;
        String name, tell,Coode,comment;
        private void DGV_doc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            groupB_Update.Text = "ویرایش دکتر";
            id_dgv= (int)DGV_doc.Rows[e.RowIndex].Cells["ID"].Value;

            checkformupdate = 1;

            name = DGV_doc.Rows[e.RowIndex].Cells["name"].Value.ToString();
            tell = DGV_doc.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            Coode = DGV_doc.Rows[e.RowIndex].Cells["cood_D"].Value.ToString();
            comment = DGV_doc.Rows[e.RowIndex].Cells["coment"].Value.ToString();

            TxtB_update.Text = name;
        }

        private void DGV_sec_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            groupB_Update.Text = "ویرایش نوع";
            id_dgv = (int)DGV_sec.Rows[e.RowIndex].Cells["ID"].Value;

            checkformupdate = 2;

            name = DGV_sec.Rows[e.RowIndex].Cells["sectionType"].Value.ToString();

            TxtB_update.Text = name;
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if(checkformupdate == 1)
            {
                C_Data.id = id_dgv;
                C_Data.name = name;
                C_Data.tell = tell;
                C_Data.Ncood = Coode;
                C_Data.coment = comment;

                FrmUpdateDoc frm = new FrmUpdateDoc();

                frm.f = this;

                frm.ShowDialog();
            }
            else if (checkformupdate == 2)
            {
                C_Data.id = id_dgv;
                C_Data.name = name;

                FrmUpdateSection frm = new FrmUpdateSection();
                frm.f = this;

                frm.ShowDialog();
            }
        }

        private void TSM_back_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain f = new FrmMain();
            f.Show();
        }

        private void TSM_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtB_cood_doc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DGV_sec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtB_name_doc_TextChanged(object sender, EventArgs e)
        {
            TxtB_userName.Text = TxtB_name_doc.Text;
        }

        private void TxtB_userName_TextChanged(object sender, EventArgs e)
        {
            var q = from o in db.Tbl_Doctore where o.userName == TxtB_userName.Text select o;

            if (TxtB_userName.Text == "")
            {
                lbl_Error.Visible = false;
            }

            if (q.Count() == 1)
            {
                lbl_Error.Visible = true;

                Btn_save_doc.Enabled = false;
            }
            else
            {
                Btn_save_doc.Enabled = true;
            }

        }

        private void BtnChosePicDoc_Click(object sender, EventArgs e)
        {
            openFileDialogChosePic.Filter = "images|*.jpg;*.png;*.ico";
            if (openFileDialogChosePic.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialogChosePic.FileName;
            }
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain f = new FrmMain();
            f.Show();
        }

        private void TxtB_cood_doc_TextChanged(object sender, EventArgs e)
        {
            var q = from o in db.Tbl_Doctore where o.cood_D == TxtB_cood_doc.Text select o;

            if (TxtB_cood_doc.Text == "")
            {
                lbl_error_code.Visible = false;
            }

            if (q.Count() == 1)
            {
                lbl_error_code.Text = "کد نظام پزشکی قبلا در سیستم ثبت شده است";
                lbl_error_code.Visible = true;

                Btn_save_doc.Enabled = false;
            }
            else
            {
                Btn_save_doc.Enabled = true;
            }

        }
    }
}
