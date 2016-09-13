namespace GYM_System
{
    partial class FrmSearchCustomer
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbFirstLastName = new System.Windows.Forms.RadioButton();
            this.rbCardPassport = new System.Windows.Forms.RadioButton();
            this.rbMembership = new System.Windows.Forms.RadioButton();
            this.rbFirstName = new System.Windows.Forms.RadioButton();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.CustomerObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbFilters.SuspendLayout();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(218, -4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 38);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Búsqueda";
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 124);
            this.txtSearch.MaxLength = 25;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 21);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.rbTodos);
            this.gbFilters.Controls.Add(this.rbFirstLastName);
            this.gbFilters.Controls.Add(this.rbCardPassport);
            this.gbFilters.Controls.Add(this.rbMembership);
            this.gbFilters.Controls.Add(this.rbFirstName);
            this.gbFilters.Location = new System.Drawing.Point(12, 47);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(246, 68);
            this.gbFilters.TabIndex = 7;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filtros:";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(88, 45);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 4;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbFirstLastName
            // 
            this.rbFirstLastName.AutoSize = true;
            this.rbFirstLastName.Location = new System.Drawing.Point(88, 20);
            this.rbFirstLastName.Name = "rbFirstLastName";
            this.rbFirstLastName.Size = new System.Drawing.Size(62, 17);
            this.rbFirstLastName.TabIndex = 3;
            this.rbFirstLastName.TabStop = true;
            this.rbFirstLastName.Text = "Apellido";
            this.rbFirstLastName.UseVisualStyleBackColor = true;
            // 
            // rbCardPassport
            // 
            this.rbCardPassport.AutoSize = true;
            this.rbCardPassport.Location = new System.Drawing.Point(167, 20);
            this.rbCardPassport.Name = "rbCardPassport";
            this.rbCardPassport.Size = new System.Drawing.Size(58, 17);
            this.rbCardPassport.TabIndex = 2;
            this.rbCardPassport.TabStop = true;
            this.rbCardPassport.Text = "Cédula";
            this.rbCardPassport.UseVisualStyleBackColor = true;
            // 
            // rbMembership
            // 
            this.rbMembership.AutoSize = true;
            this.rbMembership.Location = new System.Drawing.Point(7, 45);
            this.rbMembership.Name = "rbMembership";
            this.rbMembership.Size = new System.Drawing.Size(78, 17);
            this.rbMembership.TabIndex = 1;
            this.rbMembership.TabStop = true;
            this.rbMembership.Text = "Membresía";
            this.rbMembership.UseVisualStyleBackColor = true;
            // 
            // rbFirstName
            // 
            this.rbFirstName.AutoSize = true;
            this.rbFirstName.Location = new System.Drawing.Point(7, 20);
            this.rbFirstName.Name = "rbFirstName";
            this.rbFirstName.Size = new System.Drawing.Size(62, 17);
            this.rbFirstName.TabIndex = 0;
            this.rbFirstName.TabStop = true;
            this.rbFirstName.Text = "Nombre";
            this.rbFirstName.UseVisualStyleBackColor = true;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.dgvResults);
            this.gbResults.Location = new System.Drawing.Point(12, 157);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(544, 208);
            this.gbResults.TabIndex = 8;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Resultados:";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerObject,
            this.MembershipNumber,
            this.FirstName,
            this.FirstLastName,
            this.MembershipType,
            this.Status});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(3, 16);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(538, 189);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellDoubleClick);
            // 
            // CustomerObject
            // 
            this.CustomerObject.HeaderText = "Customer";
            this.CustomerObject.Name = "CustomerObject";
            this.CustomerObject.ReadOnly = true;
            this.CustomerObject.Visible = false;
            // 
            // MembershipNumber
            // 
            this.MembershipNumber.HeaderText = "Número";
            this.MembershipNumber.Name = "MembershipNumber";
            this.MembershipNumber.ReadOnly = true;
            this.MembershipNumber.Width = 50;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Nombre";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 150;
            // 
            // FirstLastName
            // 
            this.FirstLastName.HeaderText = "Apellido";
            this.FirstLastName.Name = "FirstLastName";
            this.FirstLastName.ReadOnly = true;
            this.FirstLastName.Width = 150;
            // 
            // MembershipType
            // 
            this.MembershipType.HeaderText = "Membresía";
            this.MembershipType.Name = "MembershipType";
            this.MembershipType.ReadOnly = true;
            this.MembershipType.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 50;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Location = new System.Drawing.Point(192, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(566, 377);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSearchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Clientes";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.gbResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.RadioButton rbFirstLastName;
        private System.Windows.Forms.RadioButton rbCardPassport;
        private System.Windows.Forms.RadioButton rbMembership;
        private System.Windows.Forms.RadioButton rbFirstName;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}