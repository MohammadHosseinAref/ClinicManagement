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
using System.Messaging;

namespace myClinic
{
    public partial class Frm_Sent : MetroForm
    {
        public Frm_Sent()
        {
            InitializeComponent();
        }

        MessageQueue qMain;
        MessageQueue qAdmininstration;
        void aAdministration_RecieveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            System.Messaging.Message ack = e.Message;
            ack.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            MessageBox.Show(
                string.Format("زمان  ارسال" + "\n" + "{0}" + "\n" +
                "زمان دریافت" + "\n" + "{1}" + "\n" +
                "وضعیت ارسال" + "\n" + "{2}" + "\n" /*+
                ",{2},Arr:{3} .Arr Qeue: {4} , Rec:{5}",*/ ,
                ack.ArrivedTime.ToShortTimeString(), ack.SentTime.ToShortTimeString(),
                ack.Acknowledgment
                /*, ack.Acknowledgment, ack.ArrivedTime.ToShortTimeString(),
               change(ack.SenderId), ack.SentTime */), "داده ها ارسال شد");
            // ack.Id = id sener
            // ack.CorrelationId =
            //ack.ArrivedTime.ToShortTimeString() = time sent
            // change(ack.SenderId)= id 
            //ack.SentTime = 
        }

        private string change(byte[] p)
        {
            string s = "";
            foreach (var item in p)
            {
                s += string.Format("{0:x}", item);
            }
            return s;
        }
        Model.DB_myClinicEntities4 db = new Model.DB_myClinicEntities4();
        private void Frm_Sent_Load(object sender, EventArgs e)
        {
            ComB_type.DisplayMember = "sectionType";
            ComB_type.ValueMember = "ID";
            ComB_type.DataSource = db.Tbl_section.ToList();


        }
        public void showData_visitTime(int id_sect)
        {
            dgv.DataSource = "";

            var Sort_Datagrid_p = db.SP_sent(id_sect).ToList().OrderByDescending(p => p.id_visitTime);

            dgv.DataSource = Sort_Datagrid_p.ToList();
        }

        private void ComB_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            int id = int.Parse(ComB_type.SelectedValue.ToString());

            dgv.ColumnCount = 13;
            dgv.AutoGenerateColumns = false;

            dgv.Columns[0].Name = "FileCode";
            dgv.Columns[0].DataPropertyName = "FileCode";
            dgv.Columns[0].HeaderText = "شماره پرونده بیمار";
            dgv.Columns[0].Width = 40;

            dgv.Columns[1].Name = "famiy_patient";
            dgv.Columns[1].DataPropertyName = "famiy_patient";
            dgv.Columns[1].HeaderText = "نام  خانوادگی بیمار";
            dgv.Columns[1].Width = 80;


            dgv.Columns[2].Name = "name_patient";
            dgv.Columns[2].DataPropertyName = "name_patient";
            dgv.Columns[2].HeaderText = "نام بیمار";
            dgv.Columns[2].Width = 80;


            dgv.Columns[3].Name = "NationalCode";
            dgv.Columns[3].DataPropertyName = "NationalCode";
            dgv.Columns[3].HeaderText = "کد ملی بیمار";
            dgv.Columns[3].Width = 50;

            dgv.Columns[4].Name = "mobile";
            dgv.Columns[4].DataPropertyName = "mobile";
            dgv.Columns[4].HeaderText = "شماره تماس بیمار";
            dgv.Columns[4].Width = 60;

            dgv.Columns[5].Name = "name_doctors";
            dgv.Columns[5].DataPropertyName = "name_doctors";
            dgv.Columns[5].HeaderText = "نام دکتر";
            dgv.Columns[5].Width = 80;

            dgv.Columns[6].Name = "cood_doc";
            dgv.Columns[6].DataPropertyName = "cood_doc";
            dgv.Columns[6].HeaderText = "کد دکتر";
            dgv.Columns[6].Width = 50;

            dgv.Columns[7].Name = "sectionType";
            dgv.Columns[7].DataPropertyName = "sectionType";
            dgv.Columns[7].HeaderText = "تخصص دکتر";
            dgv.Columns[7].Width = 80;

            dgv.Columns[8].Name = "visitTimeShamsi";
            dgv.Columns[8].DataPropertyName = "visitTimeShamsi";
            dgv.Columns[8].HeaderText = "تاریخ ویزیت";
            dgv.Columns[8].Width = 70;

            dgv.Columns[9].Name = "time_visit";
            dgv.Columns[9].DataPropertyName = "time_visit";
            dgv.Columns[9].HeaderText = "ساعت ویزیت";
            dgv.Columns[9].Width = 70;

            dgv.Columns[10].Name = "comment_visit";
            dgv.Columns[10].DataPropertyName = "comment_visit";
            dgv.Columns[10].HeaderText = "توضیحات";
            dgv.Columns[10].Width = 90;


            dgv.Columns[11].Name = "id_visitTime";
            dgv.Columns[11].DataPropertyName = "id_visitTime";
            dgv.Columns[11].HeaderText = "کد";
            dgv.Columns[11].Width = 40;

