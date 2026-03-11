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
    public partial class Frm_Update_username_pass_Doc : MetroForm
    {
        public Frm_Update_username_pass_Doc()
        {
            InitializeComponent();
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();
        private void Frm_Update_username_pass_Doc_Load(object sender, EventArgs e)
        {
            TxtB_userName.Text = C_Data.username;

            TxtB_pass.Text = C_Data.password;
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var query_update = db.Tbl_Doctore.ToList().Find(x => x.ID == C_Data.idDocLogin);

                query_update.userName = TxtB_userName.Text;
                //-----------
                //byte[] b2 = System.Text.Encoding.UTF8.GetBytes(TxtB_pass.Text);

                //System.Security.Cryptography.SHA1 h2 = System.Security.Cryptography.SHA1.Create();

                //byte[] hashed2 = h2.ComputeHash(b2);

                query_update.password = FrmSetting.hashing(TxtB_pass.Text);
                    //hashed2.ToString();
                //-------------

                db.SaveChanges();

                C_Data.username = TxtB_userName.Text;
                C_Data.password = TxtB_pass.Text;
                this.Close();
            }catch(Exception er)
            {
                MessageBox.Show("ویرایش انجام نشد" + er.Message);
            }

        }
    }
}
