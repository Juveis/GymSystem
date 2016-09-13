using Core.Entities.Company;
using Core.Entities.Members;
using Core.Entities.Memberships;

namespace GYM_System
{
    partial class FrmCustomersViewMultipleReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MembershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvCustomers = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MembershipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataSource = typeof(Member);
            // 
            // CompanyInfoBindingSource
            // 
            this.CompanyInfoBindingSource.DataSource = typeof(CompanyInfo);
            // 
            // MembershipBindingSource
            // 
            this.MembershipBindingSource.DataSource = typeof(Membership);
            // 
            // rvCustomers
            // 
            this.rvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CustomerMultiple";
            reportDataSource1.Value = this.CustomerBindingSource;
            reportDataSource2.Name = "CompanyInfo";
            reportDataSource2.Value = this.CompanyInfoBindingSource;
            reportDataSource3.Name = "Membership";
            reportDataSource3.Value = this.MembershipBindingSource;
            this.rvCustomers.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCustomers.LocalReport.DataSources.Add(reportDataSource2);
            this.rvCustomers.LocalReport.DataSources.Add(reportDataSource3);
            this.rvCustomers.LocalReport.ReportEmbeddedResource = "Zion_System.RptCustomerMultipleReports.rdlc";
            this.rvCustomers.Location = new System.Drawing.Point(0, 0);
            this.rvCustomers.Name = "rvCustomers";
            this.rvCustomers.Size = new System.Drawing.Size(569, 509);
            this.rvCustomers.TabIndex = 0;
            // 
            // FrmCustomersViewMultipleReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 509);
            this.Controls.Add(this.rvCustomers);
            this.Name = "FrmCustomersViewMultipleReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Clientes";
            this.Load += new System.EventHandler(this.FrmCustomersMultipleReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MembershipBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCustomers;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private System.Windows.Forms.BindingSource CompanyInfoBindingSource;
        private System.Windows.Forms.BindingSource MembershipBindingSource;
    }
}