            dgv.Columns[12].Name = "date_visit";
            dgv.Columns[12].DataPropertyName = "date_visit";
            dgv.Columns[12].HeaderText = "تاریخ میلادی";
            dgv.Columns[12].Width = 70;

            DataGridViewCheckBoxColumn DGV_checkbox_visit = new DataGridViewCheckBoxColumn();
            DGV_checkbox_visit.DataPropertyName = "checkboxcolumn";
            DGV_checkbox_visit.Name = "checkboxcolumn";
            DGV_checkbox_visit.Width = 43;
            DGV_checkbox_visit.HeaderText = "انتخاب";

            dgv.Columns.Insert(13, DGV_checkbox_visit);


            showData_visitTime(id);

            if (!MessageQueue.Exists(".\\Private$\\Main"))
            {
                qMain = MessageQueue.Create(".\\Private$\\Main");

            }
            else
            {
                qMain = new MessageQueue(".\\Private$\\Main");
            }


            if (!MessageQueue.Exists(".\\Private$\\Acknowledge"))
                qAdmininstration = MessageQueue.Create(".\\Private$\\Acknowledge");
            else
            {
                qAdmininstration = new MessageQueue(".\\Private$\\Acknowledge");
            }

            qAdmininstration.MessageReadPropertyFilter.CorrelationId = true;
            qAdmininstration.MessageReadPropertyFilter.Acknowledgment = true;
            qAdmininstration.MessageReadPropertyFilter.TimeToBeReceived = true;
            qAdmininstration.MessageReadPropertyFilter.TimeToReachQueue = true;
            qAdmininstration.MessageReadPropertyFilter.ArrivedTime = true;
            qAdmininstration.MessageReadPropertyFilter.SenderId = true;
            qAdmininstration.MessageReadPropertyFilter.SentTime = true;

            //qAdmininstration.ReceiveCompleted += aAdministration_RecieveCompleted; // Event Calling
            //qAdmininstration.BeginReceive();

        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain f = new FrmMain();
            f.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in dgv.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean
                                                  (row.Cells["checkboxcolumn"].Value) == true

                                                  select row).ToList();
            foreach (var item in selectedRows)
            {
                item.DefaultCellStyle.BackColor = Color.Yellow;
                item.DefaultCellStyle.ForeColor = Color.Gray;
                item.ReadOnly = true;

            }


            foreach (var item in selectedRows)
            {
                item.Cells["checkBoxColumn"].Value = false;
            }
            try
            {
                qAdmininstration.ReceiveCompleted += aAdministration_RecieveCompleted; // Event Calling
                qAdmininstration.BeginReceive();

                var ids = selectedRows.Select(x => (int)x.Cells["id_visitTime"].Value).ToList();
                //            Model.DB_DentalClinic_ShokriEntities db = new Model.DB_DentalClinic_ShokriEntities();



                var r = db.Tbl_patieont.Where(x => ids.Contains(x.ID)).ToList();



                System.Messaging.Message msg = new System.Messaging.Message();

                var data = Newtonsoft.Json.JsonConvert.SerializeObject(r);
                msg.Body = data;
                msg.Label = "پیام";
                msg.AdministrationQueue = qAdmininstration;
                msg.AcknowledgeType = AcknowledgeTypes.PositiveArrival | AcknowledgeTypes.PositiveReceive;
                msg.AcknowledgeType = AcknowledgeTypes.FullReachQueue | AcknowledgeTypes.FullReceive;
                msg.TimeToBeReceived = new TimeSpan(1, 0, 0, 1);
                msg.TimeToReachQueue = new TimeSpan(1, 0, 0, 1);
                qMain.Send(msg);
            }
            catch (Exception)
            {
                MessageBox.Show(C_String.msgtext(23));
            }

        }

        private void btn_get_data_Click(object sender, EventArgs e)
        {
            if (!MessageQueue.Exists(".\\Private$\\Main"))
            {
                qMain = MessageQueue.Create(".\\Private$\\Main");

            }
            else
            {
                qMain = new MessageQueue(".\\Private$\\Main");
            }


            if (!MessageQueue.Exists(".\\Private$\\Acknowledge"))
                qAdmininstration = MessageQueue.Create(".\\Private$\\Acknowledge");
            else
            {
                qAdmininstration = new MessageQueue(".\\Private$\\Acknowledge");
            }

            qAdmininstration.MessageReadPropertyFilter.CorrelationId = true;
            qAdmininstration.MessageReadPropertyFilter.Acknowledgment = true;
            qAdmininstration.MessageReadPropertyFilter.TimeToBeReceived = true;
            qAdmininstration.MessageReadPropertyFilter.TimeToReachQueue = true;
            qAdmininstration.MessageReadPropertyFilter.ArrivedTime = true;
            qAdmininstration.MessageReadPropertyFilter.SenderId = true;
            qAdmininstration.MessageReadPropertyFilter.SentTime = true;

            qAdmininstration.ReceiveCompleted += aAdministration_RecieveCompleted; // Event Calling
            qAdmininstration.BeginReceive();
        }
    }
}
