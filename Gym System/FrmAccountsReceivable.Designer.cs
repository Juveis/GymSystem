namespace GYM_System
{
    partial class FrmAccountsReceivable
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
            this.tcAccountsReceivable = new System.Windows.Forms.TabControl();
            this.tpDebitPaymentsCredit = new System.Windows.Forms.TabPage();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.gbGenerate = new System.Windows.Forms.GroupBox();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.txtPersonTypeNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPersonTypeNumber = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbDocType = new System.Windows.Forms.ComboBox();
            this.lblDocType = new System.Windows.Forms.Label();
            this.cbPersonType = new System.Windows.Forms.ComboBox();
            this.lblPersonType = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.gbAccountsReceivable = new System.Windows.Forms.GroupBox();
            this.dgvAccountsReceivable = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvAccountStatus = new System.Windows.Forms.DataGridView();
            this.tcAccountsReceivable.SuspendLayout();
            this.tpDebitPaymentsCredit.SuspendLayout();
            this.gbGenerate.SuspendLayout();
            this.gbAccountsReceivable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountsReceivable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(234, -4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(322, 45);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cuentas por Cobrar";
            // 
            // tcAccountsReceivable
            // 
            this.tcAccountsReceivable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAccountsReceivable.Controls.Add(this.tpDebitPaymentsCredit);
            this.tcAccountsReceivable.Location = new System.Drawing.Point(12, 84);
            this.tcAccountsReceivable.Name = "tcAccountsReceivable";
            this.tcAccountsReceivable.SelectedIndex = 0;
            this.tcAccountsReceivable.Size = new System.Drawing.Size(766, 456);
            this.tcAccountsReceivable.TabIndex = 7;
            // 
            // tpDebitPaymentsCredit
            // 
            this.tpDebitPaymentsCredit.Controls.Add(this.lblBalanceValue);
            this.tpDebitPaymentsCredit.Controls.Add(this.lblBalance);
            this.tpDebitPaymentsCredit.Controls.Add(this.btnDelete);
            this.tpDebitPaymentsCredit.Controls.Add(this.btnPrint);
            this.tpDebitPaymentsCredit.Controls.Add(this.btnDebit);
            this.tpDebitPaymentsCredit.Controls.Add(this.btnPayments);
            this.tpDebitPaymentsCredit.Controls.Add(this.gbGenerate);
            this.tpDebitPaymentsCredit.Controls.Add(this.gbAccountsReceivable);
            this.tpDebitPaymentsCredit.Location = new System.Drawing.Point(4, 22);
            this.tpDebitPaymentsCredit.Name = "tpDebitPaymentsCredit";
            this.tpDebitPaymentsCredit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDebitPaymentsCredit.Size = new System.Drawing.Size(758, 430);
            this.tpDebitPaymentsCredit.TabIndex = 0;
            this.tpDebitPaymentsCredit.Text = "Débito, Pago y Crédito";
            this.tpDebitPaymentsCredit.UseVisualStyleBackColor = true;
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceValue.Location = new System.Drawing.Point(459, 101);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(64, 20);
            this.lblBalanceValue.TabIndex = 55;
            this.lblBalanceValue.Text = "000.00";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(375, 101);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(79, 20);
            this.lblBalance.TabIndex = 53;
            this.lblBalance.Text = "Balance:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDelete.Location = new System.Drawing.Point(243, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 29);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnPrint.Location = new System.Drawing.Point(165, 98);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(72, 29);
            this.btnPrint.TabIndex = 51;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnDebit
            // 
            this.btnDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDebit.FlatAppearance.BorderSize = 0;
            this.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDebit.Location = new System.Drawing.Point(87, 98);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(72, 29);
            this.btnDebit.TabIndex = 50;
            this.btnDebit.Text = "Débito";
            this.btnDebit.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnPayments.Location = new System.Drawing.Point(9, 98);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(72, 29);
            this.btnPayments.TabIndex = 48;
            this.btnPayments.Text = "Pagos";
            this.btnPayments.UseVisualStyleBackColor = false;
            // 
            // gbGenerate
            // 
            this.gbGenerate.Controls.Add(this.btnSearchPerson);
            this.gbGenerate.Controls.Add(this.txtPersonTypeNumber);
            this.gbGenerate.Controls.Add(this.lblPersonTypeNumber);
            this.gbGenerate.Controls.Add(this.cbStatus);
            this.gbGenerate.Controls.Add(this.lblStatus);
            this.gbGenerate.Controls.Add(this.btnSearch);
            this.gbGenerate.Controls.Add(this.cbDocType);
            this.gbGenerate.Controls.Add(this.lblDocType);
            this.gbGenerate.Controls.Add(this.cbPersonType);
            this.gbGenerate.Controls.Add(this.lblPersonType);
            this.gbGenerate.Controls.Add(this.lblStartDate);
            this.gbGenerate.Controls.Add(this.lblEndDate);
            this.gbGenerate.Controls.Add(this.dtpEndDate);
            this.gbGenerate.Controls.Add(this.dtpStartDate);
            this.gbGenerate.Location = new System.Drawing.Point(9, 6);
            this.gbGenerate.Name = "gbGenerate";
            this.gbGenerate.Size = new System.Drawing.Size(740, 81);
            this.gbGenerate.TabIndex = 44;
            this.gbGenerate.TabStop = false;
            this.gbGenerate.Text = "Filtros:";
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearchPerson.Location = new System.Drawing.Point(598, 10);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(40, 23);
            this.btnSearchPerson.TabIndex = 48;
            this.btnSearchPerson.Text = "***";
            this.btnSearchPerson.UseVisualStyleBackColor = false;
            this.btnSearchPerson.Visible = false;
            // 
            // txtPersonTypeNumber
            // 
            this.txtPersonTypeNumber.Location = new System.Drawing.Point(511, 13);
            this.txtPersonTypeNumber.Mask = "00000";
            this.txtPersonTypeNumber.Name = "txtPersonTypeNumber";
            this.txtPersonTypeNumber.PromptChar = ' ';
            this.txtPersonTypeNumber.Size = new System.Drawing.Size(69, 20);
            this.txtPersonTypeNumber.TabIndex = 47;
            this.txtPersonTypeNumber.Visible = false;
            // 
            // lblPersonTypeNumber
            // 
            this.lblPersonTypeNumber.AutoSize = true;
            this.lblPersonTypeNumber.Location = new System.Drawing.Point(458, 16);
            this.lblPersonTypeNumber.Name = "lblPersonTypeNumber";
            this.lblPersonTypeNumber.Size = new System.Drawing.Size(47, 13);
            this.lblPersonTypeNumber.TabIndex = 46;
            this.lblPersonTypeNumber.Text = "Número:";
            this.lblPersonTypeNumber.Visible = false;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(511, 43);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(105, 23);
            this.cbStatus.TabIndex = 44;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(458, 49);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 45;
            this.lblStatus.Text = "Estado:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Location = new System.Drawing.Point(662, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 29);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbDocType
            // 
            this.cbDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocType.FormattingEnabled = true;
            this.cbDocType.Items.AddRange(new object[] {
            "Todos",
            "Pago",
            "Débito",
            "Crédito"});
            this.cbDocType.Location = new System.Drawing.Point(347, 43);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Size = new System.Drawing.Size(105, 23);
            this.cbDocType.TabIndex = 42;
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.BackColor = System.Drawing.Color.Transparent;
            this.lblDocType.ForeColor = System.Drawing.Color.Black;
            this.lblDocType.Location = new System.Drawing.Point(271, 48);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(54, 13);
            this.lblDocType.TabIndex = 43;
            this.lblDocType.Text = "Tipo Doc.";
            // 
            // cbPersonType
            // 
            this.cbPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPersonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPersonType.FormattingEnabled = true;
            this.cbPersonType.Items.AddRange(new object[] {
            "Ambos",
            "Empleado",
            "Cliente"});
            this.cbPersonType.Location = new System.Drawing.Point(347, 15);
            this.cbPersonType.Name = "cbPersonType";
            this.cbPersonType.Size = new System.Drawing.Size(105, 23);
            this.cbPersonType.TabIndex = 40;
            this.cbPersonType.SelectedIndexChanged += new System.EventHandler(this.cbPersonType_SelectedIndexChanged);
            // 
            // lblPersonType
            // 
            this.lblPersonType.AutoSize = true;
            this.lblPersonType.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonType.ForeColor = System.Drawing.Color.Black;
            this.lblPersonType.Location = new System.Drawing.Point(271, 20);
            this.lblPersonType.Name = "lblPersonType";
            this.lblPersonType.Size = new System.Drawing.Size(73, 13);
            this.lblPersonType.TabIndex = 41;
            this.lblPersonType.Text = "Tipo Persona:";
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
            // gbAccountsReceivable
            // 
            this.gbAccountsReceivable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAccountsReceivable.Controls.Add(this.splitContainer1);
            this.gbAccountsReceivable.Location = new System.Drawing.Point(6, 133);
            this.gbAccountsReceivable.Name = "gbAccountsReceivable";
            this.gbAccountsReceivable.Size = new System.Drawing.Size(746, 291);
            this.gbAccountsReceivable.TabIndex = 0;
            this.gbAccountsReceivable.TabStop = false;
            this.gbAccountsReceivable.Text = "Cuentas y detalles:";
            // 
            // dgvAccountsReceivable
            // 
            this.dgvAccountsReceivable.AllowUserToAddRows = false;
            this.dgvAccountsReceivable.AllowUserToDeleteRows = false;
            this.dgvAccountsReceivable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountsReceivable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountsReceivable.Location = new System.Drawing.Point(0, 0);
            this.dgvAccountsReceivable.Name = "dgvAccountsReceivable";
            this.dgvAccountsReceivable.ReadOnly = true;
            this.dgvAccountsReceivable.Size = new System.Drawing.Size(445, 272);
            this.dgvAccountsReceivable.TabIndex = 0;
            this.dgvAccountsReceivable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountsReceivable_CellClick);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(73, 546);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 16);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "*******";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(9, 546);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 16);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "Usuario:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvAccountsReceivable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAccountStatus);
            this.splitContainer1.Size = new System.Drawing.Size(740, 272);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvAccountStatus
            // 
            this.dgvAccountStatus.AllowUserToAddRows = false;
            this.dgvAccountStatus.AllowUserToDeleteRows = false;
            this.dgvAccountStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvAccountStatus.Name = "dgvAccountStatus";
            this.dgvAccountStatus.ReadOnly = true;
            this.dgvAccountStatus.Size = new System.Drawing.Size(291, 272);
            this.dgvAccountStatus.TabIndex = 0;
            // 
            // FrmAccountsReceivable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(790, 571);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tcAccountsReceivable);
            this.Controls.Add(this.lblTitulo);
            this.MinimizeBox = false;
            this.Name = "FrmAccountsReceivable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar";
            this.tcAccountsReceivable.ResumeLayout(false);
            this.tpDebitPaymentsCredit.ResumeLayout(false);
            this.tpDebitPaymentsCredit.PerformLayout();
            this.gbGenerate.ResumeLayout(false);
            this.gbGenerate.PerformLayout();
            this.gbAccountsReceivable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountsReceivable)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tcAccountsReceivable;
        private System.Windows.Forms.TabPage tpDebitPaymentsCredit;
        private System.Windows.Forms.GroupBox gbAccountsReceivable;
        private System.Windows.Forms.DataGridView dgvAccountsReceivable;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbGenerate;
        private System.Windows.Forms.ComboBox cbPersonType;
        private System.Windows.Forms.Label lblPersonType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbDocType;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MaskedTextBox txtPersonTypeNumber;
        private System.Windows.Forms.Label lblPersonTypeNumber;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvAccountStatus;
    }
}