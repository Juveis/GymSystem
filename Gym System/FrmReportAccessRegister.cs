using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Entities.Members;

namespace GYM_System
{
    public partial class FrmReportAccessRegister : Form
    {
        public FrmReportAccessRegister()
        {
            InitializeComponent();

            cbApproved.SelectedIndex = 0;
        }

        //Properties
        public List<AccesRegister> Access { get; set; }

        //Methods
        private void LoadAccessRegister()
        {
            var start = dtpStartDate.Value;
            var end = dtpEndDate.Value;

            if (cbApproved.SelectedItem.ToString() == "Ambos")
            {
                Access = AccesRegister.GetByDate(start, end);
            }
            else
            {
                var approved = cbApproved.SelectedItem.ToString() == "Si" ? true : false;

                Access = AccesRegister.GetByDate(start, end, approved);
            }

            //Set the data source
            dgvAccess.DataSource = Access;

            //Format DataGridView
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            //Header Text
            dgvAccess.Columns["MembershipNumber"].HeaderText = "No.";
            dgvAccess.Columns["DateHour"].HeaderText = "Fecha/Hora";
            dgvAccess.Columns["FirstName"].HeaderText = "Nombre";
            dgvAccess.Columns["LastName"].HeaderText = "Apellido";
            dgvAccess.Columns["Approved"].HeaderText = "Aprovado";

            //Invisible fields
            dgvAccess.Columns["Id"].Visible = false;
        }

        private void ShowReport()
        {
            if (Access != null)
            {
                var viewRwport = new FrmReportViewAccessRegiser();
                viewRwport.Access = Access;

                viewRwport.Show();
            }
        }


        //Control methods
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAccessRegister();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ShowReport();
        }
    }
}
