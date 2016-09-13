namespace GYM_System
{
    partial class FrmBilling
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
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.cbPersonType = new System.Windows.Forms.ComboBox();
            this.lblPersonType = new System.Windows.Forms.Label();
            this.txtPersonNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPersonNumber = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberValue = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblMethodPayment = new System.Windows.Forms.Label();
            this.lblReceivedPay = new System.Windows.Forms.Label();
            this.txtReceivedPay = new System.Windows.Forms.MaskedTextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.lblSubTotalValue = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblITBISValue = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ckbNCF = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocumentNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.ckbPrintBill = new System.Windows.Forms.CheckBox();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.cbPayMethod = new System.Windows.Forms.ComboBox();
            this.txtNCF = new System.Windows.Forms.TextBox();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tsmPay = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.gbCustomer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(330, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 45);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Facturación";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dgvDetails);
            this.gbDetails.Location = new System.Drawing.Point(12, 284);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(806, 227);
            this.gbDetails.TabIndex = 6;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Detalle:";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(800, 208);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellEndEdit);
            this.dgvDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellValueChanged);
            this.dgvDetails.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetails_RowsAdded);
            this.dgvDetails.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDetails_UserDeletedRow);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.btnSearchPerson);
            this.gbCustomer.Controls.Add(this.cbPersonType);
            this.gbCustomer.Controls.Add(this.lblPersonType);
            this.gbCustomer.Controls.Add(this.txtPersonNumber);
            this.gbCustomer.Controls.Add(this.lblPersonNumber);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.lblPhone);
            this.gbCustomer.Controls.Add(this.txtAddress);
            this.gbCustomer.Controls.Add(this.lblStreet);
            this.gbCustomer.Controls.Add(this.txtCustomer);
            this.gbCustomer.Controls.Add(this.lblCustomer);
            this.gbCustomer.Location = new System.Drawing.Point(15, 82);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(377, 91);
            this.gbCustomer.TabIndex = 7;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Cliente:";
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearchPerson.Location = new System.Drawing.Point(334, 12);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(40, 23);
            this.btnSearchPerson.TabIndex = 49;
            this.btnSearchPerson.Text = "***";
            this.btnSearchPerson.UseVisualStyleBackColor = false;
            this.btnSearchPerson.Visible = false;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // cbPersonType
            // 
            this.cbPersonType.CausesValidation = false;
            this.cbPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPersonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPersonType.FormattingEnabled = true;
            this.cbPersonType.Items.AddRange(new object[] {
            "Genérico",
            "Empleado",
            "Cliente"});
            this.cbPersonType.Location = new System.Drawing.Point(217, 52);
            this.cbPersonType.Name = "cbPersonType";
            this.cbPersonType.Size = new System.Drawing.Size(105, 23);
            this.cbPersonType.TabIndex = 42;
            this.cbPersonType.SelectedIndexChanged += new System.EventHandler(this.cbPersonType_SelectedIndexChanged);
            // 
            // lblPersonType
            // 
            this.lblPersonType.AutoSize = true;
            this.lblPersonType.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonType.ForeColor = System.Drawing.Color.Black;
            this.lblPersonType.Location = new System.Drawing.Point(214, 36);
            this.lblPersonType.Name = "lblPersonType";
            this.lblPersonType.Size = new System.Drawing.Size(73, 13);
            this.lblPersonType.TabIndex = 43;
            this.lblPersonType.Text = "Tipo Persona:";
            // 
            // txtPersonNumber
            // 
            this.txtPersonNumber.CausesValidation = false;
            this.txtPersonNumber.Location = new System.Drawing.Point(261, 13);
            this.txtPersonNumber.Mask = "00000";
            this.txtPersonNumber.Name = "txtPersonNumber";
            this.txtPersonNumber.PromptChar = ' ';
            this.txtPersonNumber.Size = new System.Drawing.Size(69, 20);
            this.txtPersonNumber.TabIndex = 7;
            // 
            // lblPersonNumber
            // 
            this.lblPersonNumber.AutoSize = true;
            this.lblPersonNumber.Location = new System.Drawing.Point(214, 16);
            this.lblPersonNumber.Name = "lblPersonNumber";
            this.lblPersonNumber.Size = new System.Drawing.Size(47, 13);
            this.lblPersonNumber.TabIndex = 6;
            this.lblPersonNumber.Text = "Número:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(66, 61);
            this.txtPhone.Mask = "(999)000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 64);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Teléfono:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(66, 37);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 40);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(55, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Dirección:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(66, 13);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(142, 20);
            this.txtCustomer.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(6, 16);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(42, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Cliente:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblNumber.Location = new System.Drawing.Point(11, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(91, 24);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Número:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(857, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCajaToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirCajaToolStripMenuItem
            // 
            this.abrirCajaToolStripMenuItem.Name = "abrirCajaToolStripMenuItem";
            this.abrirCajaToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.abrirCajaToolStripMenuItem.Text = "Abrir Caja";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar Caja";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPay});
            this.tareasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // lblNumberValue
            // 
            this.lblNumberValue.AutoSize = true;
            this.lblNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblNumberValue.Location = new System.Drawing.Point(99, 36);
            this.lblNumberValue.Name = "lblNumberValue";
            this.lblNumberValue.Size = new System.Drawing.Size(76, 24);
            this.lblNumberValue.TabIndex = 10;
            this.lblNumberValue.Text = "000000";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(71, 585);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 16);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "*******";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(7, 585);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 16);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "Usuario:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotal.Location = new System.Drawing.Point(533, 205);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 31);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblTotalValue.Location = new System.Drawing.Point(614, 206);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(127, 31);
            this.lblTotalValue.TabIndex = 23;
            this.lblTotalValue.Text = "$ 000.00";
            // 
            // lblMethodPayment
            // 
            this.lblMethodPayment.AutoSize = true;
            this.lblMethodPayment.Location = new System.Drawing.Point(6, 18);
            this.lblMethodPayment.Name = "lblMethodPayment";
            this.lblMethodPayment.Size = new System.Drawing.Size(81, 13);
            this.lblMethodPayment.TabIndex = 24;
            this.lblMethodPayment.Text = "Forma de pago:";
            // 
            // lblReceivedPay
            // 
            this.lblReceivedPay.AutoSize = true;
            this.lblReceivedPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblReceivedPay.Location = new System.Drawing.Point(6, 16);
            this.lblReceivedPay.Name = "lblReceivedPay";
            this.lblReceivedPay.Size = new System.Drawing.Size(99, 24);
            this.lblReceivedPay.TabIndex = 26;
            this.lblReceivedPay.Text = "Recibido:";
            // 
            // txtReceivedPay
            // 
            this.txtReceivedPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.txtReceivedPay.Location = new System.Drawing.Point(105, 14);
            this.txtReceivedPay.Mask = "00000000000000";
            this.txtReceivedPay.Name = "txtReceivedPay";
            this.txtReceivedPay.PromptChar = ' ';
            this.txtReceivedPay.Size = new System.Drawing.Size(100, 26);
            this.txtReceivedPay.TabIndex = 27;
            this.txtReceivedPay.Click += new System.EventHandler(this.txtReceivedPay_Click);
            this.txtReceivedPay.TextChanged += new System.EventHandler(this.txtReceivedPay_TextChanged);
            this.txtReceivedPay.Leave += new System.EventHandler(this.txtReceivedPay_Leave);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblChange.Location = new System.Drawing.Point(5, 43);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(97, 24);
            this.lblChange.TabIndex = 28;
            this.lblChange.Text = "Devuelta:";
            // 
            // lblChangeValue
            // 
            this.lblChangeValue.AutoSize = true;
            this.lblChangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblChangeValue.Location = new System.Drawing.Point(108, 44);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.Size = new System.Drawing.Size(88, 24);
            this.lblChangeValue.TabIndex = 29;
            this.lblChangeValue.Text = "$ 000.00";
            // 
            // lblSubTotalValue
            // 
            this.lblSubTotalValue.AutoSize = true;
            this.lblSubTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblSubTotalValue.Location = new System.Drawing.Point(332, 14);
            this.lblSubTotalValue.Name = "lblSubTotalValue";
            this.lblSubTotalValue.Size = new System.Drawing.Size(88, 24);
            this.lblSubTotalValue.TabIndex = 31;
            this.lblSubTotalValue.Text = "$ 000.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblSubTotal.Location = new System.Drawing.Point(229, 13);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(106, 24);
            this.lblSubTotal.TabIndex = 30;
            this.lblSubTotal.Text = "Sub-Total:";
            // 
            // lblITBISValue
            // 
            this.lblITBISValue.AutoSize = true;
            this.lblITBISValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBISValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblITBISValue.Location = new System.Drawing.Point(332, 37);
            this.lblITBISValue.Name = "lblITBISValue";
            this.lblITBISValue.Size = new System.Drawing.Size(88, 24);
            this.lblITBISValue.TabIndex = 33;
            this.lblITBISValue.Text = "$ 000.00";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblITBIS.Location = new System.Drawing.Point(229, 37);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(65, 24);
            this.lblITBIS.TabIndex = 32;
            this.lblITBIS.Text = "ITBIS:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnCancel.Location = new System.Drawing.Point(583, 555);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Location = new System.Drawing.Point(444, 555);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnNew.Location = new System.Drawing.Point(166, 555);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSave.Location = new System.Drawing.Point(305, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Facturar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ckbNCF
            // 
            this.ckbNCF.AutoSize = true;
            this.ckbNCF.Location = new System.Drawing.Point(214, 17);
            this.ckbNCF.Name = "ckbNCF";
            this.ckbNCF.Size = new System.Drawing.Size(47, 17);
            this.ckbNCF.TabIndex = 38;
            this.ckbNCF.Text = "NCF";
            this.ckbNCF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReceivedPay);
            this.groupBox1.Controls.Add(this.txtReceivedPay);
            this.groupBox1.Controls.Add(this.lblChange);
            this.groupBox1.Controls.Add(this.lblChangeValue);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.lblSubTotalValue);
            this.groupBox1.Controls.Add(this.lblITBISValue);
            this.groupBox1.Controls.Add(this.lblITBIS);
            this.groupBox1.Location = new System.Drawing.Point(398, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 91);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago:";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(87, 39);
            this.txtDocumentNumber.Mask = "00000000000000000000";
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.PromptChar = ' ';
            this.txtDocumentNumber.Size = new System.Drawing.Size(121, 20);
            this.txtDocumentNumber.TabIndex = 41;
            this.txtDocumentNumber.Visible = false;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(6, 42);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(85, 13);
            this.lblDocumentNumber.TabIndex = 40;
            this.lblDocumentNumber.Text = "No. Documento:";
            this.lblDocumentNumber.Visible = false;
            // 
            // ckbPrintBill
            // 
            this.ckbPrintBill.AutoSize = true;
            this.ckbPrintBill.Location = new System.Drawing.Point(214, 42);
            this.ckbPrintBill.Name = "ckbPrintBill";
            this.ckbPrintBill.Size = new System.Drawing.Size(100, 17);
            this.ckbPrintBill.TabIndex = 42;
            this.ckbPrintBill.Text = "Imprimir Factura";
            this.ckbPrintBill.UseVisualStyleBackColor = true;
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.cbCondition);
            this.gbForm.Controls.Add(this.lblCondition);
            this.gbForm.Controls.Add(this.cbPayMethod);
            this.gbForm.Controls.Add(this.txtNCF);
            this.gbForm.Controls.Add(this.lblMethodPayment);
            this.gbForm.Controls.Add(this.ckbPrintBill);
            this.gbForm.Controls.Add(this.txtDocumentNumber);
            this.gbForm.Controls.Add(this.ckbNCF);
            this.gbForm.Controls.Add(this.lblDocumentNumber);
            this.gbForm.Location = new System.Drawing.Point(15, 179);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(492, 72);
            this.gbForm.TabIndex = 43;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Forma:";
            // 
            // cbCondition
            // 
            this.cbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "Aprobada",
            "Anulada"});
            this.cbCondition.Location = new System.Drawing.Point(379, 40);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(107, 21);
            this.cbCondition.TabIndex = 45;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(320, 43);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(57, 13);
            this.lblCondition.TabIndex = 44;
            this.lblCondition.Text = "Condición:";
            // 
            // cbPayMethod
            // 
            this.cbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbPayMethod.FormattingEnabled = true;
            this.cbPayMethod.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Cheque",
            "Crédito"});
            this.cbPayMethod.Location = new System.Drawing.Point(87, 13);
            this.cbPayMethod.Name = "cbPayMethod";
            this.cbPayMethod.Size = new System.Drawing.Size(121, 21);
            this.cbPayMethod.TabIndex = 43;
            this.cbPayMethod.SelectedIndexChanged += new System.EventHandler(this.cbPayMethod_SelectedIndexChanged);
            // 
            // txtNCF
            // 
            this.txtNCF.CausesValidation = false;
            this.txtNCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCF.Location = new System.Drawing.Point(261, 14);
            this.txtNCF.Name = "txtNCF";
            this.txtNCF.ReadOnly = true;
            this.txtNCF.Size = new System.Drawing.Size(188, 22);
            this.txtNCF.TabIndex = 6;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Location = new System.Drawing.Point(9, 521);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(40, 13);
            this.lblBillDate.TabIndex = 44;
            this.lblBillDate.Text = "Fecha:";
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Location = new System.Drawing.Point(51, 519);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBillDate.TabIndex = 45;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(13, 265);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(43, 13);
            this.lblCode.TabIndex = 46;
            this.lblCode.Text = "Código:";
            // 
            // txtCode
            // 
            this.txtCode.CausesValidation = false;
            this.txtCode.Location = new System.Drawing.Point(62, 262);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(113, 20);
            this.txtCode.TabIndex = 47;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.CausesValidation = false;
            this.txtQuantity.Location = new System.Drawing.Point(272, 262);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(63, 20);
            this.txtQuantity.TabIndex = 48;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(217, 265);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblQuantity.TabIndex = 49;
            this.lblQuantity.Text = "Cantidad:";
            // 
            // tsmPay
            // 
            this.tsmPay.Name = "tsmPay";
            this.tsmPay.Size = new System.Drawing.Size(152, 24);
            this.tsmPay.Text = "Pagos";
            this.tsmPay.Click += new System.EventHandler(this.tsmPay_Click);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(857, 607);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dtpBillDate);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblNumberValue);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTitulo);
            this.KeyPreview = true;
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.gbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblNumber;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label lblNumberValue;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblMethodPayment;
        private System.Windows.Forms.Label lblReceivedPay;
        private System.Windows.Forms.MaskedTextBox txtReceivedPay;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblChangeValue;
        private System.Windows.Forms.Label lblSubTotalValue;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblITBISValue;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckbNCF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtDocumentNumber;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.CheckBox ckbPrintBill;
        private System.Windows.Forms.ToolStripMenuItem abrirCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.TextBox txtNCF;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.MaskedTextBox txtPersonNumber;
        private System.Windows.Forms.Label lblPersonNumber;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.ComboBox cbPayMethod;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.ComboBox cbPersonType;
        private System.Windows.Forms.Label lblPersonType;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ToolStripMenuItem tsmPay;
    }
}