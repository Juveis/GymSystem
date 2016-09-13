using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Entidades.Seguridad;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            txtUsuario.Select();
        }

        private void OK()
        {
            try
            {
                var user = txtUsuario.Text;
                var password = txtContrasena.Text;

                if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
                {
                    if (Authentication.Authenticate(user, password))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contrasena invalidos", "Validacion", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                        txtUsuario.Clear();
                        txtContrasena.Clear();

                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Favor introduzca usuario y contrasena", "Validacion", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Focus on user field
            txtUsuario.Focus();
            txtUsuario.Select(0,0);
        }
    }
}
