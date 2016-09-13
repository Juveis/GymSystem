namespace GYM_System
{
    partial class FrmInicio
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
            this.msMenuInicio = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAssistances = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddMembershipTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomerReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportSection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMembershipType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAsistance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReconcile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccountsReceivable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaymentsHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchBill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvBirthDays = new System.Windows.Forms.DataGridView();
            this.MembershipNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBirthDays = new System.Windows.Forms.GroupBox();
            this.msMenuInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirthDays)).BeginInit();
            this.gbBirthDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuInicio
            // 
            this.msMenuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmCustomer,
            this.tsmSecurity,
            this.tsmAdministration,
            this.tsmBilling,
            this.tsmInventory,
            this.testToolStripMenuItem});
            this.msMenuInicio.Location = new System.Drawing.Point(0, 0);
            this.msMenuInicio.Name = "msMenuInicio";
            this.msMenuInicio.Size = new System.Drawing.Size(1162, 24);
            this.msMenuInicio.TabIndex = 1;
            this.msMenuInicio.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(60, 20);
            this.tsmFile.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // tsmCustomer
            // 
            this.tsmCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomer,
            this.tsmiSearchCustomer,
            this.tsmiAssistances,
            this.tsmiAddMembershipTime,
            this.tsmiCustomerReports,
            this.tsmiReportSection});
            this.tsmCustomer.Name = "tsmCustomer";
            this.tsmCustomer.Size = new System.Drawing.Size(61, 20);
            this.tsmCustomer.Text = "Clientes";
            this.tsmCustomer.Visible = false;
            // 
            // tsmiCustomer
            // 
            this.tsmiCustomer.Name = "tsmiCustomer";
            this.tsmiCustomer.Size = new System.Drawing.Size(222, 22);
            this.tsmiCustomer.Text = "Clientes";
            this.tsmiCustomer.Click += new System.EventHandler(this.tsmiCustomer_Click);
            // 
            // tsmiSearchCustomer
            // 
            this.tsmiSearchCustomer.Name = "tsmiSearchCustomer";
            this.tsmiSearchCustomer.Size = new System.Drawing.Size(222, 22);
            this.tsmiSearchCustomer.Text = "Buscar Clientes";
            this.tsmiSearchCustomer.Click += new System.EventHandler(this.tsmiSearchCustomer_Click);
            // 
            // tsmiAssistances
            // 
            this.tsmiAssistances.Name = "tsmiAssistances";
            this.tsmiAssistances.Size = new System.Drawing.Size(222, 22);
            this.tsmiAssistances.Text = "Asistencia del día";
            this.tsmiAssistances.Click += new System.EventHandler(this.tsmiAssistances_Click);
            // 
            // tsmiAddMembershipTime
            // 
            this.tsmiAddMembershipTime.Name = "tsmiAddMembershipTime";
            this.tsmiAddMembershipTime.Size = new System.Drawing.Size(222, 22);
            this.tsmiAddMembershipTime.Text = "Agregar Tiempo Membresía";
            this.tsmiAddMembershipTime.Click += new System.EventHandler(this.tsmiAddMembershipTime_Click);
            // 
            // tsmiCustomerReports
            // 
            this.tsmiCustomerReports.Name = "tsmiCustomerReports";
            this.tsmiCustomerReports.Size = new System.Drawing.Size(222, 22);
            this.tsmiCustomerReports.Text = "Reportes";
            // 
            // tsmiReportSection
            // 
            this.tsmiReportSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMembershipType,
            this.tsmiAsistance});
            this.tsmiReportSection.Name = "tsmiReportSection";
            this.tsmiReportSection.Size = new System.Drawing.Size(222, 22);
            this.tsmiReportSection.Text = "Sección de Reportes";
            // 
            // tsmiMembershipType
            // 
            this.tsmiMembershipType.Name = "tsmiMembershipType";
            this.tsmiMembershipType.Size = new System.Drawing.Size(154, 22);
            this.tsmiMembershipType.Text = "Por Membresía";
            this.tsmiMembershipType.Click += new System.EventHandler(this.tsmiMembershipType_Click);
            // 
            // tsmiAsistance
            // 
            this.tsmiAsistance.Name = "tsmiAsistance";
            this.tsmiAsistance.Size = new System.Drawing.Size(154, 22);
            this.tsmiAsistance.Text = "Asistencia";
            this.tsmiAsistance.Click += new System.EventHandler(this.tsmiAsistance_Click);
            // 
            // tsmSecurity
            // 
            this.tsmSecurity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsuario});
            this.tsmSecurity.Name = "tsmSecurity";
            this.tsmSecurity.Size = new System.Drawing.Size(72, 20);
            this.tsmSecurity.Text = "Seguridad";
            this.tsmSecurity.Visible = false;
            // 
            // tsmiUsuario
            // 
            this.tsmiUsuario.Name = "tsmiUsuario";
            this.tsmiUsuario.Size = new System.Drawing.Size(114, 22);
            this.tsmiUsuario.Text = "Usuario";
            this.tsmiUsuario.Click += new System.EventHandler(this.tsmiUsuario_Click);
            // 
            // tsmAdministration
            // 
            this.tsmAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleados,
            this.tsmiSearchEmployee,
            this.tsmiReconcile,
            this.tsmiEmployeeLogs,
            this.tsmiAccountsReceivable});
            this.tsmAdministration.Name = "tsmAdministration";
            this.tsmAdministration.Size = new System.Drawing.Size(100, 20);
            this.tsmAdministration.Text = "Administración";
            this.tsmAdministration.Visible = false;
            // 
            // tsmiEmpleados
            // 
            this.tsmiEmpleados.Name = "tsmiEmpleados";
            this.tsmiEmpleados.Size = new System.Drawing.Size(209, 22);
            this.tsmiEmpleados.Text = "Empleados";
            this.tsmiEmpleados.Click += new System.EventHandler(this.tsmiEmpleados_Click);
            // 
            // tsmiSearchEmployee
            // 
            this.tsmiSearchEmployee.Name = "tsmiSearchEmployee";
            this.tsmiSearchEmployee.Size = new System.Drawing.Size(209, 22);
            this.tsmiSearchEmployee.Text = "Buscar Empleados";
            this.tsmiSearchEmployee.Click += new System.EventHandler(this.tsmiSearchEmployee_Click);
            // 
            // tsmiReconcile
            // 
            this.tsmiReconcile.Name = "tsmiReconcile";
            this.tsmiReconcile.Size = new System.Drawing.Size(209, 22);
            this.tsmiReconcile.Text = "Cuadre Caja";
            this.tsmiReconcile.Click += new System.EventHandler(this.tsmiReconcile_Click);
            // 
            // tsmiEmployeeLogs
            // 
            this.tsmiEmployeeLogs.Name = "tsmiEmployeeLogs";
            this.tsmiEmployeeLogs.Size = new System.Drawing.Size(209, 22);
            this.tsmiEmployeeLogs.Text = "Registros de Entradas";
            this.tsmiEmployeeLogs.Click += new System.EventHandler(this.tsmiEmployeeLogs_Click);
            // 
            // tsmiAccountsReceivable
            // 
            this.tsmiAccountsReceivable.Name = "tsmiAccountsReceivable";
            this.tsmiAccountsReceivable.Size = new System.Drawing.Size(209, 22);
            this.tsmiAccountsReceivable.Text = "Cuentas por Cobrar (CxC)";
            this.tsmiAccountsReceivable.Click += new System.EventHandler(this.tsmiAccountsReceivable_Click);
            // 
            // tsmBilling
            // 
            this.tsmBilling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMembership,
            this.tsmiPay,
            this.tsmiPaymentsHistory,
            this.tsmiBill,
            this.tsmiSearchBill});
            this.tsmBilling.Name = "tsmBilling";
            this.tsmBilling.Size = new System.Drawing.Size(81, 20);
            this.tsmBilling.Text = "Facturación";
            this.tsmBilling.Visible = false;
            // 
            // tsmiMembership
            // 
            this.tsmiMembership.Name = "tsmiMembership";
            this.tsmiMembership.Size = new System.Drawing.Size(164, 22);
            this.tsmiMembership.Text = "Membresía";
            this.tsmiMembership.Click += new System.EventHandler(this.tsmiMembership_Click);
            // 
            // tsmiPay
            // 
            this.tsmiPay.Name = "tsmiPay";
            this.tsmiPay.Size = new System.Drawing.Size(164, 22);
            this.tsmiPay.Text = "Pagos";
            this.tsmiPay.Click += new System.EventHandler(this.tsmiPay_Click);
            // 
            // tsmiPaymentsHistory
            // 
            this.tsmiPaymentsHistory.Name = "tsmiPaymentsHistory";
            this.tsmiPaymentsHistory.Size = new System.Drawing.Size(164, 22);
            this.tsmiPaymentsHistory.Text = "Historial de Pago";
            this.tsmiPaymentsHistory.Click += new System.EventHandler(this.tsmiPaymentsHistory_Click);
            // 
            // tsmiBill
            // 
            this.tsmiBill.Name = "tsmiBill";
            this.tsmiBill.Size = new System.Drawing.Size(164, 22);
            this.tsmiBill.Text = "Facturar";
            this.tsmiBill.Click += new System.EventHandler(this.tsmiBill_Click);
            // 
            // tsmiSearchBill
            // 
            this.tsmiSearchBill.Name = "tsmiSearchBill";
            this.tsmiSearchBill.Size = new System.Drawing.Size(164, 22);
            this.tsmiSearchBill.Text = "Buscar Factura";
            this.tsmiSearchBill.Click += new System.EventHandler(this.tsmiSearchBill_Click);
            // 
            // tsmInventory
            // 
            this.tsmInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCategory,
            this.tsmiInventario});
            this.tsmInventory.Name = "tsmInventory";
            this.tsmInventory.Size = new System.Drawing.Size(72, 20);
            this.tsmInventory.Text = "Inventario";
            this.tsmInventory.Visible = false;
            // 
            // tsmiCategory
            // 
            this.tsmiCategory.Name = "tsmiCategory";
            this.tsmiCategory.Size = new System.Drawing.Size(127, 22);
            this.tsmiCategory.Text = "Categoría";
            this.tsmiCategory.Click += new System.EventHandler(this.tsmiCategory_Click);
            // 
            // tsmiInventario
            // 
            this.tsmiInventario.Name = "tsmiInventario";
            this.tsmiInventario.Size = new System.Drawing.Size(127, 22);
            this.tsmiInventario.Text = "Inventario";
            this.tsmiInventario.Click += new System.EventHandler(this.tsmiInventario_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.testToolStripMenuItem1.Text = "test";
            this.testToolStripMenuItem1.Click += new System.EventHandler(this.testToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1162, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dgvBirthDays
            // 
            this.dgvBirthDays.AllowUserToAddRows = false;
            this.dgvBirthDays.AllowUserToDeleteRows = false;
            this.dgvBirthDays.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvBirthDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirthDays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MembershipNumber,
            this.CustomerName,
            this.CustomerLastName});
            this.dgvBirthDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBirthDays.Location = new System.Drawing.Point(3, 16);
            this.dgvBirthDays.Name = "dgvBirthDays";
            this.dgvBirthDays.ReadOnly = true;
            this.dgvBirthDays.Size = new System.Drawing.Size(380, 350);
            this.dgvBirthDays.TabIndex = 5;
            // 
            // MembershipNumber
            // 
            this.MembershipNumber.HeaderText = "Número";
            this.MembershipNumber.Name = "MembershipNumber";
            this.MembershipNumber.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Nombre";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.HeaderText = "Apellido";
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.ReadOnly = true;
            // 
            // gbBirthDays
            // 
            this.gbBirthDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBirthDays.BackColor = System.Drawing.Color.White;
            this.gbBirthDays.Controls.Add(this.dgvBirthDays);
            this.gbBirthDays.Location = new System.Drawing.Point(0, 221);
            this.gbBirthDays.Name = "gbBirthDays";
            this.gbBirthDays.Size = new System.Drawing.Size(386, 369);
            this.gbBirthDays.TabIndex = 6;
            this.gbBirthDays.TabStop = false;
            this.gbBirthDays.Text = "Cumpleañeros:";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 590);
            this.Controls.Add(this.gbBirthDays);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMenuInicio);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuInicio;
            this.Name = "FrmInicio";
            this.Text = "GYM System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.msMenuInicio.ResumeLayout(false);
            this.msMenuInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirthDays)).EndInit();
            this.gbBirthDays.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmSecurity;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministration;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomer;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmBilling;
        private System.Windows.Forms.ToolStripMenuItem tsmiPay;
        private System.Windows.Forms.ToolStripMenuItem tsmiMembership;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaymentsHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmInventory;
        private System.Windows.Forms.ToolStripMenuItem tsmiAssistances;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddMembershipTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiInventario;
        private System.Windows.Forms.ToolStripMenuItem tsmiBill;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchBill;
        private System.Windows.Forms.DataGridView dgvBirthDays;
        private System.Windows.Forms.GroupBox gbBirthDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.ToolStripMenuItem tsmiReconcile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomerReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportSection;
        private System.Windows.Forms.ToolStripMenuItem tsmiMembershipType;
        private System.Windows.Forms.ToolStripMenuItem tsmiAsistance;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeLogs;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountsReceivable;
    }
}