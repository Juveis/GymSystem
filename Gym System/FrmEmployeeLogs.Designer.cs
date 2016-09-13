namespace GYM_System
{
    partial class FrmEmployeeLogs
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbGenerate = new System.Windows.Forms.GroupBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.txtEmployeeNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPersonTypeNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.gbEmployeeLogs = new System.Windows.Forms.GroupBox();
            this.dgvEmployeeLogs = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.EmployeeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGenerate.SuspendLayout();
            this.gbEmployeeLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(183, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Registros De Entradas";
            // 
            // gbGenerate
            // 
            this.gbGenerate.Controls.Add(this.btnSearchEmployee);
            this.gbGenerate.Controls.Add(this.txtEmployeeNumber);
            this.gbGenerate.Controls.Add(this.lblPersonTypeNumber);
            this.gbGenerate.Controls.Add(this.btnSearch);
            this.gbGenerate.Controls.Add(this.lblStartDate);
            this.gbGenerate.Controls.Add(this.lblEndDate);
            this.gbGenerate.Controls.Add(this.dtpEndDate);
            this.gbGenerate.Controls.Add(this.dtpStartDate);
            this.gbGenerate.Location = new System.Drawing.Point(12, 80);
            this.gbGenerate.Name = "gbGenerate";
            this.gbGenerate.Size = new System.Drawing.Size(428, 81);
            this.gbGenerate.TabIndex = 45;
            this.gbGenerate.TabStop = false;
            this.gbGenerate.Text = "Filtros:";
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearchEmployee.Location = new System.Drawing.Point(381, 8);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(40, 23);
            this.btnSearchEmployee.TabIndex = 48;
            this.btnSearchEmployee.Text = "***";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(306, 11);
            this.txtEmployeeNumber.Mask = "00000";
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.PromptChar = ' ';
            this.txtEmployeeNumber.ReadOnly = true;
            this.txtEmployeeNumber.Size = new System.Drawing.Size(69, 20);
            this.txtEmployeeNumber.TabIndex = 47;
            // 
            // lblPersonTypeNumber
            // 
            this.lblPersonTypeNumber.AutoSize = true;
            this.lblPersonTypeNumber.Location = new System.Drawing.Point(253, 14);
            this.lblPersonTypeNumber.Name = "lblPersonTypeNumber";
            this.lblPersonTypeNumber.Size = new System.Drawing.Size(47, 13);
            this.lblPersonTypeNumber.TabIndex = 46;
            this.lblPersonTypeNumber.Text = "Número:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Location = new System.Drawing.Point(256, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 29);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(6, 20);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(35, 13);
            this.lblStartDate.TabIndex = 36;
            this.lblStartDate.Text = "Inicio:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 48);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(24, 13);
            this.lblEndDate.TabIndex = 38;
            this.lblEndDate.Text = "Fin:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(47, 42);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 37;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(47, 14);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 35;
            // 
            // gbEmployeeLogs
            // 
            this.gbEmployeeLogs.Controls.Add(this.dgvEmployeeLogs);
            this.gbEmployeeLogs.Location = new System.Drawing.Point(12, 185);
            this.gbEmployeeLogs.Name = "gbEmployeeLogs";
            this.gbEmployeeLogs.Size = new System.Drawing.Size(693, 261);
            this.gbEmployeeLogs.TabIndex = 46;
            this.gbEmployeeLogs.TabStop = false;
            this.gbEmployeeLogs.Text = "Registros:";
            // 
            // dgvEmployeeLogs
            // 
            this.dgvEmployeeLogs.AllowUserToAddRows = false;
            this.dgvEmployeeLogs.AllowUserToDeleteRows = false;
            this.dgvEmployeeLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeNumber,
            this.FirstName,
            this.LastName,
            this.CheckIn,
            this.CheckOut});
            this.dgvEmployeeLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeLogs.Location = new System.Drawing.Point(3, 16);
            this.dgvEmployeeLogs.Name = "dgvEmployeeLogs";
            this.dgvEmployeeLogs.ReadOnly = true;
            this.dgvEmployeeLogs.Size = new System.Drawing.Size(687, 242);
            this.dgvEmployeeLogs.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(73, 475);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 16);
            this.lblUser.TabIndex = 48;
            this.lblUser.Text = "*******";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(9, 475);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 16);
            this.lblUserName.TabIndex = 47;
            this.lblUserName.Text = "Usuario:";
            // 
            // EmployeeNumber
            // 
            this.EmployeeNumber.HeaderText = "Número";
            this.EmployeeNumber.Name = "EmployeeNumber";
            this.EmployeeNumber.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Nombre";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Apellido";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // CheckIn
            // 
            this.CheckIn.HeaderText = "Entrada";
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            this.CheckOut.HeaderText = "Salida";
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.ReadOnly = true;
            // 
            // FrmEmployeeLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(752, 504);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.gbEmployeeLogs);
            this.Controls.Add(this.gbGenerate);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEmployeeLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de Entradas";
            this.gbGenerate.ResumeLayout(false);
            this.gbGenerate.PerformLayout();
            this.gbEmployeeLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbGenerate;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.MaskedTextBox txtEmployeeNumber;
        private System.Windows.Forms.Label lblPersonTypeNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox gbEmployeeLogs;
        private System.Windows.Forms.DataGridView dgvEmployeeLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserName;
    }
}