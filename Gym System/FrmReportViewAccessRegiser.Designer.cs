using Core.Entities.Members;

namespace GYM_System
{
    partial class FrmReportViewAccessRegiser
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
            this.AccesRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvAccessRegister = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AccesRegisterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccesRegisterBindingSource
            // 
            this.AccesRegisterBindingSource.DataSource = typeof(AccesRegister);
            // 
            // rvAccessRegister
            // 
            this.rvAccessRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AccessRegister";
            reportDataSource1.Value = this.AccesRegisterBindingSource;
            this.rvAccessRegister.LocalReport.DataSources.Add(reportDataSource1);
            this.rvAccessRegister.LocalReport.ReportEmbeddedResource = "Zion_System.RptAccessRegister.rdlc";
            this.rvAccessRegister.Location = new System.Drawing.Point(0, 0);
            this.rvAccessRegister.Name = "rvAccessRegister";
            this.rvAccessRegister.Size = new System.Drawing.Size(924, 590);
            this.rvAccessRegister.TabIndex = 0;
            // 
            // FrmReportViewAccessRegiser
            // 
            this.ClientSize = new System.Drawing.Size(924, 590);
            this.Controls.Add(this.rvAccessRegister);
            this.Name = "FrmReportViewAccessRegiser";
            this.Text = "Vista Reporte Acceso";
            this.Load += new System.EventHandler(this.FrmReportViewAccessRegiser_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.AccesRegisterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvAccessRegister;
        private System.Windows.Forms.BindingSource AccesRegisterBindingSource;

        
    }
}