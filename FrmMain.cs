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
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();

            this.ShowInTaskbar = true;
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if(C_Data.check_rol ==1) // doctor login
            {
                btn_setting.Visible = false;

                btn_Menue_Add.Visible = false;

                btn_search.Visible = false;

                btn_Report.Visible = false;

                Btn_sent.Visible = false;

                btn_chooseBakup.Visible = false;

                Btn_showVisit.Visible = true;

                Btn_Update_UserName_pass.Visible = true;

                Btn_Update_UserName_pass.Location = new Point(393, 99);

                Btn_showVisit.Location = new Point( 74, 99);

                picB_Doc.Location = new Point(863, 99);

                var querysearchimage = db.Tbl_Doctore.Find(C_Data.idDocLogin).imageDoc;
                try
                {
                    picB_Doc.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(querysearchimage));
                }
                catch
                {
                    picB_Doc.Image = Properties.Resources.iconAdd;
                }
            }
        }

        private void FrmMain_MouseEnter(object sender, EventArgs e)
        {
            
            flowLayoutPanel_Add.Visible = false;

        }

        private void btn_Menue_Add_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel_Add.Visible = true;
        }

        private void btn_add_pat_visit_Click(object sender, EventArgs e)
        {

            this.Close();
            FrmReception f = new FrmReception();
            f.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSetting frmS = new FrmSetting();
            frmS.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Frm_Search f = new Frm_Search();
            f.ShowDialog();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            Frm_About f = new Frm_About();
            f.ShowDialog();
        }

        private void Btn_showVisit_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_show_visit_Doc f = new Frm_show_visit_Doc();
            f.Show();
        }

        private void Btn_Update_UserName_pass_Click(object sender, EventArgs e)
        {
            Frm_Update_username_pass_Doc f = new Frm_Update_username_pass_Doc();
            f.ShowDialog();
        }

        private void picB_Doc_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picB_Doc , C_Data.username);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmReport fr = new FrmReport();

            fr.Show();


        }

        private void btn_chooseBakup_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_getBackup_patients fr = new Frm_getBackup_patients();

            fr.ShowDialog();
        }

        private void btn_startAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_splash_screen f = new frm_splash_screen();
            f.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_sent_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Sent f = new Frm_Sent();
            f.Show();
        }
    }
}
