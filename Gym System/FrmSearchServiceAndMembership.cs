using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Entidades.Billing;
using Core.Entities.Billing;
using Core.Entities.Members.Enums;

namespace GYM_System
{
    public partial class FrmSearchServiceAndMembership : Form
    {
        public FrmSearchServiceAndMembership()
        {
            InitializeComponent();

            LoadMemberships();
        }

        //Properties
        public List<MembershipType> MembershipList { get; set; }

        public MembershipType _Membership { get; set; }

        public BillDetail Detail { get; set; }


        //Methods
        private void ActivateDeActivate()
        {
            gbServices.Enabled = rbServices.Checked;

            gbMembership.Enabled = rbMembership.Checked;
        }

        private void LoadMemberships()
        {
            MembershipList = MembershipType.GetAll();
            lbMembership.DataSource = MembershipList;

            lbMembership.DisplayMember = "Type";
            lbMembership.ValueMember = "Price";
        }

        private void SetSelecction()
        {
            if (rbMembership.Checked && lbMembership.SelectedIndex != -1)
            {
                var membership = (MembershipType) lbMembership.SelectedItem;

                Detail = new BillDetail();
                Detail.SetMembership(membership);

                _Membership = membership;
            }

            this.Close();
        }


        private void rbServices_CheckedChanged(object sender, EventArgs e)
        {
            ActivateDeActivate();
        }

        private void rbMembership_CheckedChanged(object sender, EventArgs e)
        {
            ActivateDeActivate();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SetSelecction();
        }
    }
}
