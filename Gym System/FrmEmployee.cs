using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Core;
using Core.Entities;
using Core.Entities.Employees;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmEmployee : FrmMaster
    {
        //Variables for Video Settings
        private bool existDevices = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;


        //Properties
        public Employee _Employee { get; set; }
        private Validation validation;


        //PRIVATE METHODS
        private void Save()
        {
            validation = new Validation();

            if (validation.Validate(this) && ValidateAge())
            {
                //Update the customer
                _Employee.FirstName = txtFirstName.Text;
                _Employee.MiddleName = txtMiddleName.Text;
                _Employee.FirstLastName = txtFirstLastName.Text;
                _Employee.SecondLastName = txtSecondLastName.Text;
                _Employee.BirthDate = dtpBirthDate.Value;
                _Employee.Gender = cbGender.SelectedItem.ToString();

                _Employee.CardPassport = txtCardPassport.Text;
                _Employee.Nationality = cbNationality.SelectedValue.ToString();

                _Employee.Telehone = txtTelephone.Text;
                _Employee.CellPhone = txtCellPhone.Text;
                _Employee.Email = txtEmail.Text;

                _Employee.City = cbCity.SelectedItem.ToString();
                _Employee.Country = cbCountry.SelectedValue.ToString();
                _Employee.Secction = txtSection.Text;
                _Employee.Street = txtStreet.Text;
                _Employee.House = txtHouse.Text;

                _Employee.JobPosition = cbJobPosition.SelectedItem.ToString();
                _Employee.Salary = decimal.Parse(txtSalary.Text);
                _Employee.DescriptionComments = txtDescriptionComments.Text;

                _Employee.Status = cbStatus.SelectedItem.ToString();

                _Employee.CreditLimit = decimal.Parse(txtCreditLimit.Text.Trim());

                _Employee.RegisterDate = DateTime.Now;

                _Employee.UserId = Usuario.CurrentUser.Id;

                _Employee.Save();

                //Save Photo
                SavePhoto();

                MessageBox.Show("Datos Guardados", "Aprovado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void SavePhoto()
        {
            if (pbPhoto.Image != pbPhoto.InitialImage)
            {
                pbPhoto.Image.Save(@"C:\Photos\" + _Employee.Id + ".Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void New()
        {
            validation = new Validation();
            validation.Clear(this);

            pbPhoto.Image = pbPhoto.InitialImage;

            //Initialize Customer
            _Employee = new Employee()
                {
                    Number = Employee.GetNextNumber()
                };

            //Next Number
            lblValueMemberNumber.Text = Employee.GetNextNumber().ToString("0000");
        }

        private void FillFields()
        {
            //Number
            lblValueMemberNumber.Text = _Employee.Number.ToString("0000");
            
            //Personal Data
            txtFirstName.Text = _Employee.FirstName;
            txtMiddleName.Text = _Employee.MiddleName;
            txtFirstLastName.Text = _Employee.FirstLastName;
            txtSecondLastName.Text = _Employee.SecondLastName;
            dtpBirthDate.Value = _Employee.BirthDate;
            cbGender.SelectedItem = _Employee.Gender;

            //Identification
            txtCardPassport.Text = _Employee.CardPassport;
            cbNationality.SelectedValue = _Employee.Nationality;

            //Contacts
            txtTelephone.Text = _Employee.Telehone;
            txtCellPhone.Text = _Employee.CellPhone;
            txtEmail.Text = _Employee.Email;

            //Address
            cbCountry.SelectedValue = _Employee.Country;
            cbCity.SelectedItem = _Employee.City;
            txtSection.Text = _Employee.Secction;
            txtStreet.Text = _Employee.Street;
            txtHouse.Text = _Employee.House;

            //Job Information
            cbJobPosition.SelectedItem = _Employee.JobPosition;
            txtSalary.Text = _Employee.Salary.ToString();
            txtDescriptionComments.Text = _Employee.DescriptionComments;

            cbStatus.SelectedItem = _Employee.Status;

            //Credit
            txtCreditLimit.Text = _Employee.CreditLimit.ToString();

            //Photo
            LoadPhoto();

        }

        private void LoadCountries()
        {
            cbCountry.DataSource = Country.Countries;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryName";

            cbCountry.SelectedIndex = -1;

            //Load Nationalities from countries
            List<Country> nationality = Country.Countries.ToList();

            cbNationality.DataSource = nationality;
            cbNationality.DisplayMember = "CountryName";
            cbNationality.ValueMember = "CountryName";

            cbNationality.SelectedIndex = -1;
        }

        private void LoadCities()
        {
            if (cbCountry.SelectedIndex != -1)
            {
                //Clear cbCity items
                cbCity.Items.Clear();

                var name = cbCountry.SelectedValue.ToString();

                //Fill cbCity
                foreach (var country in Country.Countries)
                {
                    if (country.CountryName == name)
                    {
                        foreach (var city in country.Cities)
                        {
                            cbCity.Items.Add(city.CityName);
                        }
                        break;
                    }
                }

                //Set cbCity index to -1 and clear text
                cbCity.SelectedIndex = -1;
                cbCity.Text = "";
            }
            else
            {
                cbCity.Items.Clear();
            }
        }

        private void LoadPhoto()
        {
            string strLocation = @"C:\Photos\" + _Employee.Id + ".Jpeg";

            if (File.Exists(strLocation))
            {
                pbPhoto.ImageLocation = strLocation;
            }
            else
            {
                pbPhoto.Image = pbPhoto.InitialImage;
            }
        }

        private void ShowCurrentUser()
        {
            lblUser.Text = Usuario.CurrentUser.UserName;
        }

        private void GetAge()
        {
            var birthDate = dtpBirthDate.Value;
            var now = DateTime.Now;

            //if ((now.Month < birthDate.Month) || (now.Month == birthDate.Month && now.Day < birthDate.Day) )
            //{
            var age = now.Year - birthDate.Year;
            lblAgeValue.Text = age.ToString();
            //}
        }

        private bool ValidateAge()
        {
            if (dtpBirthDate.Value.Year >= DateTime.Now.Year)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la actual", "Fecha no válida",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SwitchCam()
        {
            if (ckbSwitchCam.Checked)
            {
                btnPhoto.Visible = false;
                btnVideo.Visible = true;
                cbDevices.Visible = true;
                btnVideo.Text = "Iniciar";
            }
            else
            {
                btnPhoto.Visible = true;
                btnVideo.Visible = false;
                cbDevices.Visible = false;
                FinishVideoSource();
                btnVideo.Text = "Tomar Foto";
            }
        }

        private void SetDefaultCountry()
        {
            cbCountry.SelectedValue = "República Dominicana";
            cbNationality.SelectedValue = "República Dominicana";
        }
        
        
        //Class Constructor
        public FrmEmployee()
        {
            InitializeComponent();

            //Initialize Customer and set the fields
            New();

            //Load Countries
            LoadCountries();

            //Show CurrentUser
            ShowCurrentUser();

            //Search Video Devices
            SearchDevices();

            //Set default country
            SetDefaultCountry();

            //Next Number
            lblValueMemberNumber.Text = Employee.GetNextNumber().ToString("0000");
        }


        #region //Methods to load Cam Devices

        public void LoadDevices(FilterInfoCollection dispositivos)
        {
            for (int i = 0; i < dispositivos.Count; i++)
                cbDevices.Items.Add(dispositivos[i].Name.ToString());
            cbDevices.Text = cbDevices.Items[0].ToString();
        }

        public void SearchDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
                existDevices = false;
            else
            {
                existDevices = true;
                LoadDevices(videoDevices);
            }
        }

        public void FinishVideoSource()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pbPhoto.Image = imagen;
        }
        #endregion

        //Controls Methods
        private void txtSalary_Click(object sender, EventArgs e)
        {
            txtSalary.Select(0, 0);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new FrmSearchEmployee();

            if (search.ShowDialog() == DialogResult.OK)
            {
                _Employee = search._Employee;
                FillFields();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            GetAge();
        }

        private void txtTelephone_Click(object sender, EventArgs e)
        {
            txtTelephone.Select(0, 0);
        }

        private void txtCellPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtCellPhone.Select(0, 0); 
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Title = "Abrir Foto",
                Filter = "Archivo de imagen (*.jpg, *.png)|*.jpg;*.png",

            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.ImageLocation = openFile.FileName;
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            if (btnVideo.Text == "Iniciar")
            {
                if (existDevices)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cbDevices.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    videoSource.Start();
                    btnVideo.Text = "Tomar Foto";
                    cbDevices.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error: No se encontraron dispositivos.");
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    FinishVideoSource();
                    btnVideo.Text = "Iniciar";
                    cbDevices.Enabled = true;
                }
            }
        }

        private void FrmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinishVideoSource();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void cbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchCam();
        }
    }
}
