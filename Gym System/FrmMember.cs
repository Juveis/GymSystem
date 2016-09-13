using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Core;
using Core.Entities;
using Core.Entities.Members;
using Core.Entities.Memberships;
using Core.Entities.Security;
using Core.Entities.Accounting;

namespace GYM_System
{
    public partial class FrmMember : FrmMaster
    {
        //Variables for Video Settings
        private bool existDevices = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        

        //Properties
        public Member _Member { get; set; }
        private Validation validation;

        public MembershipsPackages MemberMemberships { get; set; }


        //Constructor Class
        public FrmMember()
        {
            InitializeComponent();

            //Load Countries
            LoadCountries();

            //Show CurrentUser
            ShowCurrentUser();

            //Search Video Devices
            SearchDevices();

            //Set default country
            SetDefaultCountry();

            //Load Programs
            LoadMemberships();

            //Load Membership Satates
            LoadMembershipStates();

            //Initialize Customer and set the fields
            New();
        }

        
        //PRIVATE METHODS
        private void Save()
        {
            validation = new Validation();

            if (validation.Validate(this) && ValidateAge())
            {
                //Validate if the CardPassport exist
                if (Member.Exist(_Member, txtCardPassport.Text.Trim()))
                {
                    MessageBox.Show("Ya existe un cliente registrado con este número de Cédula/Pasaporte", "Duplicado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Save the customer
                    _Member.FirstName = txtFirstName.Text.Trim();
                    _Member.MiddleName = txtMiddleName.Text.Trim();
                    _Member.FirstLastName = txtFirstLastName.Text.Trim();
                    _Member.SecondLastName = txtSecondLastName.Text.Trim();
                    _Member.BirthDate = dtpBirthDate.Value;
                    _Member.Gender = cbGender.SelectedItem.ToString();

                    _Member.CardPassport = txtCardPassport.Text.Trim();
                    _Member.Nationality = cbNationality.SelectedValue.ToString();

                    _Member.Telehone = txtTelephone.Text;
                    _Member.CellPhone = txtCellPhone.Text;
                    _Member.Email = txtEmail.Text.Trim();

                    _Member.City = cbCity.SelectedItem.ToString();
                    _Member.Country = cbCountry.SelectedValue.ToString();
                    _Member.Secction = txtSection.Text;
                    _Member.Street = txtStreet.Text.Trim();
                    _Member.House = txtHouse.Text.Trim();

                    _Member.RegisterDate = DateTime.Now;

                    _Member.UserId = Usuario.CurrentUser.Id;

                    _Member.Save();

                    //Save Photo
                    SavePhoto();

                    MessageBox.Show("Datos Guardados", "Aprovado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void SavePhoto()
        {
            if (pbPhoto.Image != pbPhoto.InitialImage)
            {
                pbPhoto.Image.Save(@"C:\Photos\" + _Member.Id + ".Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void New()
        {
            lblValueMemberNumber.Text = Member.StrGetNextMemberNumber();

            pbPhoto.Image = pbPhoto.InitialImage;

            //Initialize Customer
            _Member = new Member
                {
                    Number = Member.GetNextMemberNumber()
                };

            //Set default country
            SetDefaultCountry();

            LoadMembershipsPackages();
        }

        private void Search()
        {
            var searchValue = txtSearch.Text;

            if (!string.IsNullOrEmpty(searchValue)) return;
            _Member = Member.GetMembers("Number", searchValue)[0];
            FillFields();
        }

        private void Search(int number)
        {
            _Member = Member.GetMember(number);
            FillFields();
        }

        private void FillFields()
        {
            //Personal Data
            txtFirstName.Text = _Member.FirstName;
            txtMiddleName.Text = _Member.MiddleName;
            txtFirstLastName.Text = _Member.FirstLastName;
            txtSecondLastName.Text = _Member.SecondLastName;
            dtpBirthDate.Value = _Member.BirthDate;
            cbGender.SelectedItem = _Member.Gender;

            //Identification
            txtCardPassport.Text = _Member.CardPassport;
            cbNationality.SelectedValue = _Member.Nationality;

            //Contacts
            txtTelephone.Text = _Member.Telehone;
            txtCellPhone.Text = _Member.CellPhone;
            txtEmail.Text = _Member.Email;

            //Address
            cbCountry.SelectedValue = _Member.Country;
            cbCity.SelectedItem = _Member.City;
            txtSection.Text = _Member.Secction;
            txtStreet.Text = _Member.Street;
            txtHouse.Text = _Member.House;

            //Photo
            LoadPhoto();

            //Load Memberships
            LoadMembershipsPackages();

            //Load AnthropometricMeasurements
            LoadAnthropometricMeasurements();

            //Load Accounts
            LoadAccountsAndPayments();

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

        private void LoadMemberships()
        {
            var memberships = Membership.GetAll();

            cbMembershipName.DataSource = memberships;
            cbMembershipName.DisplayMember = "Name";
            cbMembershipName.ValueMember = "Number";
        }

        private void LoadMembershipsPackages()
        {
            if (_Member != null && _Member.Number != 0)
            {
                MemberMemberships = MembershipsPackages.GerMembershipsPackages(_Member.Number);

                if (MemberMemberships == null)
                {
                    MemberMemberships = new MembershipsPackages();
                }

                dgvMemberships.DataSource = MemberMemberships.PackagessList;

            }
        }

        private void LoadAnthropometricMeasurements()
        {
            if (_Member.AnthropometricMeasurementses == null)
            {
                _Member.AnthropometricMeasurementses = new List<AnthropometricMeasurements>();
            }

            dgvAnthropometricMeasurements.DataSource = _Member.AnthropometricMeasurementses;
        }

        private void LoadPhoto()
        {
            string strLocation = @"C:\Photos\" + _Member.Id + ".Jpeg";
            
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
                btnVideo.Visible = true;
                cbDevices.Visible = true;
                btnVideo.Text = "Iniciar";
            }
            else
            {
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

        private void LoadMembershipStates()
        {
            cbMembershipState.DataSource = new BindingSource(Packages.States, null);
            cbMembershipState.DisplayMember = "Key";
            cbMembershipState.ValueMember = "Value";

            cbMembershipState.SelectedIndex = -1;
        }

        private void LoadAccountsAndPayments()
        {
            //Load accounts
            var account = AccountsReceivable.GetAccount("Member", _Member.Number);

            if (account != null)
            {
                txtBalance.Text = account.Balance.ToString("C");
            }
            else
            {
                txtBalance.Text = "0";
            }

            //LoadPayments

        }

        private void NewMembership()
        {
            if (MemberMemberships != null)
            {
                dgvMemberships.Enabled = false;

                cbMembershipName.SelectedIndex = -1;
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now;
                txtNotes.Clear();
                txtVisits.Clear();
                txtMembershipCost.Clear();
                txtRenewals.Clear();
            }
        }

        private void SaveNewMembership()
        {
            if (cbMembershipName.SelectedIndex == -1 || !(dtpStartDate.Value >= DateTime.Now && dtpEndDate.Value > DateTime.Now) ||
                string.IsNullOrEmpty(txtNotes.Text) || string.IsNullOrEmpty(txtVisits.Text) || string.IsNullOrEmpty(txtMembershipCost.Text) ||
                string.IsNullOrEmpty(txtRenewals.Text) || cbMembershipState.SelectedIndex == -1)
            {
                MessageBox.Show("Favor llenar los campos requeridos", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MemberMemberships.PackagessList.Add(
                    new Packages()
                    {
                        MembershipNumber = (int)cbMembershipName.SelectedValue,
                        EndDate = dtpEndDate.Value,
                        StartDate = dtpStartDate.Value,
                        Notes = txtNotes.Text.Trim(),
                        MembershipCost = decimal.Parse(txtMembershipCost.Text),
                        RegisterDate = DateTime.Now,
                        State = (int)cbMembershipState.SelectedValue
                    }
                    
                    );
                
                //Save Changes
                MemberMemberships.Save();

                dgvMemberships.DataSource = MemberMemberships.PackagessList;
            }

                //Clear controls
                cbMembershipName.SelectedIndex = -1;
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now;
                txtNotes.Clear();
                txtVisits.Clear();
                txtRenewals.Clear();
                txtMembershipCost.Clear();
                cbMembershipState.SelectedIndex = -1;
        }

        private void AddNewAnthropometricMeasurements()
        {
            if (_Member.AnthropometricMeasurementses == null)
            {
                _Member.AnthropometricMeasurementses = new List<AnthropometricMeasurements>();
            }

            if (string.IsNullOrEmpty(txtRightArm.Text) || string.IsNullOrEmpty(txtLeftArm.Text) || string.IsNullOrEmpty(txtChest.Text) || string.IsNullOrEmpty(txtWaist.Text) ||
                string.IsNullOrEmpty(txtWeight.Text) || string.IsNullOrEmpty(txtAbdomen.Text) || string.IsNullOrEmpty(txtLefThigh.Text) || string.IsNullOrEmpty(txtRightThigh.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                var rightArm = double.Parse(txtRightArm.Text);
                var leftArm = double.Parse(txtLeftArm.Text);
                var chest = double.Parse(txtChest.Text);
                var waist = double.Parse(txtWaist.Text);
                var weight = double.Parse(txtWeight.Text);
                var abdomen = double.Parse(txtAbdomen.Text);
                var leftThigh = double.Parse(txtLefThigh.Text);
                var rightThigh = double.Parse(txtRightThigh.Text);


                _Member.AnthropometricMeasurementses.Add(
                    new AnthropometricMeasurements()
                    {
                        RightArm = rightArm,
                        LeftArm = leftArm,
                        Chest = chest,
                        Waist = waist,
                        Weight = weight,
                        Abdomen = abdomen,
                        LeftThigh = leftThigh,
                        RightThigh = rightThigh,
                        RegisterDate = DateTime.Now
                    }
                    );

                LoadAnthropometricMeasurementses();
            }
        }

        private void LoadAnthropometricMeasurementses()
        {
            dgvAnthropometricMeasurements.DataSource = _Member.AnthropometricMeasurementses;
        }


        //Controls Methods
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Clear Controls
            validation = new Validation();
            validation.Clear(this);

            New();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            GetAge();
        }

        private void txtTelephone_Click(object sender, EventArgs e)
        {
            txtTelephone.Select(0,0);
        }

        private void txtCellPhone_Click(object sender, EventArgs e)
        {
            txtCellPhone.Select(0,0);
        }

        private void pbPhoto_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new FrmSearchCustomer();

            if (search.ShowDialog() == DialogResult.OK)
            {
                _Member = search._Customer;
                FillFields();
            }
        }

        private void ckbSwitchCam_CheckedChanged(object sender, EventArgs e)
        {
            SwitchCam();
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

        private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinishVideoSource();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Search();
            }
        }

        private void btnNextMember_Click(object sender, EventArgs e)
        {
            if (_Member == null) return;
            if (_Member.Number <= 1) return;
            var nextNumber = _Member.Number + 1;
            Search(nextNumber);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_Member == null) return;
            if (_Member.Number < 2) return;
            var nextNumber = _Member.Number - 1;
            Search(nextNumber);
        }

        private void btnNewMembership_Click(object sender, EventArgs e)
        {
            NewMembership();
        }

        private void btnSaveMembership_Click(object sender, EventArgs e)
        {
            SaveNewMembership();
        }

        private void btnSaveMeasures_Click(object sender, EventArgs e)
        {
            AddNewAnthropometricMeasurements();
        }

        #region // Search Text Box Methods

        public void TextGotFocus(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;

            if (txt.Text == "Buscar...")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;

            if (txt.Text == "")
            {
                txtSearch.Text = "Buscar...";
                txtSearch.ForeColor = Color.LightGray;
            }
        }
        #endregion

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

        //MenuStrip Methods
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtRightArm.Text, out amount))
            {
                txtRightArm.Text = amount.ToString();
            }
            else
            {
                txtRightArm.Clear();
            }
        }
        
    }
}
