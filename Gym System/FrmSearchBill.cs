using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Entidades;
using Core.Entities.Billing;
using Core.Entidades.Seguridad;
using Core.Entities;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmSearchBill : Form
    {
        public FrmSearchBill()
        {
            InitializeComponent();

            //Show current user
            lblUser.Text = Usuario.CurrentUser.UserName;
        }

        //Properties
        public List<Bill> Bills { get; set; }
        public Bill _Bill { get; set; }
        
        //Private Methods
        private void LoadBills()
        {
            var number = txtNumber.Text.Trim();

            if (string.IsNullOrEmpty(number))
            {
                var start = dtpStartDate.Value.Date;
                var end = dtpEndDate.Value.Date;

                Bills = Bill.GetByDate(start, end);
            }
            else
            {
                Bills = Bill.GetByNumber(int.Parse(number));
            }

            dgvBills.DataSource = Bills;

            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            //Invisible Columns
            dgvBills.Columns["Membersip"].Visible = false;
            dgvBills.Columns["Address"].Visible = false;
            dgvBills.Columns["Phone"].Visible = false;
            dgvBills.Columns["CashRegister"].Visible = false;
            dgvBills.Columns["DocumentNumber"].Visible = false;
            dgvBills.Columns["ReceivedPay"].Visible = false;
            dgvBills.Columns["Change"].Visible = false;
            dgvBills.Columns["ITBIS"].Visible = false;
            dgvBills.Columns["SubTotal"].Visible = false;
            //dgvBills.Columns["Details"].Visible = false;
            dgvBills.Columns["UserId"].Visible = false;
            dgvBills.Columns["RegisterDate"].Visible = false;
            dgvBills.Columns["Id"].Visible = false;


            //Set Header Text
            dgvBills.Columns["Number"].HeaderText = "Número";
            dgvBills.Columns["Customer"].HeaderText = "Cliente";
            dgvBills.Columns["NCF"].HeaderText = "NCF";
            dgvBills.Columns["PaymentMethod"].HeaderText = "Forma Pago";
            dgvBills.Columns["Total"].HeaderText = "Total";
            dgvBills.Columns["Condition"].HeaderText = "Condición";
            dgvBills.Columns["Employee"].HeaderText = "Empleado";
            dgvBills.Columns["BillDate"].HeaderText = "Fecha";
        }

        private void PrintBill()
        {
            if (Bills != null)
            {
                if (Bills.Count != 0 && dgvBills.SelectedRows.Count != 0)
                {
                    _Bill = Bills[dgvBills.SelectedRows[0].Index];

                    Prints.PrintBill(_Bill);
                }
            }
        }


        //Control Methods
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBills();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintBill();
        }

        
    }
}
