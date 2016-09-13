using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Entities.Accounting;

namespace GYM_System
{
    public partial class FrmAccountsReceivable : Form
    {
        public FrmAccountsReceivable()
        {
            InitializeComponent();

            LoadAccountsReceivable();
        }

        //Properties
        public List<AccountsReceivable> Receivables { get; set; }


        //Private Methods
        private void LoadAccountsReceivable()
        {
            Receivables = AccountsReceivable.GetAll();

            dgvAccountsReceivable.DataSource = Receivables;

            //Format DataGrid
            dgvAccountsReceivable.Columns["Balance"].DefaultCellStyle.Format = "C";

            //Hide fields
            dgvAccountsReceivable.Columns["id"].Visible = false;
        }

        private void LoadAccountSatus()
        {
            var rowsCount = dgvAccountsReceivable.Rows.Count;
            var selectedCells = dgvAccountsReceivable.SelectedCells.Count;

            if (rowsCount != 0 && selectedCells != 0)
            {
                var index = dgvAccountsReceivable.SelectedCells[0].RowIndex;
                dgvAccountStatus.DataSource = Receivables[index].AccountStatuses;

                lblBalanceValue.Text = Receivables[index].Balance.ToString("C");

                //Format DataGrid
                dgvAccountStatus.Columns["Debit"].DefaultCellStyle.Format = "C";
                dgvAccountStatus.Columns["Credit"].DefaultCellStyle.Format = "C";
            }
        }



        //Controls methods
        private void cbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbPersonType.SelectedIndex != -1) && (cbPersonType.SelectedItem.ToString() != "Ambos"))
            {
                lblPersonTypeNumber.Visible = true;
                txtPersonTypeNumber.Visible = true;
                btnSearchPerson.Visible = true;
            }
            else
            {
                lblPersonTypeNumber.Visible = false;
                txtPersonTypeNumber.Visible = false;
                btnSearchPerson.Visible = false;
            }
        }

        private void dgvAccountsReceivable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadAccountSatus();
        }
    }
}
