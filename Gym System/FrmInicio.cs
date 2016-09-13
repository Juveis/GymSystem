using System;
using System.Windows.Forms;
using Core;
using Core.Entidades;
using Core.Entidades.Seguridad;
using Core.Entities;
using Core.Entities.Members;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmInicio : Form
    {
        //Propiedades
        public FrmLogin Login { get; set; }
        public FrmUsers Usuarios { get; set; }
        public FrmMember _Customer { get; set; }
        public FrmMembershipTypecs Membership { get; set; }
        public FrmPaymentHistory PaymentHistory { get; set; }
        public FrmEmployee Employee { get; set; }
        public FrmSearchCustomer SearchCustomer { get; set; }
        public FrmSearchEmployee SearchEmployee { get; set; }
        public FrmAssistance Assistance { get; set; }
        public FrmCategory Category { get; set; }
        public FrmInventory Inventory { get; set; }
        public FrmBilling Billing { get; set; }
        public FrmSearchBill SearchBill { get; set; }
        public FrmCustomerGenerateReports CustomerReports { get; set; }
        public FrmReconcile Reconcile { get; set; }
        public FrmReportAccessRegister ReportAccessRegister { get; set; }
        public FrmEmployeeLogs EmployeeLogs { get; set; }
        public FrmAccountsReceivable Accounts { get; set; }


        //Constructor
        public FrmInicio()
        {
            string conn = "mongodb://juveis:123456@ds063899.mongolab.com:063899/mongozionsystem";
            Initializer.InitializeMongoDb(conn);
            InitializeComponent();
        }

        //Metodos
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            //VALIDATE USER
            ValidarUsuario();

            //LOAD COUNTRIES
            LoadCountries();
        }
       

        private void ValidarUsuario()
        {
            Login = new FrmLogin();

            Login.ShowDialog();

            //If athenticated enable modules
            if (Login.DialogResult == DialogResult.OK)
            {
                foreach (var modulo in Usuario.CurrentUser.Modules)
                {
                    switch (modulo.Nombre)
                    {
                        case "Clientes" :
                            tsmCustomer.Visible = modulo.Activo;
                            break;

                        case "Administración":
                            tsmAdministration.Visible = modulo.Activo;
                            break;

                        case "Seguridad" :
                            tsmSecurity.Visible = modulo.Activo;
                            break;

                        case "Facturación":
                            tsmBilling.Visible = modulo.Activo;
                            break;

                        case "Inventario":
                            tsmInventory.Visible = modulo.Activo;
                            break;

                        default :
                            MessageBox.Show("Error con los modulos del usuario");
                            break;
                    }
                }

                LoadBirthDays();
            }
            else
            {
                Login.Dispose();
                Close();
            }
        }

        
        private void LoadCountries()
        {
            Country.GetCountries();
        }

        private void LoadBirthDays()
        {
            var members = Member.GetTodaysBirthdays();

            foreach (var member in members)
            {
                dgvBirthDays.Rows.Add(member.Number, member.FirstName,
                                      member.FirstLastName);
            }
        }

        //Acciones Menu
        private void tsmiUsuario_Click(object sender, EventArgs e)
        {
            Usuarios = new FrmUsers();
            Usuarios.ShowDialog();
            Usuarios.Dispose();
        }

        private void tsmiCustomer_Click(object sender, EventArgs e)
        {
            _Customer = new FrmMember();
            _Customer.ShowDialog();
            _Customer.Dispose();
        }

        private void tsmiMembership_Click(object sender, EventArgs e)
        {
            Membership = new FrmMembershipTypecs();
            Membership.ShowDialog();
            Membership.Dispose();
        }

        private void tsmiPay_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiPaymentsHistory_Click(object sender, EventArgs e)
        {
            PaymentHistory = new FrmPaymentHistory();
            PaymentHistory.ShowDialog();
            PaymentHistory.Dispose();
        }

        private void tsmiEmpleados_Click(object sender, EventArgs e)
        {
            Employee = new FrmEmployee();
            Employee.ShowDialog();
            Employee.Dispose();
        }

        private void tsmiSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomer = new FrmSearchCustomer();
            SearchCustomer.ShowDialog();
            SearchCustomer.Dispose();
        }

        private void tsmiSearchEmployee_Click(object sender, EventArgs e)
        {
            SearchEmployee = new FrmSearchEmployee();
            SearchEmployee.ShowDialog();
            SearchEmployee.Dispose();
        }

        private void tsmiAssistances_Click(object sender, EventArgs e)
        {
            Assistance = new FrmAssistance();
            Assistance.Show();
        }

        private void tsmiAddMembershipTime_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiCategory_Click(object sender, EventArgs e)
        {
            Category = new FrmCategory();
            Category.ShowDialog();
            Category.Dispose();
        }

        private void tsmiInventario_Click(object sender, EventArgs e)
        {
            Inventory = new FrmInventory();
            Inventory.ShowDialog();
            Inventory.Dispose();
        }

        private void tsmiBill_Click(object sender, EventArgs e)
        {
            Billing = new FrmBilling();
            Billing.ShowDialog();
            Billing.Dispose();
        }

        private void tsmiSearchBill_Click(object sender, EventArgs e)
        {
            SearchBill = new FrmSearchBill();
            SearchBill.ShowDialog();
            SearchBill.Dispose();
        }

        private void tsmiReconcile_Click(object sender, EventArgs e)
        {
            Reconcile = new FrmReconcile();
            Reconcile.ShowDialog();
            Reconcile.Dispose();
        }

        private void tsmiAsistance_Click(object sender, EventArgs e)
        {
            ReportAccessRegister = new FrmReportAccessRegister();
            ReportAccessRegister.ShowDialog();
            ReportAccessRegister.Dispose();
        }

        private void tsmiMembershipType_Click(object sender, EventArgs e)
        {
            CustomerReports = new FrmCustomerGenerateReports();
            CustomerReports.ShowDialog();
            CustomerReports.Dispose();
        }

        private void tsmiEmployeeLogs_Click(object sender, EventArgs e)
        {
            EmployeeLogs = new FrmEmployeeLogs();
            EmployeeLogs.ShowDialog();
            EmployeeLogs.Dispose();
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var invoice = new FrmInvoiceViewer();
            invoice.Show();
        }

        private void tsmiAccountsReceivable_Click(object sender, EventArgs e)
        {
            Accounts = new FrmAccountsReceivable();
            Accounts.ShowDialog();
            Accounts.Dispose();
        }
    }
}
