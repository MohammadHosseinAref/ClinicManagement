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
    public partial class FrmUpdateDoc : MetroForm
    {
        public FrmUpdateDoc()
        {
            InitializeComponent();
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();

        public void dataComboboxSec()
        {
            //set data source in com box section
            ComB_type.DataSource = "".ToList();
            ComB_type.DataSource = db.Tbl_section.ToList();
            ComB_type.DisplayMember = "sectionType";
            ComB_type.ValueMember = "ID";
        }

        private void FrmUpdateDoc_Load(object sender, EventArgs e)
        {
            dataComboboxSec();

            txtB_name_U.Text = C_Data.name;
            txtB_tell_U.Text = C_Data.tell;
            txtB_cood_U.Text = C_Data.Ncood;
            txtB_comment_U.Text = C_Data.coment;

            var querysearchimage = db.Tbl_Doctore.Find(C_Data.id).imageDoc;
            try
            {
                picB_update.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(querysearchimage));
            }
            catch
            {
                picB_update.Image = Properties.Resources.iconAdd;
            }
        }
        public FrmSetting f;

        private void Btn_update_doc_Click(object sender, EventArgs e)
        {
            var query_update = db.Tbl_Doctore.ToList().Find(x => x.ID == C_Data.id);

            //            String n = txtB_name_U.Text;
            query_update.name = txtB_name_U.Text;
            query_update.phone = txtB_tell_U.Text;
            query_update.cood_D = txtB_cood_U.Text;
            query_update.coment= txtB_comment_U.Text;
            query_update.ID_sec = int.Parse( ComB_type.SelectedValue.ToString() );
            try
            {
                query_update.imageDoc = System.IO.File.ReadAllBytes(openFileDialogUpdate.FileName);
            }
            catch
            {
            }

            db.SaveChanges();

            f.showData_Grid_Doc();

            this.Close();
        }

        private void Btn_Update_pic_Click(object sender, EventArgs e)
        {
            openFileDialogUpdate.Filter = "images|*.jpg;*.png;*.ico";
            if (openFileDialogUpdate.ShowDialog() == DialogResult.OK)
            {
                picB_update.ImageLocation = openFileDialogUpdate.FileName;
            }
        }
    }
}
