namespace GYM_System
{
    partial class FrmUsers
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
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblValueLastAccess = new System.Windows.Forms.Label();
            this.lblUltimoAcceso = new System.Windows.Forms.Label();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.lblValueRegisterDate = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.gbPrivileges = new System.Windows.Forms.GroupBox();
            this.clbPrivilegios = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbUsers.SuspendLayout();
            this.gbDatosUsuario.SuspendLayout();
            this.gbPrivileges.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.lbUsuarios);
            this.gbUsers.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsers.Location = new System.Drawing.Point(12, 72);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(154, 227);
            this.gbUsers.TabIndex = 0;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Lista de Usuarios:";
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 19;
            this.lbUsuarios.Location = new System.Drawing.Point(6, 19);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(140, 194);
            this.lbUsuarios.TabIndex = 0;
            this.lbUsuarios.SelectedIndexChanged += new System.EventHandler(this.lbUsuarios_SelectedIndexChanged);
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.txtPassword);
            this.gbDatosUsuario.Controls.Add(this.lblPassword);
            this.gbDatosUsuario.Controls.Add(this.lblValueLastAccess);
            this.gbDatosUsuario.Controls.Add(this.lblUltimoAcceso);
            this.gbDatosUsuario.Controls.Add(this.btnSearchEmployee);
            this.gbDatosUsuario.Controls.Add(this.lblValueRegisterDate);
            this.gbDatosUsuario.Controls.Add(this.cbStatus);
            this.gbDatosUsuario.Controls.Add(this.txtUserName);
            this.gbDatosUsuario.Controls.Add(this.txtEmployee);
            this.gbDatosUsuario.Controls.Add(this.lblFechaRegistro);
            this.gbDatosUsuario.Controls.Add(this.lblEstado);
            this.gbDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.gbDatosUsuario.Controls.Add(this.lblEmpleado);
            this.gbDatosUsuario.Location = new System.Drawing.Point(172, 78);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Size = new System.Drawing.Size(340, 221);
            this.gbDatosUsuario.TabIndex = 1;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos del Usuario:";
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(147, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(6, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblValueLastAccess
            // 
            this.lblValueLastAccess.AutoSize = true;
            this.lblValueLastAccess.ForeColor = System.Drawing.Color.Black;
            this.lblValueLastAccess.Location = new System.Drawing.Point(144, 162);
            this.lblValueLastAccess.Name = "lblValueLastAccess";
            this.lblValueLastAccess.Size = new System.Drawing.Size(43, 13);
            this.lblValueLastAccess.TabIndex = 13;
            this.lblValueLastAccess.Text = "*********";
            // 
            // lblUltimoAcceso
            // 
            this.lblUltimoAcceso.AutoSize = true;
            this.lblUltimoAcceso.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoAcceso.ForeColor = System.Drawing.Color.Black;
            this.lblUltimoAcceso.Location = new System.Drawing.Point(6, 154);
            this.lblUltimoAcceso.Name = "lblUltimoAcceso";
            this.lblUltimoAcceso.Size = new System.Drawing.Size(109, 20);
            this.lblUltimoAcceso.TabIndex = 12;
            this.lblUltimoAcceso.Text = "Ultimo acceso:";
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(275, 18);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(40, 23);
            this.btnSearchEmployee.TabIndex = 2;
            this.btnSearchEmployee.Text = "***";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // lblValueRegisterDate
            // 
            this.lblValueRegisterDate.AutoSize = true;
            this.lblValueRegisterDate.ForeColor = System.Drawing.Color.Black;
            this.lblValueRegisterDate.Location = new System.Drawing.Point(144, 133);
            this.lblValueRegisterDate.Name = "lblValueRegisterDate";
            this.lblValueRegisterDate.Size = new System.Drawing.Size(43, 13);
            this.lblValueRegisterDate.TabIndex = 11;
            this.lblValueRegisterDate.Text = "*********";
            // 
            // cbStatus
            // 
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbStatus.Location = new System.Drawing.Point(147, 97);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(147, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // txtEmployee
            // 
            this.txtEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtEmployee.Location = new System.Drawing.Point(147, 19);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(121, 20);
            this.txtEmployee.TabIndex = 7;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblFechaRegistro.Location = new System.Drawing.Point(6, 125);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(137, 20);
            this.lblFechaRegistro.TabIndex = 5;
            this.lblFechaRegistro.Text = "Fecha de Registro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(6, 99);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNombreUsuario.Location = new System.Drawing.Point(6, 45);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(125, 20);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre Usuario:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(6, 19);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(78, 20);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // gbPrivileges
            // 
            this.gbPrivileges.Controls.Add(this.clbPrivilegios);
            this.gbPrivileges.Location = new System.Drawing.Point(522, 78);
            this.gbPrivileges.Name = "gbPrivileges";
            this.gbPrivileges.Size = new System.Drawing.Size(185, 186);
            this.gbPrivileges.TabIndex = 2;
            this.gbPrivileges.TabStop = false;
            this.gbPrivileges.Text = "Privilegios:";
            // 
            // clbPrivilegios
            // 
            this.clbPrivilegios.FormattingEnabled = true;
            this.clbPrivilegios.Items.AddRange(new object[] {
            "Clientes",
            "Seguridad",
            "Administración",
            "Facturación",
            "Inventario"});
            this.clbPrivilegios.Location = new System.Drawing.Point(6, 19);
            this.clbPrivilegios.Name = "clbPrivilegios";
            this.clbPrivilegios.Size = new System.Drawing.Size(168, 154);
            this.clbPrivilegios.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSave.Location = new System.Drawing.Point(309, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnCancel.Location = new System.Drawing.Point(454, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 49);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnNew.Location = new System.Drawing.Point(164, 322);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 49);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(73, 355);
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
            this.lblUserName.Location = new System.Drawing.Point(9, 355);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 16);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "Usuario:";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 389);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPrivileges);
            this.Controls.Add(this.gbDatosUsuario);
            this.Controls.Add(this.gbUsers);
            this.Name = "FrmUsuarios";
            this.Text = " Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.Controls.SetChildIndex(this.gbUsers, 0);
            this.Controls.SetChildIndex(this.gbDatosUsuario, 0);
            this.Controls.SetChildIndex(this.gbPrivileges, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.lblUser, 0);
            this.gbUsers.ResumeLayout(false);
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.gbPrivileges.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblValueRegisterDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.GroupBox gbPrivileges;
        private System.Windows.Forms.CheckedListBox clbPrivilegios;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblValueLastAccess;
        private System.Windows.Forms.Label lblUltimoAcceso;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserName;
    }
}