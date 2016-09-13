namespace GYM_System
{
    partial class FrmReconcile
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
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblNumberValue = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBillsFrom = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblBillsFromValue = new System.Windows.Forms.Label();
            this.lblBillsUntilValue = new System.Windows.Forms.Label();
            this.lblBillsUntil = new System.Windows.Forms.Label();
            this.lblVoidedBillsValue = new System.Windows.Forms.Label();
            this.lblVoidedBills = new System.Windows.Forms.Label();
            this.gbRange = new System.Windows.Forms.GroupBox();
            this.lblTotalCashValue = new System.Windows.Forms.Label();
            this.lblTotalCardValue = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblTotalCreditValue = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblTotalCheckValue = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblTotalPaymentValue = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblTotalSoldAmountValue = new System.Windows.Forms.Label();
            this.lblTotalSoldAmount = new System.Windows.Forms.Label();
            this.gbSalesByUsers = new System.Windows.Forms.GroupBox();
            this.dgvSalesByUsers = new System.Windows.Forms.DataGridView();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.lblNumberCash = new System.Windows.Forms.Label();
            this.lblNumberCashValue = new System.Windows.Forms.Label();
            this.lblNumberCardValue = new System.Windows.Forms.Label();
            this.lblNumberCard = new System.Windows.Forms.Label();
            this.lblTotalCard = new System.Windows.Forms.Label();
            this.lblNumberCreditValue = new System.Windows.Forms.Label();
            this.lblNumberCredit = new System.Windows.Forms.Label();
            this.lblTotalCredit = new System.Windows.Forms.Label();
            this.lblNumberCheckValue = new System.Windows.Forms.Label();
            this.lblNumberCheck = new System.Windows.Forms.Label();
            this.lblTotalCheck = new System.Windows.Forms.Label();
            this.btnSaveAndPrint = new System.Windows.Forms.Button();
            this.gbGenerate.SuspendLayout();
            this.gbRange.SuspendLayout();
            this.gbSalesByUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesByUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(157, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 45);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cuadre de caja";
            // 
            // gbGenerate
            // 
            this.gbGenerate.Controls.Add(this.lblStartDate);
            this.gbGenerate.Controls.Add(this.btnSearch);
            this.gbGenerate.Controls.Add(this.lblEndDate);
            this.gbGenerate.Controls.Add(this.dtpEndDate);
            this.gbGenerate.Controls.Add(this.dtpStartDate);
            this.gbGenerate.Location = new System.Drawing.Point(12, 98);
            this.gbGenerate.Name = "gbGenerate";
            this.gbGenerate.Size = new System.Drawing.Size(331, 69);
            this.gbGenerate.TabIndex = 42;
            this.gbGenerate.TabStop = false;
            this.gbGenerate.Text = "Filtros:";
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Location = new System.Drawing.Point(253, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 29);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Generar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // lblNumberValue
            // 
            this.lblNumberValue.AutoSize = true;
            this.lblNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblNumberValue.Location = new System.Drawing.Point(81, 68);
            this.lblNumberValue.Name = "lblNumberValue";
            this.lblNumberValue.Size = new System.Drawing.Size(56, 16);
            this.lblNumberValue.TabIndex = 45;
            this.lblNumberValue.Text = "000000";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblNumber.Location = new System.Drawing.Point(9, 68);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(66, 16);
            this.lblNumber.TabIndex = 44;
            this.lblNumber.Text = "Número:";
            // 
            // lblBillsFrom
            // 
            this.lblBillsFrom.AutoSize = true;
            this.lblBillsFrom.Location = new System.Drawing.Point(6, 16);
            this.lblBillsFrom.Name = "lblBillsFrom";
            this.lblBillsFrom.Size = new System.Drawing.Size(83, 13);
            this.lblBillsFrom.TabIndex = 46;
            this.lblBillsFrom.Text = "Facturas desde:";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(18, 236);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(54, 13);
            this.lblCash.TabIndex = 50;
            this.lblCash.Text = "Efectivo";
            // 
            // lblBillsFromValue
            // 
            this.lblBillsFromValue.AutoSize = true;
            this.lblBillsFromValue.Location = new System.Drawing.Point(87, 16);
            this.lblBillsFromValue.Name = "lblBillsFromValue";
            this.lblBillsFromValue.Size = new System.Drawing.Size(49, 13);
            this.lblBillsFromValue.TabIndex = 51;
            this.lblBillsFromValue.Text = "0000000";
            // 
            // lblBillsUntilValue
            // 
            this.lblBillsUntilValue.AutoSize = true;
            this.lblBillsUntilValue.Location = new System.Drawing.Point(87, 38);
            this.lblBillsUntilValue.Name = "lblBillsUntilValue";
            this.lblBillsUntilValue.Size = new System.Drawing.Size(49, 13);
            this.lblBillsUntilValue.TabIndex = 53;
            this.lblBillsUntilValue.Text = "0000000";
            // 
            // lblBillsUntil
            // 
            this.lblBillsUntil.AutoSize = true;
            this.lblBillsUntil.Location = new System.Drawing.Point(6, 38);
            this.lblBillsUntil.Name = "lblBillsUntil";
            this.lblBillsUntil.Size = new System.Drawing.Size(80, 13);
            this.lblBillsUntil.TabIndex = 52;
            this.lblBillsUntil.Text = "Facturas hasta:";
            // 
            // lblVoidedBillsValue
            // 
            this.lblVoidedBillsValue.AutoSize = true;
            this.lblVoidedBillsValue.Location = new System.Drawing.Point(328, 201);
            this.lblVoidedBillsValue.Name = "lblVoidedBillsValue";
            this.lblVoidedBillsValue.Size = new System.Drawing.Size(25, 13);
            this.lblVoidedBillsValue.TabIndex = 55;
            this.lblVoidedBillsValue.Text = "000";
            // 
            // lblVoidedBills
            // 
            this.lblVoidedBills.AutoSize = true;
            this.lblVoidedBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoidedBills.Location = new System.Drawing.Point(212, 201);
            this.lblVoidedBills.Name = "lblVoidedBills";
            this.lblVoidedBills.Size = new System.Drawing.Size(115, 13);
            this.lblVoidedBills.TabIndex = 54;
            this.lblVoidedBills.Text = "Facturas anuladas:";
            // 
            // gbRange
            // 
            this.gbRange.Controls.Add(this.lblBillsFrom);
            this.gbRange.Controls.Add(this.lblBillsFromValue);
            this.gbRange.Controls.Add(this.lblBillsUntil);
            this.gbRange.Controls.Add(this.lblBillsUntilValue);
            this.gbRange.Location = new System.Drawing.Point(12, 173);
            this.gbRange.Name = "gbRange";
            this.gbRange.Size = new System.Drawing.Size(186, 60);
            this.gbRange.TabIndex = 56;
            this.gbRange.TabStop = false;
            this.gbRange.Text = "Rango:";
            // 
            // lblTotalCashValue
            // 
            this.lblTotalCashValue.AutoSize = true;
            this.lblTotalCashValue.Location = new System.Drawing.Point(86, 272);
            this.lblTotalCashValue.Name = "lblTotalCashValue";
            this.lblTotalCashValue.Size = new System.Drawing.Size(49, 13);
            this.lblTotalCashValue.TabIndex = 57;
            this.lblTotalCashValue.Text = "$ 000.00";
            // 
            // lblTotalCardValue
            // 
            this.lblTotalCardValue.AutoSize = true;
            this.lblTotalCardValue.Location = new System.Drawing.Point(90, 347);
            this.lblTotalCardValue.Name = "lblTotalCardValue";
            this.lblTotalCardValue.Size = new System.Drawing.Size(49, 13);
            this.lblTotalCardValue.TabIndex = 59;
            this.lblTotalCardValue.Text = "$ 000.00";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(18, 310);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(90, 13);
            this.lblCard.TabIndex = 58;
            this.lblCard.Text = "Tarjeta crédito";
            // 
            // lblTotalCreditValue
            // 
            this.lblTotalCreditValue.AutoSize = true;
            this.lblTotalCreditValue.Location = new System.Drawing.Point(265, 272);
            this.lblTotalCreditValue.Name = "lblTotalCreditValue";
            this.lblTotalCreditValue.Size = new System.Drawing.Size(49, 13);
            this.lblTotalCreditValue.TabIndex = 61;
            this.lblTotalCreditValue.Text = "$ 000.00";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(195, 236);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(47, 13);
            this.lblCredit.TabIndex = 60;
            this.lblCredit.Text = "Crédito";
            // 
            // lblTotalCheckValue
            // 
            this.lblTotalCheckValue.AutoSize = true;
            this.lblTotalCheckValue.Location = new System.Drawing.Point(262, 347);
            this.lblTotalCheckValue.Name = "lblTotalCheckValue";
            this.lblTotalCheckValue.Size = new System.Drawing.Size(49, 13);
            this.lblTotalCheckValue.TabIndex = 63;
            this.lblTotalCheckValue.Text = "$ 000.00";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(195, 310);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(50, 13);
            this.lblCheck.TabIndex = 62;
            this.lblCheck.Text = "Cheque";
            // 
            // lblTotalPaymentValue
            // 
            this.lblTotalPaymentValue.AutoSize = true;
            this.lblTotalPaymentValue.Location = new System.Drawing.Point(434, 236);
            this.lblTotalPaymentValue.Name = "lblTotalPaymentValue";
            this.lblTotalPaymentValue.Size = new System.Drawing.Size(49, 13);
            this.lblTotalPaymentValue.TabIndex = 65;
            this.lblTotalPaymentValue.Text = "$ 000.00";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(382, 236);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(46, 13);
            this.lblTotalPayment.TabIndex = 64;
            this.lblTotalPayment.Text = "Pagos:";
            // 
            // lblTotalSoldAmountValue
            // 
            this.lblTotalSoldAmountValue.AutoSize = true;
            this.lblTotalSoldAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSoldAmountValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotalSoldAmountValue.Location = new System.Drawing.Point(124, 401);
            this.lblTotalSoldAmountValue.Name = "lblTotalSoldAmountValue";
            this.lblTotalSoldAmountValue.Size = new System.Drawing.Size(79, 20);
            this.lblTotalSoldAmountValue.TabIndex = 69;
            this.lblTotalSoldAmountValue.Text = "$ 000.00";
            // 
            // lblTotalSoldAmount
            // 
            this.lblTotalSoldAmount.AutoSize = true;
            this.lblTotalSoldAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSoldAmount.Location = new System.Drawing.Point(18, 401);
            this.lblTotalSoldAmount.Name = "lblTotalSoldAmount";
            this.lblTotalSoldAmount.Size = new System.Drawing.Size(112, 20);
            this.lblTotalSoldAmount.TabIndex = 68;
            this.lblTotalSoldAmount.Text = "Total ventas:";
            // 
            // gbSalesByUsers
            // 
            this.gbSalesByUsers.Controls.Add(this.dgvSalesByUsers);
            this.gbSalesByUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSalesByUsers.Location = new System.Drawing.Point(0, 437);
            this.gbSalesByUsers.Name = "gbSalesByUsers";
            this.gbSalesByUsers.Size = new System.Drawing.Size(571, 151);
            this.gbSalesByUsers.TabIndex = 70;
            this.gbSalesByUsers.TabStop = false;
            this.gbSalesByUsers.Text = "Ventas por usuario:";
            // 
            // dgvSalesByUsers
            // 
            this.dgvSalesByUsers.AllowUserToAddRows = false;
            this.dgvSalesByUsers.AllowUserToDeleteRows = false;
            this.dgvSalesByUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesByUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesByUsers.Location = new System.Drawing.Point(3, 16);
            this.dgvSalesByUsers.Name = "dgvSalesByUsers";
            this.dgvSalesByUsers.ReadOnly = true;
            this.dgvSalesByUsers.Size = new System.Drawing.Size(565, 132);
            this.dgvSalesByUsers.TabIndex = 0;
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.AutoSize = true;
            this.lblTotalCash.Location = new System.Drawing.Point(18, 272);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCash.TabIndex = 71;
            this.lblTotalCash.Text = "Total:";
            // 
            // lblNumberCash
            // 
            this.lblNumberCash.AutoSize = true;
            this.lblNumberCash.Location = new System.Drawing.Point(18, 255);
            this.lblNumberCash.Name = "lblNumberCash";
            this.lblNumberCash.Size = new System.Drawing.Size(71, 13);
            this.lblNumberCash.TabIndex = 72;
            this.lblNumberCash.Text = "Num. Ventas:";
            // 
            // lblNumberCashValue
            // 
            this.lblNumberCashValue.AutoSize = true;
            this.lblNumberCashValue.Location = new System.Drawing.Point(90, 255);
            this.lblNumberCashValue.Name = "lblNumberCashValue";
            this.lblNumberCashValue.Size = new System.Drawing.Size(25, 13);
            this.lblNumberCashValue.TabIndex = 73;
            this.lblNumberCashValue.Text = "000";
            // 
            // lblNumberCardValue
            // 
            this.lblNumberCardValue.AutoSize = true;
            this.lblNumberCardValue.Location = new System.Drawing.Point(90, 330);
            this.lblNumberCardValue.Name = "lblNumberCardValue";
            this.lblNumberCardValue.Size = new System.Drawing.Size(25, 13);
            this.lblNumberCardValue.TabIndex = 76;
            this.lblNumberCardValue.Text = "000";
            // 
            // lblNumberCard
            // 
            this.lblNumberCard.AutoSize = true;
            this.lblNumberCard.Location = new System.Drawing.Point(18, 330);
            this.lblNumberCard.Name = "lblNumberCard";
            this.lblNumberCard.Size = new System.Drawing.Size(71, 13);
            this.lblNumberCard.TabIndex = 75;
            this.lblNumberCard.Text = "Num. Ventas:";
            // 
            // lblTotalCard
            // 
            this.lblTotalCard.AutoSize = true;
            this.lblTotalCard.Location = new System.Drawing.Point(18, 347);
            this.lblTotalCard.Name = "lblTotalCard";
            this.lblTotalCard.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCard.TabIndex = 74;
            this.lblTotalCard.Text = "Total:";
            // 
            // lblNumberCreditValue
            // 
            this.lblNumberCreditValue.AutoSize = true;
            this.lblNumberCreditValue.Location = new System.Drawing.Point(265, 255);
            this.lblNumberCreditValue.Name = "lblNumberCreditValue";
            this.lblNumberCreditValue.Size = new System.Drawing.Size(25, 13);
            this.lblNumberCreditValue.TabIndex = 79;
            this.lblNumberCreditValue.Text = "000";
            // 
            // lblNumberCredit
            // 
            this.lblNumberCredit.AutoSize = true;
            this.lblNumberCredit.Location = new System.Drawing.Point(195, 255);
            this.lblNumberCredit.Name = "lblNumberCredit";
            this.lblNumberCredit.Size = new System.Drawing.Size(71, 13);
            this.lblNumberCredit.TabIndex = 78;
            this.lblNumberCredit.Text = "Num. Ventas:";
            // 
            // lblTotalCredit
            // 
            this.lblTotalCredit.AutoSize = true;
            this.lblTotalCredit.Location = new System.Drawing.Point(195, 272);
            this.lblTotalCredit.Name = "lblTotalCredit";
            this.lblTotalCredit.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCredit.TabIndex = 77;
            this.lblTotalCredit.Text = "Total:";
            // 
            // lblNumberCheckValue
            // 
            this.lblNumberCheckValue.AutoSize = true;
            this.lblNumberCheckValue.Location = new System.Drawing.Point(265, 330);
            this.lblNumberCheckValue.Name = "lblNumberCheckValue";
            this.lblNumberCheckValue.Size = new System.Drawing.Size(25, 13);
            this.lblNumberCheckValue.TabIndex = 82;
            this.lblNumberCheckValue.Text = "000";
            // 
            // lblNumberCheck
            // 
            this.lblNumberCheck.AutoSize = true;
            this.lblNumberCheck.Location = new System.Drawing.Point(195, 330);
            this.lblNumberCheck.Name = "lblNumberCheck";
            this.lblNumberCheck.Size = new System.Drawing.Size(71, 13);
            this.lblNumberCheck.TabIndex = 81;
            this.lblNumberCheck.Text = "Num. Ventas:";
            // 
            // lblTotalCheck
            // 
            this.lblTotalCheck.AutoSize = true;
            this.lblTotalCheck.Location = new System.Drawing.Point(195, 347);
            this.lblTotalCheck.Name = "lblTotalCheck";
            this.lblTotalCheck.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCheck.TabIndex = 80;
            this.lblTotalCheck.Text = "Total:";
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSaveAndPrint.FlatAppearance.BorderSize = 0;
            this.btnSaveAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSaveAndPrint.Location = new System.Drawing.Point(437, 385);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.Size = new System.Drawing.Size(91, 46);
            this.btnSaveAndPrint.TabIndex = 40;
            this.btnSaveAndPrint.Text = "Imprimir y Guardar";
            this.btnSaveAndPrint.UseVisualStyleBackColor = false;
            this.btnSaveAndPrint.Click += new System.EventHandler(this.btnSaveAndPrint_Click);
            // 
            // FrmReconcile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(571, 588);
            this.Controls.Add(this.btnSaveAndPrint);
            this.Controls.Add(this.lblNumberCheckValue);
            this.Controls.Add(this.lblNumberCheck);
            this.Controls.Add(this.lblTotalCheck);
            this.Controls.Add(this.lblNumberCreditValue);
            this.Controls.Add(this.lblNumberCredit);
            this.Controls.Add(this.lblTotalCredit);
            this.Controls.Add(this.lblNumberCardValue);
            this.Controls.Add(this.lblNumberCard);
            this.Controls.Add(this.lblTotalCard);
            this.Controls.Add(this.lblNumberCashValue);
            this.Controls.Add(this.lblNumberCash);
            this.Controls.Add(this.lblTotalCash);
            this.Controls.Add(this.gbSalesByUsers);
            this.Controls.Add(this.lblTotalSoldAmountValue);
            this.Controls.Add(this.lblTotalSoldAmount);
            this.Controls.Add(this.lblTotalPaymentValue);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblTotalCheckValue);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblTotalCreditValue);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblTotalCardValue);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lblTotalCashValue);
            this.Controls.Add(this.gbRange);
            this.Controls.Add(this.lblVoidedBillsValue);
            this.Controls.Add(this.lblVoidedBills);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblNumberValue);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.gbGenerate);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReconcile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadre";
            this.gbGenerate.ResumeLayout(false);
            this.gbGenerate.PerformLayout();
            this.gbRange.ResumeLayout(false);
            this.gbRange.PerformLayout();
            this.gbSalesByUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesByUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbGenerate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblNumberValue;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBillsFrom;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblBillsFromValue;
        private System.Windows.Forms.Label lblBillsUntilValue;
        private System.Windows.Forms.Label lblBillsUntil;
        private System.Windows.Forms.Label lblVoidedBillsValue;
        private System.Windows.Forms.Label lblVoidedBills;
        private System.Windows.Forms.GroupBox gbRange;
        private System.Windows.Forms.Label lblTotalCashValue;
        private System.Windows.Forms.Label lblTotalCardValue;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblTotalCreditValue;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblTotalCheckValue;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblTotalPaymentValue;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblTotalSoldAmountValue;
        private System.Windows.Forms.Label lblTotalSoldAmount;
        private System.Windows.Forms.GroupBox gbSalesByUsers;
        private System.Windows.Forms.DataGridView dgvSalesByUsers;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Label lblNumberCash;
        private System.Windows.Forms.Label lblNumberCashValue;
        private System.Windows.Forms.Label lblNumberCardValue;
        private System.Windows.Forms.Label lblNumberCard;
        private System.Windows.Forms.Label lblTotalCard;
        private System.Windows.Forms.Label lblNumberCreditValue;
        private System.Windows.Forms.Label lblNumberCredit;
        private System.Windows.Forms.Label lblTotalCredit;
        private System.Windows.Forms.Label lblNumberCheckValue;
        private System.Windows.Forms.Label lblNumberCheck;
        private System.Windows.Forms.Label lblTotalCheck;
        private System.Windows.Forms.Button btnSaveAndPrint;
    }
}