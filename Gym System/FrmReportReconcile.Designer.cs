using Core.Entities.Billing;

namespace GYM_System
{
    partial class FrmReportReconcile
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
            this.rvReconcile = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReconcileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesByUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReconcileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesByUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvReconcile
            // 
            this.rvReconcile.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Reconcile";
            reportDataSource1.Value = this.ReconcileBindingSource;
            this.rvReconcile.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReconcile.LocalReport.ReportEmbeddedResource = "Zion_System.RptReconcile.rdlc";
            this.rvReconcile.Location = new System.Drawing.Point(0, 0);
            this.rvReconcile.Name = "rvReconcile";
            this.rvReconcile.Size = new System.Drawing.Size(565, 461);
            this.rvReconcile.TabIndex = 0;
            // 
            // ReconcileBindingSource
            // 
            this.ReconcileBindingSource.DataSource = typeof(Reconcile);
            // 
            // SalesByUsersBindingSource
            // 
            this.SalesByUsersBindingSource.DataSource = typeof(SalesByUsers);
            // 
            // FrmReportReconcile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 461);
            this.Controls.Add(this.rvReconcile);
            this.Name = "FrmReportReconcile";
            this.Text = "Reporte Cuadre de Caja";
            this.Load += new System.EventHandler(this.FrmReportReconcile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReconcileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesByUsersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReconcile;
        private System.Windows.Forms.BindingSource ReconcileBindingSource;
        private System.Windows.Forms.BindingSource SalesByUsersBindingSource;
    }
}