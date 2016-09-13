using System;
using System.Linq;
using System.Windows.Forms;
using Core.Entidades.Billing.Payments;
using Core.Entities;
using Core.Entities.Accounting;
using Core.Entities.Employees;
using Core.Entities.Members;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmReceivePay : Form
    {
        public FrmReceivePay()
        {
            InitializeComponent();

            cbPaymentMethod.SelectedIndex = 0;
        }

        //Properties
        public Member _Member { get; set; }
        public Employee _Employee { get; set; }

        public AccountsReceivable Account { get; set; }


        //Private Methods
        private void SearchPerson()
        {
            if (cbPersonType.SelectedIndex != -1)
            {
                //Verify if customer is selected
                if (cbPersonType.SelectedItem.ToString() == "Cliente")
                {
                    var customer = new FrmSearchCustomer();

                    if (customer.ShowDialog() == DialogResult.OK)
                    {
                        _Member = customer._Customer;

                        if (SearchAccount())
                        {
                            var name = _Member.FirstName + " " + _Member.FirstLastName;
                            var number = _Member.Number;
                            var address = _Member.Secction + ", " + _Member.Street + ", " + _Member.House;
                            var phone = _Member.Telehone;

                            FillCustomerControls(name, number.ToString(), address, phone);

                            //Set employee to null
                            _Employee = null;
                        }
                    }
                }

                // Verify if employee is selected
                else if (cbPersonType.SelectedItem.ToString() == "Empleado")
                {
                    var employee = new FrmSearchEmployee();

                    if (employee.ShowDialog() == DialogResult.OK)
                    {
                        _Employee = employee._Employee;

                        if (SearchAccount())
                        {
                            _Employee = employee._Employee;

                            var name = _Employee.FirstName + " " + _Employee.FirstLastName;
                            var number = _Employee.Number;
                            var address = _Employee.Secction + ", " + _Employee.Street + ", " + _Employee.House;
                            var phone = _Employee.Telehone;

                            FillCustomerControls(name, number.ToString(), address, phone);

                            //Set customer to null
                            _Member = null;
                        }
                    }
                }
            }
        }

        private bool SearchAccount()
        {
            var type = "";
            var number = 0;
            
            if (cbPersonType.ToString() == "Cliente")
            {
                type = "Cliente";
                number = _Member.Number;
            }
            else
            {
                type = "Empleado";
                number = _Employee.Number;
            }

            var accounts = AccountsReceivable.GetAccountsReceivables(number, type);

            if (accounts.Count != 0)
            {
                Account = accounts[0];

                RefreshBalance();

                return true;
            }
            else
            {
                MessageBox.Show("Esta persona no tiene cuenta creada");
                return false;
            }
        }

        private void RefreshBalance()
        {
            lblBalanceValue.Text = Account.Balance.ToString("C");
            lblCreditValue.Text = Account.AccountStatuses.Sum(e => e.Credit).ToString("C");
            lblDebitValue.Text = Account.AccountStatuses.Sum(e => e.Debit).ToString("C");

            txtReceivedPay.Clear();
        }

        private void FillCustomerControls(string customer, string number, string address, string phone)
        {
            txtCustomer.Text = customer;
            txtPersonNumber.Text = number;
            txtAddress.Text = address;
            txtPhone.Text = phone;
        }

        private void Pay()
        {
            if (Account != null)
            {
                var received = decimal.Parse(txtReceivedPay.Text);

                if (received > 0)
                {
                    var status = Account.AccountStatuses;

                    status.Add(new AccountStatus()
                        {
                            Date = DateTime.Now,
                            Description = "Abono a cuenta",
                            Credit = received
                        });

                    Account.AccountStatuses = status;

                    Account.Save();

                    //Save the payment
                    SavePayment();
                    
                    RefreshBalance();

                    MessageBox.Show("Pago realizado", "Transacción realizada", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void SavePayment()
        {
            var employee = Employee.GetEmployeeById(Usuario.CurrentUser.IdEmployee);

            var person = _Member == null
                             ? string.Format("{0} {1}", _Employee.FirstName, _Employee.FirstLastName)
                             : string.Format("{0} {1}", _Member.FirstName, _Member.FirstLastName);

            var payment = new Payments()
                {
                    Number = Payments.GetNextNumber(),
                    Date = DateTime.Now,
                    AccounNumber = Account.AccountNumber,
                    Customer = person,
                    PayMethod = cbPaymentMethod.SelectedItem.ToString(),
                    DocNumber = txtDocumentNumber.Text,
                    Amount = decimal.Parse(txtReceivedPay.Text),
                    Cashier = string.Format("{0} {1}", employee.FirstName, employee.FirstLastName),
                    UserId = Usuario.CurrentUser.Id
                };

            payment.Save();

            //Print Payment
            Prints.PrintPayment(payment);
        }

        private void ActivateDocNumber()
        {
            if (cbPaymentMethod.SelectedIndex !=-1 && cbPaymentMethod.SelectedItem.ToString() == "Tarjeta")
            {
                lblDocumentNumber.Visible = true;
                txtDocumentNumber.Visible = true;
            }
            else
            {
                lblDocumentNumber.Visible = false;
                txtDocumentNumber.Visible = false;
            }

            txtDocumentNumber.CausesValidation = txtDocumentNumber.Visible;
        }


        //Control Methods
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            SearchPerson();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Pay();
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivateDocNumber();
        }
    }
}
