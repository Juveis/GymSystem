using System;
using System.IO;
using System.Windows.Forms;
using Core.Entities.Members;
using Core.Entities.Members;

namespace GYM_System
{
    public partial class FrmAssistance : Form
    {
        
        public FrmAssistance()
        {
            InitializeComponent();
        }

        private void LoadRecords()
        {
            var collection = AccesRegister.GetAccessHistory();

            foreach (var access in collection)
            {
                var customerList = Member.GetMembers("Membership", access.MembershipNumber.ToString());

                if (customerList.Count != 0)
                {
                    var customer = customerList[0];
                    
                    dgvAccess.Rows.Add(
                        customer.Id,
                        access.DateHour.ToShortTimeString(),
                        customer.Number,
                        customer.FirstName,
                        customer.FirstLastName,
                        access.Approved == true ? "Si" : "No"
                   );
                }

            }
        }

        private void InsertLastRecord()
        {
            var record = AccesRegister.GetLastRecord();

            if (record != null)
            {
                if (dgvAccess.Rows.Count != 0)
                {
                    var lastRecord = dgvAccess.Rows[dgvAccess.Rows.Count - 1].Cells["Membership"].Value.ToString();

                    if (lastRecord != record.MembershipNumber.ToString())
                    {
                        var custormer = Member.GetMembers("Membership", record.MembershipNumber.ToString())[0];

                        dgvAccess.Rows.Add(
                            custormer.Id,
                            record.DateHour.ToShortTimeString(),
                            custormer.Number,
                            custormer.FirstName,
                            custormer.FirstLastName,
                            record.Approved == true ? "Si" : "No"
                            );
                    }
                }
                else
                {
                    var custormer = Member.GetMembers("Membership", record.MembershipNumber.ToString())[0];

                    dgvAccess.Rows.Add(
                        custormer.Id,
                        record.DateHour.ToShortTimeString(),
                        custormer.Number,
                        custormer.FirstName,
                        custormer.FirstLastName,
                        record.Approved == true ? "Si" : "No"
                        );
                }
            }
        }

        private void LoadPhoto(Guid Id)
        {
            string strLocation = @"C:\Photos\" + Id + ".Jpeg";

            if (File.Exists(strLocation))
            {
                pbPhoto.ImageLocation = strLocation;
            }
            else
            {
                pbPhoto.Image = pbPhoto.InitialImage;
            }
        }
        
        private void FrmRegisterAccess_Load(object sender, EventArgs e)
        {
            LoadRecords();
            tGetRecord.Start();
        }

        private void tGetRecord_Tick(object sender, EventArgs e)
        {
            InsertLastRecord();
        }

        private void dgvAccess_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccess.Rows.Count != 0)
            {
                if (dgvAccess.SelectedRows.Count != 0)
                {
                    var id = (Guid)dgvAccess.SelectedRows[0].Cells["ID"].Value;

                    LoadPhoto(id);
                }
            }
        }
    }
}
