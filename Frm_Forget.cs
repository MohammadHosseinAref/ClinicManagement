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
    public partial class Frm_Forget : MetroForm
    {
        public Frm_Forget()
        {
            InitializeComponent();
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();
        private void Frm_Forget_Load(object sender, EventArgs e)
        {
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            var q = from o in db.Tbl_Doctore where o.userName == TxtB_username.Text && o.phone == TxtB_phone.Text select o;

            if (q.Count() == 1)
            {
                Btn_sendPass.Enabled = true;
            }
        }

        private void Btn_sendPass_Click(object sender, EventArgs e)
        {
            try
            {

                var q = db.Tbl_Doctore.Where(u => u.userName == TxtB_username.Text && u.phone == TxtB_phone.Text).Select(u => u.cood_D).Single();

                var query_update = db.Tbl_Doctore.ToList().Find(x => x.userName == TxtB_username.Text && x.phone == TxtB_phone.Text);

                query_update.password = FrmSetting.hashing(q);

                int i = db.SaveChanges();

                if (i == 1)
                {
                    MessageBox.Show(C_String.msgtext(26));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(C_String.msgtext(23));
                }
        
            }
            catch (Exception)
            {
                MessageBox.Show(C_String.msgtext(23));
            }


        }
    }
}
