namespace GYM_System
{
    partial class FrmCompanyInfo
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
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblHouse = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblContacts = new System.Windows.Forms.GroupBox();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtWebPage = new System.Windows.Forms.TextBox();
            this.lblWebPage = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtCommercialName = new System.Windows.Forms.TextBox();
            this.lblCommercialName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblRNC = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbAddress.SuspendLayout();
            this.lblContacts.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(254, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 38);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Compañía";
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.txtBuilding);
            this.gbAddress.Controls.Add(this.txtStreet);
            this.gbAddress.Controls.Add(this.txtSection);
            this.gbAddress.Controls.Add(this.cbCity);
            this.gbAddress.Controls.Add(this.cbCountry);
            this.gbAddress.Controls.Add(this.lblHouse);
            this.gbAddress.Controls.Add(this.lblStreet);
            this.gbAddress.Controls.Add(this.lblCity);
            this.gbAddress.Controls.Add(this.lblSection);
            this.gbAddress.Controls.Add(this.lblCountry);
            this.gbAddress.Location = new System.Drawing.Point(12, 163);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(314, 125);
            this.gbAddress.TabIndex = 6;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Dirección:";
            // 
            // txtBuilding
            // 
            this.txtBuilding.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBuilding.Location = new System.Drawing.Point(238, 95);
            this.txtBuilding.MaxLength = 15;
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(74, 20);
            this.txtBuilding.TabIndex = 4;
            // 
            // txtStreet
            // 
            this.txtStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtStreet.Location = new System.Drawing.Point(60, 93);
            this.txtStreet.MaxLength = 150;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(131, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // txtSection
            // 
            this.txtSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSection.Location = new System.Drawing.Point(60, 67);
            this.txtSection.MaxLength = 100;
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(236, 20);
            this.txtSection.TabIndex = 2;
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(60, 40);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(236, 21);
            this.cbCity.TabIndex = 1;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(60, 13);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(236, 21);
            this.cbCountry.TabIndex = 0;
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.BackColor = System.Drawing.Color.Transparent;
            this.lblHouse.ForeColor = System.Drawing.Color.Black;
            this.lblHouse.Location = new System.Drawing.Point(197, 97);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(44, 13);
            this.lblHouse.TabIndex = 16;
            this.lblHouse.Text = "Edificio:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.ForeColor = System.Drawing.Color.Black;
            this.lblStreet.Location = new System.Drawing.Point(6, 97);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(33, 13);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "Calle:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(6, 43);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "Ciudad:";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(6, 70);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(41, 13);
            this.lblSection.TabIndex = 17;
            this.lblSection.Text = "Sector:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(6, 16);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(32, 13);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "País:";
            // 
            // lblContacts
            // 
            this.lblContacts.Controls.Add(this.txtWebPage);
            this.lblContacts.Controls.Add(this.lblWebPage);
            this.lblContacts.Controls.Add(this.txtFax);
            this.lblContacts.Controls.Add(this.lblFax);
            this.lblContacts.Controls.Add(this.txtEmail);
            this.lblContacts.Controls.Add(this.txtCellPhone);
            this.lblContacts.Controls.Add(this.txtTelephone);
            this.lblContacts.Controls.Add(this.lblTelephone);
            this.lblContacts.Controls.Add(this.lblCellPhone);
            this.lblContacts.Controls.Add(this.lblEmail);
            this.lblContacts.Location = new System.Drawing.Point(374, 66);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(262, 161);
            this.lblContacts.TabIndex = 5;
            this.lblContacts.TabStop = false;
            this.lblContacts.Text = "Contactos:";
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFax.Location = new System.Drawing.Point(63, 76);
            this.txtFax.Mask = "(999) 000-0000";
            this.txtFax.Name = "txtFax";
            this.txtFax.PromptChar = ' ';
            this.txtFax.Size = new System.Drawing.Size(117, 20);
            this.txtFax.TabIndex = 2;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.BackColor = System.Drawing.Color.Transparent;
            this.lblFax.ForeColor = System.Drawing.Color.Black;
            this.lblFax.Location = new System.Drawing.Point(5, 80);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 13);
            this.lblFax.TabIndex = 12;
            this.lblFax.Text = "Fax:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmail.Location = new System.Drawing.Point(63, 101);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCellPhone.Location = new System.Drawing.Point(63, 49);
            this.txtCellPhone.Mask = "(999) 000-0000";
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.PromptChar = ' ';
            this.txtCellPhone.Size = new System.Drawing.Size(117, 20);
            this.txtCellPhone.TabIndex = 1;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTelephone.Location = new System.Drawing.Point(63, 19);
            this.txtTelephone.Mask = "(999) 000-0000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PromptChar = ' ';
            this.txtTelephone.Size = new System.Drawing.Size(117, 20);
            this.txtTelephone.TabIndex = 0;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelephone.ForeColor = System.Drawing.Color.Black;
            this.lblTelephone.Location = new System.Drawing.Point(5, 22);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(52, 13);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Teléfono:";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblCellPhone.ForeColor = System.Drawing.Color.Black;
            this.lblCellPhone.Location = new System.Drawing.Point(5, 52);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(42, 13);
            this.lblCellPhone.TabIndex = 8;
            this.lblCellPhone.Text = "Celular:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(5, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtWebPage
            // 
            this.txtWebPage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWebPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtWebPage.Location = new System.Drawing.Point(62, 126);
            this.txtWebPage.MaxLength = 80;
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.Size = new System.Drawing.Size(194, 20);
            this.txtWebPage.TabIndex = 13;
            // 
            // lblWebPage
            // 
            this.lblWebPage.AutoSize = true;
            this.lblWebPage.BackColor = System.Drawing.Color.Transparent;
            this.lblWebPage.ForeColor = System.Drawing.Color.Black;
            this.lblWebPage.Location = new System.Drawing.Point(5, 129);
            this.lblWebPage.Name = "lblWebPage";
            this.lblWebPage.Size = new System.Drawing.Size(58, 13);
            this.lblWebPage.TabIndex = 14;
            this.lblWebPage.Text = "Pág. Web:";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.textBox2);
            this.gbGeneral.Controls.Add(this.lblRNC);
            this.gbGeneral.Controls.Add(this.txtCommercialName);
            this.gbGeneral.Controls.Add(this.lblCommercialName);
            this.gbGeneral.Location = new System.Drawing.Point(12, 66);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(356, 91);
            this.gbGeneral.TabIndex = 7;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General:";
            // 
            // txtCommercialName
            // 
            this.txtCommercialName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCommercialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCommercialName.Location = new System.Drawing.Point(108, 23);
            this.txtCommercialName.MaxLength = 100;
            this.txtCommercialName.Name = "txtCommercialName";
            this.txtCommercialName.Size = new System.Drawing.Size(236, 20);
            this.txtCommercialName.TabIndex = 18;
            // 
            // lblCommercialName
            // 
            this.lblCommercialName.AutoSize = true;
            this.lblCommercialName.BackColor = System.Drawing.Color.Transparent;
            this.lblCommercialName.ForeColor = System.Drawing.Color.Black;
            this.lblCommercialName.Location = new System.Drawing.Point(6, 26);
            this.lblCommercialName.Name = "lblCommercialName";
            this.lblCommercialName.Size = new System.Drawing.Size(96, 13);
            this.lblCommercialName.TabIndex = 19;
            this.lblCommercialName.Text = "Nombre Comercial:";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(108, 52);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 20;
            // 
            // lblRNC
            // 
            this.lblRNC.AutoSize = true;
            this.lblRNC.BackColor = System.Drawing.Color.Transparent;
            this.lblRNC.ForeColor = System.Drawing.Color.Black;
            this.lblRNC.Location = new System.Drawing.Point(6, 52);
            this.lblRNC.Name = "lblRNC";
            this.lblRNC.Size = new System.Drawing.Size(33, 13);
            this.lblRNC.TabIndex = 21;
            this.lblRNC.Text = "RNC:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnClose.Location = new System.Drawing.Point(330, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSave.Location = new System.Drawing.Point(212, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(73, 350);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 16);
            this.lblUser.TabIndex = 30;
            this.lblUser.Text = "*******";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(9, 350);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 16);
            this.lblUserName.TabIndex = 29;
            this.lblUserName.Text = "Usuario:";
            // 
            // FrmCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(642, 375);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.gbAddress);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompanyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.lblContacts.ResumeLayout(false);
            this.lblContacts.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.GroupBox lblContacts;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCellPhone;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtWebPage;
        private System.Windows.Forms.Label lblWebPage;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.TextBox txtCommercialName;
        private System.Windows.Forms.Label lblCommercialName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRNC;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserName;
    }
}