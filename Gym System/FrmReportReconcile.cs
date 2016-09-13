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
using Microsoft.Reporting.WinForms;

namespace GYM_System
{
    public partial class FrmReportReconcile : Form
    {
        public FrmReportReconcile()
        {
            InitializeComponent();
        }

        //Properties
        public Reconcile _Reconcile { get; set; }
        

        //Methods
        private void LoadReport()
        {
            if (_Reconcile != null)
            {
                rvReconcile.LocalReport.DataSources.Clear();

                var list = new List<Reconcile>();

                list.Add(_Reconcile);

                var source = new ReportDataSource("Reconcile", list);

                rvReconcile.LocalReport.DataSources.Add(source);
                rvReconcile.LocalReport.DataSources.Add(new ReportDataSource("SalesByUsers", _Reconcile._SalesByUsers));

                rvReconcile.RefreshReport();

                rvReconcile.PrintDialog();
            }
        }

        private void FrmReportReconcile_Load(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
