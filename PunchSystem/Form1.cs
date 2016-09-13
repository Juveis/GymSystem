using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Core;
using System.Configuration;
using Core.Entities.Members;

namespace PunchSystem
{
    public partial class Form1 : Form
    {
        //Properties
        public Member _Customer { get; set; }

        //Constants
        private const string initialValue = "*********";
        
        
        //Class constructor
        public Form1()
        {
            InitializeComponent();
            string conn = ConfigurationManager.ConnectionStrings["copymongozionsystem"].ConnectionString;
            Initializer.InitializeMongoDb(conn);
        }

        
        //Private methods
        private void GetCustomer()
        {
            var collection = Member.GetMembers("Membership", txtMembershipNumber.Text);

            if (collection.Count != 0)
            {
                _Customer = collection[0];

                var validate = new ValidateCustomer();
                validate.Access(_Customer);

                lblValueCustomer.Text = _Customer.FirstName + " " + _Customer.FirstLastName;
                //lblValueStatus.Text = _Customer.State;
                ChangeColorStatus();

                LoadPhoto();
            }
            else
            {
                ResetValues();
                MessageBox.Show("Número de membresía no existe", "Vaidación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadPhoto()
        {
            string strLocation = @"C:\Photos\" + _Customer.Id + ".Jpeg";

            if (File.Exists(strLocation))
            {
                pbPhoto.ImageLocation = strLocation;
            }
            else
            {
                pbPhoto.Image = pbPhoto.InitialImage;
            }
        }

        private void ResetValues()
        {
            _Customer = null;
            pbPhoto.Image = null;

            lblValueCustomer.Text = initialValue;
            lblValueStatus.Text = initialValue;
            lblValueStatus.ForeColor = Color.SteelBlue;

            txtMembershipNumber.Clear();
        }

        private void ChangeColorStatus()
        {
            //if (_Customer.Membership.State == "Activa")
            //{
            //    lblValueStatus.ForeColor = Color.SteelBlue;
            //}
            //else
            //{
            //    lblValueStatus.ForeColor = Color.Red;
            //}
        }


        //Controls methods
        private void Form1_Load(object sender, EventArgs e)
        {
            //Focus TextBox
            txtMembershipNumber.Focus();
        }

        private void txtMembershipNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Stop timer
            tReset.Stop();
            
            if (e.KeyChar == 13)
            {
                var number = txtMembershipNumber.Text;
                if (!string.IsNullOrEmpty(number))
                {
                    if (number.Contains("."))
                    {
                        if (!ValidateEmployee.Validate(number))
                        {
                            MessageBox.Show("Número de empleado no es válido", "Número inválido", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        GetCustomer();
                    }
                }

                //Clear Texbox
                txtMembershipNumber.Clear();

                //Reset the controls every 5 secs
                tReset.Start();
            }
        }

        private void txtMembershipNumber_Click(object sender, EventArgs e)
        {
            txtMembershipNumber.Select(0,0);
        }

        private void tReset_Tick(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}
