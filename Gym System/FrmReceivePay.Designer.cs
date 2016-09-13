namespace GYM_System
{
    partial class FrmReceivePay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocumentNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblDebit = new System.Windows.Forms.Label();
            this.lblDebitValue = new System.Windows.Forms.Label();
            this.lblReceivedPay = new System.Windows.Forms.Label();
            this.txtReceivedPay = new System.Windows.Forms.MaskedTextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblCreditValue = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
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
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(127, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(292, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Abonos a cuentas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDocumentNumber);
            this.groupBox1.Controls.Add(this.lblDocumentNumber);
            this.groupBox1.Controls.Add(this.lblPaymentMethod);
            this.groupBox1.Controls.Add(this.cbPaymentMethod);
            this.groupBox1.Controls.Add(this.lblDebit);
            this.groupBox1.Controls.Add(this.lblDebitValue);
            this.groupBox1.Controls.Add(this.lblReceivedPay);
            this.groupBox1.Controls.Add(this.txtReceivedPay);
            this.groupBox1.Controls.Add(this.lblCredit);
            this.groupBox1.Controls.Add(this.lblCreditValue);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblBalanceValue);
            this.groupBox1.Location = new System.Drawing.Point(3, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 122);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago:";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.CausesValidation = false;
            this.txtDocumentNumber.Location = new System.Drawing.Point(88, 90);
            this.txtDocumentNumber.Mask = "00000000000000000000";
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.PromptChar = ' ';
            this.txtDocumentNumber.Size = new System.Drawing.Size(121, 20);
            this.txtDocumentNumber.TabIndex = 46;
            this.txtDocumentNumber.Visible = false;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(7, 93);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(85, 13);
            this.lblDocumentNumber.TabIndex = 45;
            this.lblDocumentNumber.Text = "No. Documento:";
            this.lblDocumentNumber.Visible = false;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblPaymentMethod.Location = new System.Drawing.Point(6, 58);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(39, 16);
            this.lblPaymentMethod.TabIndex = 44;
            this.lblPaymentMethod.Text = "Pay:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.CausesValidation = false;
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Cheque"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(51, 55);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(105, 23);
            this.cbPaymentMethod.TabIndex = 43;
            this.cbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbPaymentMethod_SelectedIndexChanged);
            // 
            // lblDebit
            // 
            this.lblDebit.AutoSize = true;
            this.lblDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblDebit.Location = new System.Drawing.Point(214, 58);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(58, 16);
            this.lblDebit.TabIndex = 32;
            this.lblDebit.Text = "Débito:";
            // 
            // lblDebitValue
            // 
            this.lblDebitValue.AutoSize = true;
            this.lblDebitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblDebitValue.Location = new System.Drawing.Point(277, 59);
            this.lblDebitValue.Name = "lblDebitValue";
            this.lblDebitValue.Size = new System.Drawing.Size(64, 16);
            this.lblDebitValue.TabIndex = 33;
            this.lblDebitValue.Text = "$ 000.00";
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
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblCredit.Location = new System.Drawing.Point(376, 58);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(62, 16);
            this.lblCredit.TabIndex = 28;
            this.lblCredit.Text = "Crédito:";
            // 
            // lblCreditValue
            // 
            this.lblCreditValue.AutoSize = true;
            this.lblCreditValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblCreditValue.Location = new System.Drawing.Point(439, 59);
            this.lblCreditValue.Name = "lblCreditValue";
            this.lblCreditValue.Size = new System.Drawing.Size(64, 16);
            this.lblCreditValue.TabIndex = 29;
            this.lblCreditValue.Text = "$ 000.00";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblBalance.Location = new System.Drawing.Point(213, 16);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(91, 24);
            this.lblBalance.TabIndex = 30;
            this.lblBalance.Text = "Balance:";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblBalanceValue.Location = new System.Drawing.Point(299, 17);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(88, 24);
            this.lblBalanceValue.TabIndex = 31;
            this.lblBalanceValue.Text = "$ 000.00";
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
            this.gbCustomer.Location = new System.Drawing.Point(3, 48);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(377, 91);
            this.gbCustomer.TabIndex = 34;
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
            "Empleado",
            "Cliente"});
            this.cbPersonType.Location = new System.Drawing.Point(217, 52);
            this.cbPersonType.Name = "cbPersonType";
            this.cbPersonType.Size = new System.Drawing.Size(105, 23);
            this.cbPersonType.TabIndex = 42;
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
            this.txtPhone.Enabled = false;
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
            this.txtAddress.Enabled = false;
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
            this.txtCustomer.Enabled = false;
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
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnPay.Location = new System.Drawing.Point(108, 273);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 40);
            this.btnPay.TabIndex = 53;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnCancel.Location = new System.Drawing.Point(285, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmReceivePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(547, 325);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceivePay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos(abonos a cuentas)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReceivedPay;
        private System.Windows.Forms.MaskedTextBox txtReceivedPay;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblCreditValue;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.ComboBox cbPersonType;
        private System.Windows.Forms.Label lblPersonType;
        private System.Windows.Forms.MaskedTextBox txtPersonNumber;
        private System.Windows.Forms.Label lblPersonNumber;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.Label lblDebitValue;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.MaskedTextBox txtDocumentNumber;
        private System.Windows.Forms.Label lblDocumentNumber;
    }
}