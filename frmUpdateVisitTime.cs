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
    public partial class frmUpdateVisitTime : MetroForm
    {
        public frmUpdateVisitTime()
        {
            InitializeComponent();
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();
        private void frmUpdateVisitTime_Load(object sender, EventArgs e)
        {

            var query_get_idsec = db.Tbl_section.Where(u => u.sectionType == C_Data.type_sec).Select(u => u.ID).Single();

            int id = query_get_idsec;

            comB_doctors_U.DataSource = db.SP_getname_doc(id, id).ToList();

            comB_doctors_U.DisplayMember = "name";
            comB_doctors_U.ValueMember = "id_doctore";

            TxtB_name_patient_U.Text = C_Data.name + " " + C_Data.family;

            string t = C_Data.time;

            Char h0 = t[0];
            Char h1 = t[1];

            Char h5 = t[5];
            char h6 = t[6];

            //txtB_oldDate.Text = C_Data.date;
            txtB_time_Minute.Text = h0 + "" + h1;
            txtB_time_Hourse.Text = h5 + "" + h6;
            TxtB_comment_U.Text = C_Data.coment;
        }
        public FrmReception f;
        private void Btn_update_Visit_Click(object sender, EventArgs e)
        {
            try
            {

                //String date ;
                if (PersianCalenderUpdate.Text.Length == 0)
                {
                    MessageBox.Show(C_String.msgtext(25));
                }
                else
                {

                    String ti = txtB_time_Minute.Text + " : " + txtB_time_Hourse.Text;

                    if (txtB_time_Minute.Text.Length == 1)
                    {
                        ti = "0" + txtB_time_Minute.Text + " : " + txtB_time_Hourse.Text;
                    }

                    if (txtB_time_Hourse.Text.Length != 2 || txtB_time_Minute.Text.Length != 2)
                    {
                        MessageBox.Show(C_String.msgtext(24));
                    }
                    else
                    {
                        var query_update = db.Tbl_visitTime.ToList().Find(x => x.ID == C_Data.id);
                        query_update.id_doc = int.Parse(comB_doctors_U.SelectedValue.ToString());
                        query_update.time = ti;
                        query_update.date = Convert.ToDateTime(PersianCalenderUpdate.Miladi);
                        query_update.comment = TxtB_comment_U.Text;

                        db.SaveChanges();

                        f.refresh_visitTime();

                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(C_String.msgtext(23));
            }
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

        private void txtB_time_Hourse_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
