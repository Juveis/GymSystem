using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Entities.Members;
using Core.Entities.Members.Enums;
using MongoDB.Driver.Builders;

namespace GYM_System
{
    public partial class FrmCustomerGenerateReports : Form
    {
        public FrmCustomerGenerateReports()
        {
            InitializeComponent();

            LoadGender();
            LoadMembership();
            LoadStatus();
        }

        //Properties
        public List<Member> Customers { get; set; }


        //Private methods
        private void LoadMembership()
        {
            var membershipTypeList = MembershipType.GetAll();
            cbMembershipType.DataSource = membershipTypeList;

            cbMembershipType.DisplayMember = "Type";
            cbMembershipType.ValueMember = "Type";
        }

        private void LoadStatus()
        {
            var status = new[]
                {
                    new {Text = "Ambos", Value = "Ambos"},
                    new {Text = "Activo", Value = "true"},
                    new {Text = "Inactivo", Value = "false"}
                };

            cbStatus.DataSource = status;
            cbStatus.DisplayMember = "Text";
            cbStatus.ValueMember = "Value";
        }

        private void LoadGender()
        {
            var status = new[]
                {
                    new {Text = "Ambos", Value = ""},
                    new {Text = "Masculino", Value = "Masculino"},
                    new {Text = "Femenino", Value = "Femenino"}
                };

            cbGender.DataSource = status;
            cbGender.DisplayMember = "Text";
            cbGender.ValueMember = "Value";
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = Customers;

            FormatDataGridView();
        }

        private void ApplyCriteria()
        {
            var membership = cbMembershipType.SelectedValue.ToString();
            var status = cbStatus.SelectedValue.ToString();
            var gender = cbGender.SelectedValue.ToString();

            //Only by membership
            if (!string.IsNullOrEmpty(membership) && (status == "Ambos" && string.IsNullOrEmpty(gender)))
            {
                Customers = Member.GetMembers("Membership.Type", membership);
            }

            //Only by status
            else if (!string.IsNullOrEmpty(status) && (string.IsNullOrEmpty(membership) && string.IsNullOrEmpty(gender)))
            {
                Customers = Member.GetMembers("Membership.Status", status);
            }

            //Only by gender
            else if (!string.IsNullOrEmpty(gender) && (string.IsNullOrEmpty(membership) && string.IsNullOrEmpty(status)))
            {
                Customers = Member.GetMembers("Gender", gender);
            }

            //Only by membership and status
            else if ((!string.IsNullOrEmpty(membership) && (status != "Ambos" && string.IsNullOrEmpty(gender))))
            {
                var query = Query.And(
                Query.EQ("Membership.Type", membership),
                Query.EQ("Membership.Status", Convert.ToBoolean(status))
                );

                Customers = Member.GetMembers(query);
            }

            //Only by membership and gender
            else if ((!string.IsNullOrEmpty(membership) && !string.IsNullOrEmpty(gender)) && status == "Ambos")
            {
                var query = Query.And(
                Query.EQ("Membership.Type", membership),
                Query.EQ("Gender", gender)
                );

                Customers = Member.GetMembers(query);
            }

            //Only by gender and status
            else if ((!string.IsNullOrEmpty(gender) && status != "Ambos") && string.IsNullOrEmpty(membership))
            {
                var query = Query.And(
                Query.EQ("Gender", gender),
                Query.EQ("Membership.Status", Convert.ToBoolean(status))
                );

                Customers = Member.GetMembers(query);
            }

            ////by gender, membership and status
            else if (!string.IsNullOrEmpty(gender) && status != "Ambos" && !string.IsNullOrEmpty(membership))
            {
                var query = Query.And(
                Query.EQ("Membership.Type", membership),
                Query.EQ("Gender", gender),
                Query.EQ("Membership.Status", Convert.ToBoolean(status))
                );

                Customers = Member.GetMembers(query);
            }

            //All
            else
            {
                Customers = Member.GetAll();
            }

            LoadCustomers();
        }

        private void FormatDataGridView()
        {
            //Invisible fields
            dgvCustomers.Columns["Id"].Visible = false;
            dgvCustomers.Columns["UserId"].Visible = false;
            dgvCustomers.Columns["Country"].Visible = false;
            dgvCustomers.Columns["City"].Visible = false;
            dgvCustomers.Columns["Secction"].Visible = false;
            dgvCustomers.Columns["Street"].Visible = false;
            dgvCustomers.Columns["House"].Visible = false;

            //Header Text
            dgvCustomers.Columns["Membership"].HeaderText = "No.";
            dgvCustomers.Columns["FirstName"].HeaderText = "Primer Nombre";
            dgvCustomers.Columns["MiddleName"].HeaderText = "Segundo Nombre";
            dgvCustomers.Columns["FirstLastName"].HeaderText = "Primer Apellido";
            dgvCustomers.Columns["SecondLastName"].HeaderText = "Segundo Apellido";
            dgvCustomers.Columns["BirthDate"].HeaderText = "Cumpleaños";
            dgvCustomers.Columns["Gender"].HeaderText = "Género";
            dgvCustomers.Columns["CardPassport"].HeaderText = "Ced./Pas.";
            dgvCustomers.Columns["Nationality"].HeaderText = "Nacionalidad";
            dgvCustomers.Columns["Telehone"].HeaderText = "Teléfono";
            dgvCustomers.Columns["CellPhone"].HeaderText = "Celular";
            dgvCustomers.Columns["Email"].HeaderText = "Email";
            dgvCustomers.Columns["RegisterDate"].HeaderText = "Fecha Registro";

        }


        //Control's methods
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var viewMultipleReports = new FrmCustomersViewMultipleReports();
            viewMultipleReports.Customers = Member.Report(Customers);
            viewMultipleReports.Title = "Reporte de Clientes";
            viewMultipleReports.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyCriteria();
        }
    }
}
