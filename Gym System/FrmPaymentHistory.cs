using System;
using System.Windows.Forms;
using Core.Entidades.Billing.Payments;
using Core.Entities.Members;
namespace GYM_System
{
    public partial class FrmPaymentHistory : Form
    {
        //Porperties


        //Variables
        private decimal totalAmount = 00;
        
        //Class Constructor
        public FrmPaymentHistory()
        {
            InitializeComponent();
        }
        

        //Private methods
        private void GetPaymentHistory()
        {
            if (cbViewBy.SelectedIndex != -1)
            {
                dgvPaymentsHistory.Rows.Clear();

                totalAmount = 00;
                
                var selection = cbViewBy.SelectedItem.ToString();

                try
                {
                    var collection = MembershipPayments.GetPaymentsHistory(selection);

                    foreach (var payments in collection)
                    {
                        //Get the member name
                        var member = Member.GetMembers("Membership", payments.MembershipNumber.ToString())[0];

                        //Add the row to the DGV
                        dgvPaymentsHistory.Rows.Add(payments.MembershipNumber.ToString("0000"),
                                                    member.FirstName + " " + member.FirstLastName,
                                                    //member.Membership,
                                                    payments.Amount.ToString("C")
                            );

                        //Get total amount
                        totalAmount += payments.Amount;
                    }

                    lblTotalValue.Text = totalAmount.ToString("C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void ShowPaymentHistory()
        {
            try
            {
                dgvPaymentsHistory.Rows.Clear();

                totalAmount = 00;
                
                var collection = MembershipPayments.GetPaymentsHistoryByDate(dtpStartDate.Value.Date, dtpEndDate.Value.Date.AddDays(1));

                foreach (var payments in collection)
                {
                    //Get the member name
                    var member = Member.GetMembers("Membership", payments.MembershipNumber.ToString())[0];

                    //Add the row to the DGV
                    dgvPaymentsHistory.Rows.Add(payments.MembershipNumber.ToString("0000"),
                                                member.FirstName + " " + member.FirstLastName,
                                                //member.Membership,
                                                payments.Amount.ToString("C")
                        );

                    //Get total amount
                    totalAmount += payments.Amount;
                }

                lblTotalValue.Text = totalAmount.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void FrmPaymentHistory_Load(object sender, EventArgs e)
        {
            
        }

        private void cbViewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPaymentHistory();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowPaymentHistory();
        }
    }
}
