using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Entities.Billing;
using Microsoft.Reporting.WinForms;

namespace GYM_System
{
    public partial class FrmInvoiceViewer : Form
    {
        public FrmInvoiceViewer()
        {
            InitializeComponent();
        }

        //Properties
        public Bill Invoice { get; set; }

        //Methods
        private void LoadReport()
        {
            Invoice = Bill.GetByNumber(1)[0];
            
            rvInvoice.LocalReport.DataSources.Clear();

            rvInvoice.LocalReport.DataSources.Add(new ReportDataSource("Header", Invoice));

            rvInvoice.RefreshReport();
        }

        private void FrmInvoiceViewer_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.rvInvoice.RefreshReport();
        }
    }
}
