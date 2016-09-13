using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Core;
using Core.Entidades;
using Core.Entidades.Billing;
using Core.Entidades.Billing.Payments;
using Core.Entidades.Seguridad;
using Core.Entities;
using Core.Entities.Billing;
using Core.Entities.Employees;
using Core.Entities.Inventory;
using Core.Entities.Members;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();

            NewBill();

            LoadCurrentUser();

            SetGenericCustomer();
        }

        //Variables
        private Validation _validation;
        private decimal _received;
        private decimal _change;
        private decimal _subTotal;
        private decimal _itbis;
        private decimal _total;

        //Properties
        public Bill _Bill { get; set; }
        public BindingList<BillDetail> BindingListDetail { get; set; }
        public BindingSource Source { get; set; }
        public Member _Customer { get; set; }
        public Employee _Employee { get; set; }

        public FrmSearchServiceAndMembership serviceMembership { get; set; }

        //Private Methods
        private void LoadCurrentUser()
        {
            lblUser.Text = Usuario.CurrentUser.UserName;
        }

        private void LoadBillNumber()
        {
            lblNumberValue.Text = Bill.GetNextNumber();
        }

        private void NewBill()
        {
            _Customer = null;
            _Employee = null;

            _validation = new Validation();

            _validation.Clear(this);

            SetGenericCustomer();

            LoadBillNumber();

            _Bill = new Bill();

            SetGridViewDetail();

            ResetControls();
        }

        private void SetGridViewDetail()
        {
            _Bill.Details = new List<BillDetail>();

            BindingListDetail = new BindingList<BillDetail>(_Bill.Details);

            Source = new BindingSource(BindingListDetail, null);

            dgvDetails.DataSource = Source;

            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            //Set header text
            dgvDetails.Columns["BarCode"].HeaderText = "Código Barra";
            dgvDetails.Columns["Name"].HeaderText = "Nombre";
            dgvDetails.Columns["Description"].HeaderText = "Descripción";
            dgvDetails.Columns["Price"].HeaderText = "Precio";
            dgvDetails.Columns["ITBIS"].HeaderText = "ITBIS";
            dgvDetails.Columns["Quantity"].HeaderText = "Cantidad";
            dgvDetails.Columns["Total"].HeaderText = "Total";

            //Set Read Only
            dgvDetails.Columns["BarCode"].ReadOnly = true;
            dgvDetails.Columns["Name"].ReadOnly = true;
            dgvDetails.Columns["Description"].ReadOnly = true;
            dgvDetails.Columns["Price"].ReadOnly = true;
            dgvDetails.Columns["ITBIS"].ReadOnly = true;
            dgvDetails.Columns["Total"].ReadOnly = true;

            //Format currency
            dgvDetails.Columns["Price"].DefaultCellStyle.Format = "C";
            dgvDetails.Columns["ITBIS"].DefaultCellStyle.Format = "C";
            dgvDetails.Columns["Total"].DefaultCellStyle.Format = "C";
        }

        private void CalculateBill()
        {
            _itbis = 0;
            _subTotal = 0;
            _total = 0;
            
            foreach (var detail in _Bill.Details)
            {
                _total += detail.Total;
                _itbis += detail.ITBIS;
            }
            _subTotal = _total - _itbis;

            //Show the values
            lblSubTotalValue.Text = _subTotal.ToString("C");
            lblITBISValue.Text = _itbis.ToString("C");
            lblTotalValue.Text = _total.ToString("C");
        }

        private void SaveBill()
        {
            _validation = new Validation();

            if (_validation.Validate(this) && ValidatePayment() && ContainProducts() && !ExistMembership())
            {
                _Bill.Number = int.Parse(Bill.GetNextNumber());
                _Bill.Customer = txtCustomer.Text.Trim();
                _Bill.Address = txtAddress.Text.Trim();
                _Bill.Phone = txtPhone.Text;
                _Bill.Membersip = int.Parse(txtPersonNumber.Text.Trim() == "" ? "0" : txtPersonNumber.Text);

                _Bill.BillDate = dtpBillDate.Value;

                _Bill.CashRegister = null;
                _Bill.NCF = txtNCF.Text;

                _Bill.PaymentMethod = cbPayMethod.SelectedItem.ToString();
                _Bill.DocumentNumber = txtDocumentNumber.Text.Trim();
                _Bill.ReceivedPay = _received;
                _Bill.Change = _change;

                _Bill.ITBIS = _itbis;
                _Bill.SubTotal = _subTotal;
                _Bill.Total = _total;

                _Bill.Condition = cbCondition.SelectedItem.ToString();

                var employee = Employee.GetEmployeeById(Usuario.CurrentUser.IdEmployee);
                _Bill.Employee = employee.FirstName + " " + employee.FirstLastName;

                _Bill.UserId = Usuario.CurrentUser.Id;
                _Bill.RegisterDate = DateTime.Now;


                //Update product quantity in inventory
                foreach (var detail in _Bill.Details)
                {
                    var bar = detail.BarCode.Substring(0, 2);
                    if ( bar != "MB")
                    {
                        var code = int.Parse(detail.BarCode);
                        Product.UpdateProduct(code, detail.Quantity);
                    }
                }

                //Send to Accounts Receivable if credit
                SellByCredit();

                //Update membership Customer
                if (ExistMembership())
                {
                    var detail = _Bill.Details.Where(e => e.BarCode.Substring(0, 2) == "MB").ToList()[0];
                    MembershipPayments.Pay(_Customer, serviceMembership._Membership, detail.Quantity);
                }
            }
        }
        
        private bool ValidatePayment()
        {
            var pay = txtReceivedPay.Text.Trim();
            
            if (string.IsNullOrEmpty(pay))
            {
                return false;
            }
            else
            {
                _received = decimal.Parse(pay);

                if (cbPayMethod.SelectedItem.ToString() == "Tarjeta" || cbPayMethod.SelectedItem.ToString() == "Crédito")
                {
                    return true;
                }
                else if (_received < _total)
                {
                    MessageBox.Show("El monto ingresado es menor al monto total de la factura", "Monto no válido");
                    return false;
                }
                else
                {
                    _change = _received - _total;
                    lblChangeValue.Text = _change.ToString("C");
                    return true;
                }
            }
        }

        private void ResetControls()
        {
            lblChangeValue.Text = "$ 000.00";
            lblITBISValue.Text = "$ 000.00";
            lblSubTotalValue.Text = "$ 000.00";
            lblTotalValue.Text = "$ 000.00";

            _received = 0;
            _change = 0;
            _itbis = 0;
            _subTotal = 0;
            _total = 0;
        }

        private void CardCreditPayment()
        {
            if (cbPayMethod.SelectedIndex != -1)
            {
                if (cbPayMethod.SelectedItem.ToString() == "Tarjeta")
                {
                    lblDocumentNumber.Visible = true;
                    txtDocumentNumber.Visible = true;
                    txtDocumentNumber.CausesValidation = true;

                    txtReceivedPay.Text = _total.ToString();
                    txtReceivedPay.Enabled = false;
                }
                else if (cbPayMethod.SelectedItem.ToString() == "Crédito")
                {
                    txtReceivedPay.Text = 000.00.ToString("C");
                    txtReceivedPay.Enabled = false;
                    txtDocumentNumber.CausesValidation = false;
                }
                else
                {
                    lblDocumentNumber.Visible = false;
                    txtDocumentNumber.Visible = false;
                    txtDocumentNumber.CausesValidation = false;

                    txtReceivedPay.Clear();
                    txtReceivedPay.Enabled = true;
                }
            }
        }

        private bool ContainProducts()
        {
            if (_Bill.Details.Count != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Tiene que agregar almenos un producto", "Validación", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
        }

        private void CalculateChange()
        {
            var received = txtReceivedPay.Text.Trim();

            if (!string.IsNullOrEmpty(received))
            {
                var pay = decimal.Parse(received);

                lblChangeValue.Text = (_total - pay).ToString("C");
            }
        }

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
                        _Customer = customer._Customer;

                        //Disable customer controls
                        EnableDisableCustomerControls(false);

                        var name = _Customer.FirstName + " " + _Customer.FirstLastName;
                        var number = _Customer.Number;
                        var address = _Customer.Secction + ", " + _Customer.Street + ", " + _Customer.House;
                        var phone = _Customer.Telehone;

                        FillCustomerControls(name, number.ToString(), address, phone);

                        //Set employee to null
                        _Employee = null;
                    }
                }

                // Verify if employee is selected
                else if (cbPersonType.SelectedItem.ToString() == "Empleado")
                {
                    var employee = new FrmSearchEmployee();

                    if (employee.ShowDialog() == DialogResult.OK)
                    {
                        _Employee = employee._Employee;

                        //Disable customer controls
                        EnableDisableCustomerControls(false);

                        var name = _Employee.FirstName + " " + _Employee.FirstLastName;
                        var number = _Employee.Number;
                        var address = _Employee.Secction + ", " + _Employee.Street + ", " + _Employee.House;
                        var phone = _Employee.Telehone;

                        FillCustomerControls(name, number.ToString(), address, phone);

                        //Set customer to null
                        _Customer = null;
                    }
                }
            }
        }

        private void SearchItem()
        {
            var code = txtCode.Text.Trim();
            int number;

            //Search products
            if (code == "*")
            {
                var searchProduct = new FrmSearchProduct();

                if (searchProduct.ShowDialog() == DialogResult.OK)
                {
                    var detail = searchProduct.Detail;

                    _Bill.Details.Add(detail);

                    BindingListDetail = new BindingList<BillDetail>(_Bill.Details);

                    Source = new BindingSource(BindingListDetail, null);

                    dgvDetails.DataSource = Source;

                    FormatDataGridView();
                }
            }

            //Seach Services and Memberships 
            else if (code == "+")
            {
                serviceMembership = new FrmSearchServiceAndMembership();

                if (serviceMembership.ShowDialog() == DialogResult.OK && serviceMembership.Detail != null)
                {
                    var detail = serviceMembership.Detail;

                    _Bill.Details.Add(detail);

                    BindingListDetail = new BindingList<BillDetail>(_Bill.Details);

                    Source = new BindingSource(BindingListDetail, null);

                    dgvDetails.DataSource = Source;

                    FormatDataGridView();
                }
            }

            //Get product by barcode
            else if (int.TryParse(code, out number))
            {
               if (Product.ExistInStock(number))
                {
                    var detail = new BillDetail();

                    detail.SetProduct(number.ToString());
                    var qantity = int.Parse(txtQuantity.Text.Trim());
                    if (qantity > 1)
                        detail.Quantity = qantity;

                    _Bill.Details.Add(detail);

                    BindingListDetail = new BindingList<BillDetail>(_Bill.Details);

                    Source = new BindingSource(BindingListDetail, null);

                    dgvDetails.DataSource = Source;

                    FormatDataGridView();
                }
                
            }

            //Clear field
            txtCode.Clear();
            txtQuantity.Text = "1";

        }

        private void SetGenericCustomer()
        {
            cbCondition.SelectedIndex = 0;
            cbPersonType.SelectedIndex = 0;
            cbPayMethod.SelectedIndex = 0;

            txtQuantity.Text = "1";

            txtCode.Select();
        }

        private void ShowSearchPersonButton()
        {
            if (cbPersonType.SelectedIndex > 0)
            {
                var type = cbPersonType.SelectedItem.ToString();
                if (type == "Cliente" || type == "Empleado")
                {
                    btnSearchPerson.Visible = true;
                    txtPersonNumber.Visible = true;
                }
                else
                {
                    btnSearchPerson.Visible = false;
                    txtPersonNumber.Visible = false;
                }
            }
        }

        private void EnableDisableCustomerControls(bool _bool)
        {
            txtCustomer.Enabled = _bool;
            txtAddress.Enabled = _bool;
            txtPhone.Enabled = _bool;
        }

        private void FillCustomerControls(string customer, string number, string address, string phone)
        {
            txtCustomer.Text = customer;
            txtPersonNumber.Text = number;
            txtAddress.Text = address;
            txtPhone.Text = phone;
        }

        private void SellByCredit()
        {
            if (cbPayMethod.SelectedItem.ToString() == "Crédito")
            {
                var personType = cbPersonType.SelectedItem.ToString();
                
                //SellByCredit();
                if (personType == "Genérico")
                {
                    MessageBox.Show(@"No se puede aplicar crédito a un cliente genérico", @"Validación de crédito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (personType == "Cliente" && _Customer == null)
                {
                    MessageBox.Show(@"Seleccione un cliente para aplicar el crédito", @"Validación de cliente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (personType == "Empleado" && _Employee == null)
                {
                    MessageBox.Show(@"Seleccione un empleado para aplicar el crédito", @"Validación de empleado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    //Save the bill so it can credit.
                    _Bill.Save();
                    MessageBox.Show(@"Factura guardada", @"Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Proceed to performe the credit
                    if (personType == "Cliente")
                    {
                        Bill.SellByCredit(_Customer, _Bill.Number, _Bill.Total);
                    }
                    else
                    {
                        Bill.SellByCredit(_Employee, _Bill.Number, _Bill.Total);
                    }

                    MessageBox.Show(@"Crédito aplicado", @"Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (ckbPrintBill.Checked)
                    {
                        Prints.PrintBill(_Bill);
                        Prints.PrintBill(_Bill);
                    }

                    //New Bill
                    NewBill();
                }
                
            }
            else
            {
                _Bill.Save();
                MessageBox.Show(@"Factura guardada", @"Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ckbPrintBill.Checked)
                {
                    Prints.PrintBill(_Bill);
                }

                //New Bill
                NewBill();
            }
        }

        private bool ExistMembership()
        {
            var exist = _Bill.Details.Exists(e => e.BarCode.Substring(0, 2) == "MB");
            if (exist)
            {
                if (_Customer == null)
                {
                    MessageBox.Show("Seleccione un cliente para aplicar la membresía", "Inválido", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    exist = false;
                }
            }

            return exist;
        }

        private void ChangePersonType()
        {
            ShowSearchPersonButton();

            if (cbPersonType.SelectedIndex != -1)
            {
                if (cbPersonType.SelectedItem.ToString() == "Genérico")
                {
                    EnableDisableCustomerControls(true);

                    var name = "Genérico";
                    var number = "Genérico";
                    var address = "Genérico";
                    var phone = "(000)-000-0000";

                    FillCustomerControls(name, number, address, phone);

                    //Set to null objects Customer and Employee
                    _Customer = null;
                    _Employee = null;
                }
            }
        }

        //Controls Methods
        private void dgvDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateBill();
        }

        private void dgvDetails_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalculateBill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBill();
            //var bill = Bill.GetByNumber(293)[0];
            //Prints.PrintBill(bill);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewBill();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            CardCreditPayment();
        }

        private void dgvDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtReceivedPay_Leave(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            SearchPerson();
        }

        private void cbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePersonType();
        }

        private void txtReceivedPay_Click(object sender, EventArgs e)
        {
            txtReceivedPay.Select(0, txtReceivedPay.Text.Length + 1);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchItem();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchItem();
            }
        }

        private void dgvDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateBill();
        }

        private void txtReceivedPay_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void tsmPay_Click(object sender, EventArgs e)
        {
            var pay = new FrmReceivePay();
            pay.ShowDialog();
        }
        
    }
}
