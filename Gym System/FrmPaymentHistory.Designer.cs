namespace GYM_System
{
    partial class FrmPaymentHistory
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
            this.gbPaymentsHistory = new System.Windows.Forms.GroupBox();
            this.dgvPaymentsHistory = new System.Windows.Forms.DataGridView();
            this.MembershipNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblViewBy = new System.Windows.Forms.Label();
            this.cbViewBy = new System.Windows.Forms.ComboBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.gbPaymentsHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsHistory)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(196, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(372, 55);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Historial de Pagos";
            // 
            // gbPaymentsHistory
            // 
            this.gbPaymentsHistory.Controls.Add(this.dgvPaymentsHistory);
            this.gbPaymentsHistory.Location = new System.Drawing.Point(47, 209);
            this.gbPaymentsHistory.Name = "gbPaymentsHistory";
            this.gbPaymentsHistory.Size = new System.Drawing.Size(677, 250);
            this.gbPaymentsHistory.TabIndex = 3;
            this.gbPaymentsHistory.TabStop = false;
            this.gbPaymentsHistory.Text = "Detalles:";
            // 
            // dgvPaymentsHistory
            // 
            this.dgvPaymentsHistory.AllowUserToAddRows = false;
            this.dgvPaymentsHistory.AllowUserToDeleteRows = false;
            this.dgvPaymentsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentsHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MembershipNumber,
            this.ClCustomer,
            this.Membership,
            this.Amount});
            this.dgvPaymentsHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentsHistory.Location = new System.Drawing.Point(3, 16);
            this.dgvPaymentsHistory.Name = "dgvPaymentsHistory";
            this.dgvPaymentsHistory.ReadOnly = true;
            this.dgvPaymentsHistory.Size = new System.Drawing.Size(671, 231);
            this.dgvPaymentsHistory.TabIndex = 0;
            // 
            // MembershipNumber
            // 
            this.MembershipNumber.HeaderText = "No. Membresía";
            this.MembershipNumber.Name = "MembershipNumber";
            this.MembershipNumber.ReadOnly = true;
            // 
            // ClCustomer
            // 
            this.ClCustomer.HeaderText = "Cliente";
            this.ClCustomer.Name = "ClCustomer";
            this.ClCustomer.ReadOnly = true;
            this.ClCustomer.Width = 300;
            // 
            // Membership
            // 
            this.Membership.HeaderText = "Membresía";
            this.Membership.Name = "Membership";
            this.Membership.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Monto";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // lblViewBy
            // 
            this.lblViewBy.AutoSize = true;
            this.lblViewBy.Location = new System.Drawing.Point(6, 78);
            this.lblViewBy.Name = "lblViewBy";
            this.lblViewBy.Size = new System.Drawing.Size(44, 13);
            this.lblViewBy.TabIndex = 4;
            this.lblViewBy.Text = "Ver por:";
            // 
            // cbViewBy
            // 
            this.cbViewBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViewBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbViewBy.FormattingEnabled = true;
            this.cbViewBy.Items.AddRange(new object[] {
            "Hoy",
            "Semana",
            "Mes",
            "Año"});
            this.cbViewBy.Location = new System.Drawing.Point(57, 78);
            this.cbViewBy.Name = "cbViewBy";
            this.cbViewBy.Size = new System.Drawing.Size(121, 21);
            this.cbViewBy.TabIndex = 5;
            this.cbViewBy.SelectedIndexChanged += new System.EventHandler(this.cbViewBy_SelectedIndexChanged);
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.lblTotalValue.Location = new System.Drawing.Point(529, 173);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(117, 35);
            this.lblTotalValue.TabIndex = 34;
            this.lblTotalValue.Text = "$000.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(457, 173);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 33);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Total:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(47, 14);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 35;
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Location = new System.Drawing.Point(190, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 29);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.lblStartDate);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.lblViewBy);
            this.gbFilter.Controls.Add(this.lblEndDate);
            this.gbFilter.Controls.Add(this.cbViewBy);
            this.gbFilter.Controls.Add(this.dtpEndDate);
            this.gbFilter.Controls.Add(this.dtpStartDate);
            this.gbFilter.Location = new System.Drawing.Point(50, 84);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(262, 108);
            this.gbFilter.TabIndex = 40;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filtros:";
            // 
            // FrmPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(777, 483);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbPaymentsHistory);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaymentHistory";
            this.Text = "Historial de Pago:";
            this.Load += new System.EventHandler(this.FrmPaymentHistory_Load);
            this.gbPaymentsHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsHistory)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbPaymentsHistory;
        private System.Windows.Forms.DataGridView dgvPaymentsHistory;
        private System.Windows.Forms.Label lblViewBy;
        private System.Windows.Forms.ComboBox cbViewBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membership;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbFilter;
    }
}