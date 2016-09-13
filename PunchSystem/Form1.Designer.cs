namespace PunchSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblValueCustomer = new System.Windows.Forms.Label();
            this.lblValueStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPhoto = new System.Windows.Forms.GroupBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tReset = new System.Windows.Forms.Timer(this.components);
            this.txtMembershipNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(545, 470);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(164, 67);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Socio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(276, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblValueCustomer
            // 
            this.lblValueCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValueCustomer.AutoSize = true;
            this.lblValueCustomer.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCustomer.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValueCustomer.Location = new System.Drawing.Point(704, 470);
            this.lblValueCustomer.Name = "lblValueCustomer";
            this.lblValueCustomer.Size = new System.Drawing.Size(254, 67);
            this.lblValueCustomer.TabIndex = 3;
            this.lblValueCustomer.Text = "*********";
            // 
            // lblValueStatus
            // 
            this.lblValueStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValueStatus.AutoSize = true;
            this.lblValueStatus.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValueStatus.Location = new System.Drawing.Point(722, 551);
            this.lblValueStatus.Name = "lblValueStatus";
            this.lblValueStatus.Size = new System.Drawing.Size(254, 67);
            this.lblValueStatus.TabIndex = 5;
            this.lblValueStatus.Text = "*********";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(545, 551);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(197, 67);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 67);
            this.label2.TabIndex = 6;
            this.label2.Text = "No. :";
            // 
            // gbPhoto
            // 
            this.gbPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbPhoto.Controls.Add(this.pbPhoto);
            this.gbPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhoto.Location = new System.Drawing.Point(12, 279);
            this.gbPhoto.Name = "gbPhoto";
            this.gbPhoto.Size = new System.Drawing.Size(454, 349);
            this.gbPhoto.TabIndex = 23;
            this.gbPhoto.TabStop = false;
            this.gbPhoto.Text = "Foto:";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPhoto.InitialImage")));
            this.pbPhoto.Location = new System.Drawing.Point(3, 22);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(448, 324);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 13;
            this.pbPhoto.TabStop = false;
            // 
            // tReset
            // 
            this.tReset.Interval = 5000;
            this.tReset.Tick += new System.EventHandler(this.tReset_Tick);
            // 
            // txtMembershipNumber
            // 
            this.txtMembershipNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMembershipNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.txtMembershipNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(80)))));
            this.txtMembershipNumber.Location = new System.Drawing.Point(743, 342);
            this.txtMembershipNumber.Name = "txtMembershipNumber";
            this.txtMembershipNumber.Size = new System.Drawing.Size(314, 116);
            this.txtMembershipNumber.TabIndex = 24;
            this.txtMembershipNumber.Click += new System.EventHandler(this.txtMembershipNumber_Click);
            this.txtMembershipNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMembershipNumber_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1122, 702);
            this.Controls.Add(this.txtMembershipNumber);
            this.Controls.Add(this.gbPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValueStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblValueCustomer);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblValueCustomer;
        private System.Windows.Forms.Label lblValueStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Timer tReset;
        private System.Windows.Forms.TextBox txtMembershipNumber;
    }
}

