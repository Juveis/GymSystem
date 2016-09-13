using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Entities.Members;
using Microsoft.Reporting.WinForms;

namespace GYM_System
{
    public partial class FrmReportViewAccessRegiser : Form
    {
        public FrmReportViewAccessRegiser()
        {
            InitializeComponent();
        }

        public List<AccesRegister> Access { get; set; }


        //Methods
        private void LoadReport()
        {
            rvAccessRegister.LocalReport.DataSources.Clear();

            rvAccessRegister.LocalReport.DataSources.Add(new ReportDataSource("AccessRegister", Access));

            rvAccessRegister.RefreshReport();

            rvAccessRegister.PrintDialog();
        }

        private void FrmReportViewAccessRegiser_Load_1(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
