using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Entities.Members;

namespace GYM_System
{
    public partial class FrmSearchCustomer : Form
    {
        public Member _Customer { get; set; }

        private List<Member> customersList; 
        
        //Constructor Class
        public FrmSearchCustomer()
        {
            InitializeComponent();
        }

        
        //Private Methods
        private void Search()
        {
            foreach (RadioButton radio in gbFilters.Controls)
            {
                if (radio.Checked)
                {
                    var lenth = radio.Name.Length;
                    var field = radio.Name.Substring(2);
                    var value = txtSearch.Text;

                    if (field == "Todos")
                    {
                        customersList = Member.GetAll();
                        ListToDataTable();
                    }
                    else
                    {
                        customersList = Member.GetMembers(field, value);
                        ListToDataTable();
                    }
                    
                }
            }
        }

        private void ListToDataTable()
        {
            dgvResults.Rows.Clear();
            
            if (customersList != null)
            {
                foreach (var customer in customersList)
                {
                    dgvResults.Rows.Add(
                        customer,
                        customer.Number,
                        customer.FirstName,
                        customer.FirstLastName
                        //customer.Membership,
                        //customer.Membership.State
                        );
                }
            }
        }

        //Control Methods
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _Customer = (Member) dgvResults.SelectedRows[0].Cells["CustomerObject"].Value;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Search();
            }
        }
    }
}
