using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Entidades.Billing;
using Core.Entities.Billing;

namespace GYM_System
{
    public partial class FrmReconcile : Form
    {
        //Constructor Class
        public FrmReconcile()
        {
            InitializeComponent();

            lblNumberValue.Text = Reconcile.GetNextNumber().ToString("000000");
        }

        //Properties
        public Reconcile ReconcileProp { get; set; }


        //Private Methods
        private void GenerateReconcile()
        {
            var start = dtpStartDate.Value;
            var end = dtpEndDate.Value;

            ReconcileProp = Reconcile.GenerateReconcile(start, end);

            if (ReconcileProp == null)
            {
                MessageBox.Show("No hay ventas registrada para el rango de fecha seleccionado");
                return;
            }
            else
            {
                var wait = new FrmDialogCalculate();

                wait.Show();

                Application.DoEvents();

                
                //Show values
                lblBillsFromValue.Text = ReconcileProp.BillsFrom.ToString("0000000");
                lblBillsUntilValue.Text = ReconcileProp.BillsUntil.ToString("0000000");

                lblVoidedBillsValue.Text = ReconcileProp.VoidedBills.ToString("000");

                lblTotalCardValue.Text = ReconcileProp.Card.ToString("C");
                lblNumberCardValue.Text = ReconcileProp.NumberOfSalesCards.ToString();

                lblTotalCashValue.Text = ReconcileProp.Cash.ToString("C");
                lblNumberCashValue.Text = ReconcileProp.NumberOfSalesCash.ToString();

                lblTotalCreditValue.Text = ReconcileProp.Credit.ToString("C");
                lblNumberCreditValue.Text = ReconcileProp.NumberOfSalesCredit.ToString();

                lblTotalCheckValue.Text = ReconcileProp.Check.ToString("C");
                lblNumberCheckValue.Text = ReconcileProp.NumberOfSalesCheck.ToString();

                lblTotalPaymentValue.Text = ReconcileProp.TotalPayments.ToString("C");

                lblTotalSoldAmountValue.Text = ReconcileProp.TotalSoldAmount.ToString("C");

                dgvSalesByUsers.DataSource = ReconcileProp._SalesByUsers;

                dgvSalesByUsers.Columns["Total"].DefaultCellStyle.Format = "c";

                wait.Close();
                wait.Dispose();
            }
        }

        private void SaveAndPrint()
        {
            if (ReconcileProp != null)
            {
                ReconcileProp.Number = Reconcile.GetNextNumber();
                
                ReconcileProp.Save();

                MessageBox.Show(@"Cuadre guardado", @"Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var report = new FrmReportReconcile();

                report._Reconcile = ReconcileProp;

                report.Show();
            }
        }


        //Control Methods
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenerateReconcile();
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            SaveAndPrint();
        }
    }
}
