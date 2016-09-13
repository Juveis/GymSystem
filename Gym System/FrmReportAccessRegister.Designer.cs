namespace GYM_System
{
    partial class FrmReportAccessRegister
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
            this.gbGenerate = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbApproved = new System.Windows.Forms.ComboBox();
            this.lblApproved = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbAccess = new System.Windows.Forms.GroupBox();
            this.dgvAccess = new System.Windows.Forms.DataGridView();
            this.gbGenerate.SuspendLayout();
            this.gbAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGenerate
            // 
            this.gbGenerate.Controls.Add(this.cbApproved);
            this.gbGenerate.Controls.Add(this.lblApproved);
            this.gbGenerate.Controls.Add(this.lblStartDate);
            this.gbGenerate.Controls.Add(this.btnSearch);
            this.gbGenerate.Controls.Add(this.lblEndDate);
            this.gbGenerate.Controls.Add(this.dtpEndDate);
            this.gbGenerate.Controls.Add(this.dtpStartDate);
            this.gbGenerate.Location = new System.Drawing.Point(4, 62);
            this.gbGenerate.Name = "gbGenerate";
            this.gbGenerate.Size = new System.Drawing.Size(424, 81);
            this.gbGenerate.TabIndex = 43;
            this.gbGenerate.TabStop = false;
            this.gbGenerate.Text = "Filtros:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnPrint.Location = new System.Drawing.Point(4, 149);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(72, 29);
            this.btnPrint.TabIndex = 42;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbApproved
            // 
            this.cbApproved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApproved.FormattingEnabled = true;
            this.cbApproved.Items.AddRange(new object[] {
            "Ambos",
            "Si",
            "No"});
            this.cbApproved.Location = new System.Drawing.Point(309, 15);
            this.cbApproved.Name = "cbApproved";
            this.cbApproved.Size = new System.Drawing.Size(105, 23);
            this.cbApproved.TabIndex = 40;
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.BackColor = System.Drawing.Color.Transparent;
            this.lblApproved.ForeColor = System.Drawing.Color.Black;
            this.lblApproved.Location = new System.Drawing.Point(251, 20);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new System.Drawing.Size(56, 13);
            this.lblApproved.TabIndex = 41;
            this.lblApproved.Text = "Aprovado:";
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
            this.btnSearch.Location = new System.Drawing.Point(342, 48);
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
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(151, -2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(327, 45);
            this.lblTitulo.TabIndex = 44;
            this.lblTitulo.Text = "Reporte de Accesos";
            // 
            // gbAccess
            // 
            this.gbAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAccess.Controls.Add(this.dgvAccess);
            this.gbAccess.Location = new System.Drawing.Point(4, 183);
            this.gbAccess.Name = "gbAccess";
            this.gbAccess.Size = new System.Drawing.Size(619, 359);
            this.gbAccess.TabIndex = 45;
            this.gbAccess.TabStop = false;
            this.gbAccess.Text = "Accesos:";
            // 
            // dgvAccess
            // 
            this.dgvAccess.AllowUserToAddRows = false;
            this.dgvAccess.AllowUserToDeleteRows = false;
            this.dgvAccess.AllowUserToOrderColumns = true;
            this.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccess.Location = new System.Drawing.Point(3, 16);
            this.dgvAccess.Name = "dgvAccess";
            this.dgvAccess.ReadOnly = true;
            this.dgvAccess.Size = new System.Drawing.Size(613, 340);
            this.dgvAccess.TabIndex = 0;
            // 
            // FrmReportAccessRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(628, 542);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbAccess);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbGenerate);
            this.Name = "FrmReportAccessRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Acceso";
            this.gbGenerate.ResumeLayout(false);
            this.gbGenerate.PerformLayout();
            this.gbAccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenerate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbApproved;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.GroupBox gbAccess;
        private System.Windows.Forms.DataGridView dgvAccess;
        private System.Windows.Forms.Button btnPrint;
    }
}