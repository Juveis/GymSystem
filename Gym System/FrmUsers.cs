using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core;
using Core.Entidades.Seguridad;
using Core.Entidades.Seguridad.Enums;
using Core.Entities.Employees;
using Core.Entities.Security;
using Mongo.Entity;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace GYM_System
{
    public partial class FrmUsers : FrmMaster
    {
        //Properties
        public List<Usuario> Usuarios { get; set; }
        public Usuario User { get; set; }
        public Employee _Employee { get; set; }

        private Validation validation;
        private bool passwordChanged = false;
        
        //Class Constructor
        public FrmUsers()
        {
            InitializeComponent();

            //Show CurrentUser
            ShowCurrentUser();
        }


        //Private Methods

        private void LoadUsers()
        {
            lbUsuarios.Items.Clear();

            Usuarios = Usuario.ListaUsuarios();

            if (Usuarios.Count != 0)
            {
                foreach (var usuario in Usuarios)
                {
                    lbUsuarios.Items.Add(usuario);
                }
            }
        }

        private void ShowSelectedUser()
        {
            ClearFields();

            User = (Usuario)lbUsuarios.SelectedItem;

            txtUserName.Text = User.UserName;
            txtPassword.Text = User.Password;

            passwordChanged = false;

            GetEmployee();

            txtEmployee.Text = _Employee.FirstName + " " + _Employee.FirstLastName;

            cbStatus.SelectedItem = User.Status ? "Activo" : "Inactivo";
            lblValueRegisterDate.Text = User.RegisterDate.ToShortDateString();
            lblValueLastAccess.Text = User.LastAccess.ToShortDateString();

            foreach (var modulo in User.Modules)
            {
                for (int i = 0; i < clbPrivilegios.Items.Count; i++)
                {
                    if (clbPrivilegios.Items[i].ToString() == modulo.Nombre)
                    {
                        clbPrivilegios.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
        }

        private void Save()
        {
            validation = new Validation();

            if (validation.Validate(this))
            {
                User.UserName = txtUserName.Text.ToUpper();

                if (passwordChanged)
                {
                    User.Password = Encrypt.encrypt_using_sha256(txtPassword.Text.Trim());
                }

                User.IdEmployee = _Employee.Id;

                User.Status = cbStatus.SelectedItem.ToString() == "Activo" ? true : false;

                User.Modules = GetPrivileges();

                if (User.Id != null)
                {
                    User.RegisterDate = DateTime.Now;
                }

                User.Save();

                MessageBox.Show("Datos Guardados", "Aprovado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private List<Modulos> GetPrivileges()
        {
            var privilege = new List<Modulos>();

            foreach (var modulo in clbPrivilegios.CheckedItems)
            {
                privilege.Add(
                    new Modulos(modulo.ToString(), true)
                    );
            }

            return privilege;
        }

        private void ShowCurrentUser()
        {
            lblUser.Text = Usuario.CurrentUser.UserName;
        }

        private void GetEmployee()
        {
            _Employee = Employee.GetEmployeeById(User.IdEmployee);
        }

        private void ClearFields()
        {
            validation = new Validation();
            validation.Clear(this);

            passwordChanged = false;

            for (int i = 0; i < clbPrivilegios.Items.Count; i++)
            {
                clbPrivilegios.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        
        private void NewUser()
        {
            User = new Usuario();

            ClearFields();
        }


        //Controls Methods
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            LoadUsers();

            NewUser();
        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedUser();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewUser();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            var searchEmployee = new FrmSearchEmployee();
            if (searchEmployee.ShowDialog() == DialogResult.OK)
            {
                _Employee = searchEmployee._Employee;

                txtEmployee.Text = _Employee.FirstName + " " + _Employee.FirstLastName;
            }
            searchEmployee.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            LoadUsers();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            passwordChanged = true;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Select(0, txtPassword.Text.Length);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
