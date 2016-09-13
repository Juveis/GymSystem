using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core;
using Core.Entidades.Seguridad;
using Core.Entities.Members.Enums;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmMembershipTypecs : Form
    {
        public List<MembershipType> MembershipTypes { get; set; }
        
        public FrmMembershipTypecs()
        {
            InitializeComponent();

            //Load MembershipType
            LoadMembershipTypes();

            //Show current user
            lblUser.Text = Usuario.CurrentUser.UserName;

            //Selec none membership
            lbMembershipType.SelectedIndex = -1;
        }

        //Private Methods
        private void LoadMembershipTypes()
        {
            try
            {
                MembershipTypes = MembershipType.GetAll();

                var bs = new BindingSource {DataSource = MembershipTypes};

                lbMembershipType.DataSource = bs;
                lbMembershipType.DisplayMember = "Type";
                lbMembershipType.ValueMember = "Price";

                lbMembershipType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void New()
        {
            gbMembershipType.Enabled = false;
            lbMembershipType.SelectedIndex = -1;

            gbMembershipDetails.Enabled = true;

            txtType.Clear();
            txtPrice.Clear();

            cbPeriod.SelectedIndex = 0;
        }

        private void Add()
        {
            var type = txtType.Text;
            var price = txtPrice.Text;
            var period = cbPeriod.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(price) && cbPeriod.SelectedIndex != -1)
            {
                if (lbMembershipType.SelectedIndex != -1)
                {
                    //This is to update the current Membership Type
                    var index = lbMembershipType.SelectedIndex;

                    MembershipTypes[index].Type = type;
                    MembershipTypes[index].Price = decimal.Parse(price);
                    MembershipTypes[index].Period = period;
                }
                else
                {
                    //Add the new one to the List (DataSource)
                    MembershipTypes.Add(
                        new MembershipType()
                        {
                            Type = type,
                            Price = decimal.Parse(price),
                            Period = cbPeriod.SelectedItem.ToString()
                        });
                }

                RefreshListBox();

                //Clear Texbox
                txtPrice.Clear();
                txtType.Clear();

                cbPeriod.SelectedIndex = -1;

                gbMembershipType.Enabled = true;

                gbMembershipDetails.Enabled = false;
            }
        }

        private void Remove()
        {
            if (lbMembershipType.SelectedIndex != -1)
            {
                var type = (MembershipType) lbMembershipType.SelectedItem;

                MembershipTypes.Remove(type);

                type.Remove();

                RefreshListBox();

                //Clear TextBox
                txtPrice.Clear();
                txtType.Clear();

                cbPeriod.SelectedIndex = -1;
            }
        }

        private void Edit()
        {
            if (lbMembershipType.SelectedIndex != -1)
            {
                gbMembershipDetails.Enabled = true;
                gbMembershipType.Enabled = false;
            }
        }

        private void SaveChanges()
        {
            foreach (var membershipType in MembershipTypes)
            {
                membershipType.Save();
            }
        }

        private void ShowInformation()
        {
            if (lbMembershipType.SelectedIndex != -1)
            {
                txtPrice.Clear();
                txtType.Clear();
                cbPeriod.SelectedIndex = -1;

                var membership = (MembershipType) lbMembershipType.SelectedItem;

                txtType.Text = membership.Type;
                txtPrice.Text = membership.Price.ToString();
                cbPeriod.SelectedItem = membership.Period;
            }
            else
            {
                txtPrice.Clear();
                txtType.Clear();
                cbPeriod.SelectedIndex = -1;
            }
        }

        private void RefreshListBox()
        {
            //Refresh the listbox with the datasource
            ((CurrencyManager)lbMembershipType.BindingContext[lbMembershipType.DataSource]).Refresh();
        }
        
        //Controls Methods

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void lbMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInformation();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           New();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveChanges();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Select(0,0);
        }

        private void FrmMembershipTypecs_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }


    }
}
