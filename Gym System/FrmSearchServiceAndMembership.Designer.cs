namespace GYM_System
{
    partial class FrmSearchServiceAndMembership
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
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.gbMembership = new System.Windows.Forms.GroupBox();
            this.lbMembership = new System.Windows.Forms.ListBox();
            this.rbServices = new System.Windows.Forms.RadioButton();
            this.rbMembership = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbMembership.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(98, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 38);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Servicios y Membresías";
            // 
            // gbServices
            // 
            this.gbServices.Location = new System.Drawing.Point(12, 85);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(264, 190);
            this.gbServices.TabIndex = 7;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Servicios:";
            // 
            // gbMembership
            // 
            this.gbMembership.Controls.Add(this.lbMembership);
            this.gbMembership.Enabled = false;
            this.gbMembership.Location = new System.Drawing.Point(292, 85);
            this.gbMembership.Name = "gbMembership";
            this.gbMembership.Size = new System.Drawing.Size(266, 190);
            this.gbMembership.TabIndex = 8;
            this.gbMembership.TabStop = false;
            this.gbMembership.Text = "Membresías:";
            // 
            // lbMembership
            // 
            this.lbMembership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMembership.FormattingEnabled = true;
            this.lbMembership.Location = new System.Drawing.Point(3, 16);
            this.lbMembership.Name = "lbMembership";
            this.lbMembership.Size = new System.Drawing.Size(260, 171);
            this.lbMembership.TabIndex = 0;
            // 
            // rbServices
            // 
            this.rbServices.AutoSize = true;
            this.rbServices.Checked = true;
            this.rbServices.Location = new System.Drawing.Point(12, 62);
            this.rbServices.Name = "rbServices";
            this.rbServices.Size = new System.Drawing.Size(63, 17);
            this.rbServices.TabIndex = 9;
            this.rbServices.TabStop = true;
            this.rbServices.Text = "Servicio";
            this.rbServices.UseVisualStyleBackColor = true;
            this.rbServices.CheckedChanged += new System.EventHandler(this.rbServices_CheckedChanged);
            // 
            // rbMembership
            // 
            this.rbMembership.AutoSize = true;
            this.rbMembership.Location = new System.Drawing.Point(292, 62);
            this.rbMembership.Name = "rbMembership";
            this.rbMembership.Size = new System.Drawing.Size(78, 17);
            this.rbMembership.TabIndex = 10;
            this.rbMembership.Text = "Membresía";
            this.rbMembership.UseVisualStyleBackColor = true;
            this.rbMembership.CheckedChanged += new System.EventHandler(this.rbMembership_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnOk.Location = new System.Drawing.Point(170, 284);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 40);
            this.btnOk.TabIndex = 36;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnCancel.Location = new System.Drawing.Point(296, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmSearchServiceAndMembership
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(567, 336);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rbMembership);
            this.Controls.Add(this.rbServices);
            this.Controls.Add(this.gbMembership);
            this.Controls.Add(this.gbServices);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmSearchServiceAndMembership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Servicios y Membresías";
            this.gbMembership.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.GroupBox gbMembership;
        private System.Windows.Forms.RadioButton rbServices;
        private System.Windows.Forms.RadioButton rbMembership;
        private System.Windows.Forms.ListBox lbMembership;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}