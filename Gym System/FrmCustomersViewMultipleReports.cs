using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Entities.Company;
using Core.Entities.Members;
using Microsoft.Reporting.WinForms;

namespace GYM_System
{
    public partial class FrmCustomersViewMultipleReports : Form
    {
        public FrmCustomersViewMultipleReports()
        {
            InitializeComponent();
        }

        private void FrmCustomersMultipleReports_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        //Properties
        public List<MemberReport> Customers { get; set; }
        public CompanyInfo Company { get; set; }
        public string Title { get; set; }

        //Mthods
        private void LoadReport()
        {
            rvCustomers.LocalReport.DataSources.Clear();

            
            var parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("ParameterTitle", Title);

            rvCustomers.LocalReport.DataSources.Add(new ReportDataSource("CustomerReport", Customers));
            rvCustomers.LocalReport.DataSources.Add(new ReportDataSource("CompanyInfo", Company));

            rvCustomers.LocalReport.SetParameters(parameters);

            rvCustomers.RefreshReport();
        }
    }
}
