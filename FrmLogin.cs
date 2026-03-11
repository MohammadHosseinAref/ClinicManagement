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
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ComB_typeLogin.DataSource = db.Tbl_typeLogin.ToList();

            ComB_typeLogin.ValueMember = "ID";

            ComB_typeLogin.DisplayMember = "typeLogin";


            // lock

            string s = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE", "Clinic", "").ToString();
            if (s != "1234")
            {
                lbl_lock.Visible = true;

                int x = Convert.ToInt32(Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE", "count", "-999").ToString());
                if (x == -999)
                {
                    Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE", "count", "2");
                }
                else if (x > 0)
                    Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE", "count", --x);
                else
                {
                    Btn_Login.Enabled = false;
                    btn_regestery.Visible = true;

                    lbl_lock.Visible = false;
                }
                  //  Frm_Registery f1 = new Frm_Registery();
                    //f1.ShowDialog();
                lbl_lock.Text = x.ToString()+"\n"+" بار میتوانید  به صورت رایگان از برنامه استفاده کنید " ;
            }

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            String select = ComB_typeLogin.SelectedValue.ToString();
            int checkselect = int.Parse(select);
            if (checkselect == 1)
            {
                if (TxtB_Username.Text == "admin" && TxtB_Password.Text == "admin")
                {
                    //this.Hide();
                    this.Close();
                    FrmMain f = new FrmMain();
                    f.Show();
                }
                else
                {
                    Lbl_error.Visible = true;

                    Lbl_error.Text = C_String.msgtext(14);
                }
            }
            else if(checkselect == 2)
            {
                //byte[] b = System.Text.Encoding.UTF8.GetBytes(TxtB_Password.Text);

                //System.Security.Cryptography.SHA1 h = System.Security.Cryptography.SHA1.Create();

                //byte[] hashed = h.ComputeHash(b);

                //string i = Convert.ToBase64String(hashed);
                ////-------------------------
                //String i2 = hashed.ToString();

                var i = FrmSetting.hashing(TxtB_Password.Text);
                var q = from o in db.Tbl_Doctore where o.userName == TxtB_Username.Text && o.password == i select o;


                if (q.Count() == 1) //(username == TxtB_Username.Text && password == TxtB_Password.Text )//
                {
                    var queryid = db.Tbl_Doctore.Where(u => u.userName == TxtB_Username.Text).Select(u => u.ID).Single();

                    var queryname = db.Tbl_Doctore.Where(u => u.userName == TxtB_Username.Text).Select(u => u.name).Single();

                    int id_Doc_Login = queryid;

                    C_Data.idDocLogin = id_Doc_Login;

                    C_Data.name = queryname.ToString();

                    C_Data.username = TxtB_Username.Text;

                    C_Data.password = TxtB_Password.Text;

                    this.Close();

                    C_Data.check_rol = 1;
                    FrmMain f1 = new FrmMain();
                    f1.Show();
                }
                else
                {
                    Lbl_error.Visible = true;
                    Lbl_error.Text = C_String.msgtext(14);
                }
            }else{

                MessageBox.Show("no user");
            }
        }

        private void TxtB_Username_TextChanged(object sender, EventArgs e)
        {
            if(Lbl_error.Visible)
            {
                Lbl_error.Visible = false;
            }
        }

        private void linkLbl_forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Forget f = new Frm_Forget();
            f.ShowDialog();
        }

        private void pic_EyesCloused_MouseEnter(object sender, EventArgs e)
        {
            TxtB_Password.PasswordChar = '\0';

            pic_EyesCloused.Visible = false;
            pic_EyesOpens.Visible = true;
        }

        private void FrmLogin_MouseEnter(object sender, EventArgs e)
        {
            TxtB_Password.PasswordChar = '*';
            pic_EyesOpens.Visible = false;
            pic_EyesCloused.Visible = true;
        }

        private void btn_regestery_Click(object sender, EventArgs e)
        {
            Frm_Trial f = new Frm_Trial();
            f.ShowDialog();
        }
    }
}
