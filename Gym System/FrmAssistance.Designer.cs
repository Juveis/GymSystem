namespace GYM_System
{
    partial class FrmAssistance
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbAccess = new System.Windows.Forms.GroupBox();
            this.dgvAccess = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGetRecord = new System.Windows.Forms.Timer(this.components);
            this.gbPhoto = new System.Windows.Forms.GroupBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.gbAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).BeginInit();
            this.gbPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(193, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(366, 55);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Asistencia del día";
            // 
            // gbAccess
            // 
            this.gbAccess.Controls.Add(this.dgvAccess);
            this.gbAccess.Location = new System.Drawing.Point(18, 251);
            this.gbAccess.Name = "gbAccess";
            this.gbAccess.Size = new System.Drawing.Size(729, 330);
            this.gbAccess.TabIndex = 4;
            this.gbAccess.TabStop = false;
            this.gbAccess.Text = "Accesos:";
            // 
            // dgvAccess
            // 
            this.dgvAccess.AllowUserToAddRows = false;
            this.dgvAccess.AllowUserToDeleteRows = false;
            this.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Hour,
            this.Membership,
            this.FirstName,
            this.FirstLastName,
            this.Aproved});
            this.dgvAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccess.Location = new System.Drawing.Point(3, 16);
            this.dgvAccess.Name = "dgvAccess";
            this.dgvAccess.ReadOnly = true;
            this.dgvAccess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccess.Size = new System.Drawing.Size(723, 311);
            this.dgvAccess.TabIndex = 0;
            this.dgvAccess.SelectionChanged += new System.EventHandler(this.dgvAccess_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Hour
            // 
            this.Hour.HeaderText = "Hora";
            this.Hour.Name = "Hour";
            this.Hour.ReadOnly = true;
            // 
            // Membership
            // 
            this.Membership.HeaderText = "No. Membresía";
            this.Membership.Name = "Membership";
            this.Membership.ReadOnly = true;
            this.Membership.Width = 70;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Nombre";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 200;
            // 
            // FirstLastName
            // 
            this.FirstLastName.HeaderText = "Apellido";
            this.FirstLastName.Name = "FirstLastName";
            this.FirstLastName.ReadOnly = true;
            this.FirstLastName.Width = 200;
            // 
            // Aproved
            // 
            this.Aproved.HeaderText = "Aprobado";
            this.Aproved.Name = "Aproved";
            this.Aproved.ReadOnly = true;
            // 
            // tGetRecord
            // 
            this.tGetRecord.Interval = 1000;
            this.tGetRecord.Tick += new System.EventHandler(this.tGetRecord_Tick);
            // 
            // gbPhoto
            // 
            this.gbPhoto.Controls.Add(this.pbPhoto);
            this.gbPhoto.Location = new System.Drawing.Point(15, 60);
            this.gbPhoto.Name = "gbPhoto";
            this.gbPhoto.Size = new System.Drawing.Size(240, 185);
            this.gbPhoto.TabIndex = 22;
            this.gbPhoto.TabStop = false;
            this.gbPhoto.Text = "Foto:";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPhoto.Location = new System.Drawing.Point(3, 16);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(234, 166);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 13;
            this.pbPhoto.TabStop = false;
            // 
            // FrmAssistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(753, 593);
            this.Controls.Add(this.gbPhoto);
            this.Controls.Add(this.gbAccess);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssistance";
            this.Text = "Asistencia del día";
            this.Load += new System.EventHandler(this.FrmRegisterAccess_Load);
            this.gbAccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).EndInit();
            this.gbPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbAccess;
        private System.Windows.Forms.DataGridView dgvAccess;
        private System.Windows.Forms.Timer tGetRecord;
        private System.Windows.Forms.GroupBox gbPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membership;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aproved;
    }
}