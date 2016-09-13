using Core.Entities.Billing;

namespace GYM_System
{
    partial class FrmInvoiceViewer
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
            this.BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BillBindingSource
            // 
            this.BillBindingSource.DataSource = typeof(Core.Entities.Billing.Bill);
            // 
            // BillDetailBindingSource
            // 
            this.BillDetailBindingSource.DataSource = typeof(BillDetail);
            // 
            // rvInvoice
            // 
            this.rvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Header";
            reportDataSource1.Value = this.BillBindingSource;
            reportDataSource2.Name = "Details";
            reportDataSource2.Value = this.BillDetailBindingSource;
            this.rvInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.rvInvoice.LocalReport.DataSources.Add(reportDataSource2);
            this.rvInvoice.LocalReport.ReportEmbeddedResource = "Zion_System.RptInvoice.rdlc";
            this.rvInvoice.Location = new System.Drawing.Point(0, 0);
            this.rvInvoice.Name = "rvInvoice";
            this.rvInvoice.Size = new System.Drawing.Size(685, 590);
            this.rvInvoice.TabIndex = 0;
            // 
            // FrmInvoiceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 590);
            this.Controls.Add(this.rvInvoice);
            this.Name = "FrmInvoiceViewer";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmInvoiceViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BillBindingSource;
        private System.Windows.Forms.BindingSource BillDetailBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rvInvoice;
    }
}