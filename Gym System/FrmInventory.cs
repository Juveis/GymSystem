using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Core;
using Core.Entities;
using Core.Entities.Inventory;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmInventory : Form
    {
        //Constructor Class
        public FrmInventory()
        {
            InitializeComponent();

            //Load Countries
            LoadCountries();

            //Load Suppliers
            LoadSuppliers();
            
            SupplierBindControls();

            FormatSupplierDataGridView();

            //Load Product stuffs
            LoadPrudctStuffs();

            //Load Equipment stuffs
            LoadEquipmentStuffs();

            //Show current user
            LoadCurrentUser();
        }

        private new Validation Validate { get; set; }

        private void LoadCurrentUser()
        {
            lblUser.Text = Usuario.CurrentUser.UserName;
        }

        #region Supplier
        //Properties
        private List<Supplier> Suppliers { get; set; }
        private Supplier _Supplier { get; set; }

        private BindingList<Supplier> SupplierBindingList { get; set; }
        private BindingSource SupplierSource { get; set; }


        //Private methods
        private void LoadCountries()
        {
            cbCountry.DataSource = Country.Countries;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryName";

            cbCountry.SelectedValue = "República Dominicana";
        }

        private void LoadCities()
        {
            if (cbCountry.SelectedIndex != -1)
            {
                var name = cbCountry.SelectedValue.ToString();

                //Set data source
                cbCity.DataSource = ((Country) cbCountry.SelectedItem).Cities;
                cbCity.DisplayMember = "CityName";
                cbCity.ValueMember = "CityName";
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                Suppliers = Supplier.GetAll();

                if (Suppliers != null)
                {
                    SupplierBindingList = new BindingList<Supplier>(Suppliers);

                    SupplierSource = new BindingSource(SupplierBindingList, null);

                    dgvSuppliers.DataSource = SupplierSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatSupplierDataGridView()
        {
            //Invisible fields
            dgvSuppliers.Columns["Id"].Visible = false;

            dgvSuppliers.Columns["Country"].Visible = false;
            dgvSuppliers.Columns["City"].Visible = false;
            dgvSuppliers.Columns["Secction"].Visible = false;
            dgvSuppliers.Columns["Street"].Visible = false;
            dgvSuppliers.Columns["Building"].Visible = false;
            dgvSuppliers.Columns["UserId"].Visible = true;
            

            //Header text to show
            dgvSuppliers.Columns["Code"].HeaderText = "Cod.";
            dgvSuppliers.Columns["CompanyName"].HeaderText = "Compañía";
            dgvSuppliers.Columns["ContactName"].HeaderText = "Representante";
            dgvSuppliers.Columns["TitleContactName"].HeaderText = "Cargo";
            dgvSuppliers.Columns["Rnc"].HeaderText = "RNC";
            dgvSuppliers.Columns["Telephone"].HeaderText = "Teléfono";
            dgvSuppliers.Columns["CellPhone"].HeaderText = "Celular";
            dgvSuppliers.Columns["Fax"].HeaderText = "Fax";
            dgvSuppliers.Columns["Email"].HeaderText = "Email";
            dgvSuppliers.Columns["RegisterDate"].HeaderText = "Fecha Registro";
            dgvSuppliers.Columns["UserId"].HeaderText = "Usuario";

            //Read Only fields
            dgvSuppliers.Columns["Id"].ReadOnly = true;
            dgvSuppliers.Columns["RegisterDate"].ReadOnly = true;
            dgvSuppliers.Columns["UserId"].ReadOnly = true;
        }

        private void SupplierBindControls()
        {
            //Info
            txtSupplierCode.DataBindings.Add("Text", SupplierSource, "Code");
            txtCompany.DataBindings.Add("Text", SupplierSource, "CompanyName");

            txtContactName.DataBindings.Add("Text", SupplierSource, "ContactName");
            txtTitleContactName.DataBindings.Add("Text", SupplierSource, "TitleContactName");

            txtRnc.DataBindings.Add("Text", SupplierSource, "Rnc");

            //Contacts
            txtTelephone.DataBindings.Add("Text", SupplierSource, "Telephone");
            txtCellPhone.DataBindings.Add("Text", SupplierSource, "CellPhone");
            txtFax.DataBindings.Add("Text", SupplierSource, "Fax");
            txtEmail.DataBindings.Add("Text", SupplierSource, "Email");

            //Address
            cbCountry.DataBindings.Add("SelectedValue", SupplierSource, "Country");
            cbCity.DataBindings.Add("SelectedValue", SupplierSource, "City");
            txtSection.DataBindings.Add("Text", SupplierSource, "Secction");
            txtStreet.DataBindings.Add("Text", SupplierSource, "Street");
            txtBuilding.DataBindings.Add("Text", SupplierSource, "Building");

        }

        private void SupplierUnBindControls()
        {
            //Info
            txtSupplierCode.DataBindings.Clear();
            txtCompany.DataBindings.Clear();

            txtContactName.DataBindings.Clear();
            txtTitleContactName.DataBindings.Clear();

            txtRnc.DataBindings.Clear();

            //Contacts
            txtTelephone.DataBindings.Clear();
            txtCellPhone.DataBindings.Clear();
            txtFax.DataBindings.Clear();
            txtEmail.DataBindings.Clear();

            //Address
            cbCountry.DataBindings.Clear();
            cbCity.DataBindings.Clear();
            txtSection.DataBindings.Clear();
            txtStreet.DataBindings.Clear();
            txtBuilding.DataBindings.Clear();
        }

        private void NewSupplier()
        {
            gbSupplierList.Enabled = false;

            SupplierUnBindControls();

            Validate = new Validation();

            Validate.Clear(tpSupplier);

            _Supplier = new Supplier();
        }

        private void SetNewSupplier()
        {
            _Supplier.Code = txtSupplierCode.Text.Trim();
            _Supplier.CompanyName = txtCompany.Text.Trim();
            _Supplier.ContactName = txtContactName.Text.Trim();
            _Supplier.TitleContactName = txtTitleContactName.Text.Trim();
            _Supplier.Rnc = txtRnc.Text.Trim();

            _Supplier.Country = cbCountry.SelectedValue.ToString();
            _Supplier.City = cbCity.SelectedValue.ToString();
            _Supplier.Secction = txtSection.Text.Trim();
            _Supplier.Street = txtStreet.Text.Trim();
            _Supplier.Building = txtBuilding.Text.Trim();

            _Supplier.Telephone = txtTelephone.Text.Trim();
            _Supplier.CellPhone = txtCellPhone.Text.Trim();
            _Supplier.Fax = txtFax.Text.Trim();
            _Supplier.Email = txtEmail.Text.Trim();
        
        }

        private void SaveSupplier()
        {
            //Validate empty fields
            Validate = new Validation();

            if (Validate.Validate(tpSupplier))
            {
                
                if (_Supplier != null)
                {
                    SetNewSupplier();

                    SupplierSource.Add(_Supplier);

                    SupplierBindControls();
                }

                //Validate if changes
                var changed = SupplierSource.RaiseListChangedEvents;
                if (changed)
                {
                    foreach (var supplier in Suppliers)
                    {
                        supplier.Save();
                    }
                }

                //Reset
                _Supplier = null;

                gbSupplierList.Enabled = true;
            }
            
        }

        private void DeleteSupplier()
        {
            try
            {
                var countRows = dgvSuppliers.SelectedRows.Count;
                if (countRows != 0)
                {
                    //Get the product
                    var index = dgvSuppliers.CurrentRow.Index;

                    var supplier = (Supplier)SupplierSource[index];

                    //Verfiy if the supplier is being using by another entity
                    if (IsBeingUsed(supplier.Id))
                    {
                        MessageBox.Show("Este suplidor está siendo usado por otra entidad", "No puede ser eliminado",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        //U bound controls
                        SupplierUnBindControls();

                        //Add the removed product so delet them after from DB
                        SupplierSource.Remove(supplier);

                        //Remove it from DB
                        supplier.Remove();

                        //Reset controls
                        Validate = new Validation();
                        Validate.Clear(tpSupplier);

                        //Bind Controls
                        SupplierBindControls();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CancelSupplier()
        {
            if (_Supplier != null)
            {
                _Supplier = null;

                Validate.Clear(tpSupplier);

                SupplierBindControls();

                gbSupplierList.Enabled = true;
            }

            dgvSuppliers.CancelEdit();
        }

        
        //Business Rules

        //Verfiy if the supplier is being using by another entity
        private bool IsBeingUsed(Guid supplierId)
        {
            //Validate no product is usign this supplier
            if (Product.VerifyIfExistSupplier(supplierId))
            {
                return true;
            }
            else if (Equipment.VerifyIfExistSupplier(supplierId))
            {
                return true;
            }
            else if (Furniture.VerifyIfExistSupplier(supplierId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Controls methods
        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSupplier();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewSupplier();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelSupplier();
        }

        private void txtTelephone_Click(object sender, EventArgs e)
        {
            txtTelephone.Select(0,0);
        }

        private void txtCellPhone_Click(object sender, EventArgs e)
        {
            txtCellPhone.Select(0, 0);
        }

        private void txtFax_Click(object sender, EventArgs e)
        {
            txtFax.Select(0, 0);
        }

        #endregion


        #region Product

        //Properties
        public List<Product> Products { get; set; }
        public Product _Product { get; set; }
        public List<Category> Categories { get; set; }

        public BindingList<Product> ProductBindingList { get; set; }
        public BindingSource ProductSource { get; set; }


        //Load Product stuffs
        private void LoadPrudctStuffs()
        {
            //Load Products
            LoadProducts();

            FormatProductDataGridView();

            LoadProductCategories();

            LoadProductStatus();

            LoadProductPresentation();

            LoadSupplierToProduct();

            ProductBindControls();

            LoadProductCategoryFilter();

            LoadProductSupplierFilter();
        }


        //Private Methods
        private void LoadProducts()
        {
            try
            {
                Products = Product.GetAll();

                if (Products != null)
                {
                    ProductBindingList = new BindingList<Product>(Products);

                    ProductSource = new BindingSource(ProductBindingList, null);

                    dgvProducts.DataSource = ProductSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatProductDataGridView()
        {
            //Invisible fields
            dgvProducts.Columns["Id"].Visible = false;
            dgvProducts.Columns["RegisterDate"].Visible = false;
            dgvProducts.Columns["CategoryId"].Visible = false;
            dgvProducts.Columns["TypeId"].Visible = false;
            dgvProducts.Columns["UserId"].Visible = false;
            dgvProducts.Columns["Comments"].Visible = false;
            dgvProducts.Columns["Description"].Visible = false;
            dgvProducts.Columns["StockMin"].Visible = false;
            dgvProducts.Columns["ExpirationDate"].Visible = false;
            dgvProducts.Columns["SupplierId"].Visible = false;

            //Header text to show
            dgvProducts.Columns["BarCode"].HeaderText = "Código Barra";
            dgvProducts.Columns["Name"].HeaderText = "Nombre";
            dgvProducts.Columns["SellingUnitPrice"].HeaderText = "Precio Unidad";
            dgvProducts.Columns["SellingPrice"].HeaderText = "Precio Paquete";
            dgvProducts.Columns["ITBIS"].HeaderText = "ITBIS";
            dgvProducts.Columns["Units"].HeaderText = "Unidades";
            dgvProducts.Columns["Quantity"].HeaderText = "Cantidad";
            dgvProducts.Columns["StockMin"].HeaderText = "Stock Mínimo";
            dgvProducts.Columns["Presentation"].HeaderText = "Presentación";
            dgvProducts.Columns["CostPrice"].HeaderText = "Costo";
            dgvProducts.Columns["Status"].HeaderText = "Estado";

        }

        private void LoadProductCategories()
        {
            Categories = Category.GetByArea(Area.Product);
            
            if (Categories != null)
            {
                cbProductCategory.DataSource = Categories;
                cbProductCategory.DisplayMember = "Name";
                cbProductCategory.ValueMember = "Id";
            }
        }

        private void LoadProductTypes()
        {
            if (cbProductCategory.SelectedIndex != -1)
            {
                var type = ((Category)cbProductCategory.SelectedItem).StockType;

                cbProductType.DataSource = type;
                cbProductType.DisplayMember = "Name";
                cbProductType.ValueMember = "Id";
            }
        }

        private void LoadProductStatus()
        {
            var status = new[]
                {
                    new {Text = "Activo", Value = true},
                    new {Text = "Inactivo", Value = false}
                };

            cbProductStatus.DataSource = status;
            cbProductStatus.DisplayMember = "Text";
            cbProductStatus.ValueMember = "Value";
        }

        private void LoadProductPresentation()
        {
            var presentation = new[]
                {
                    new { Text = "Caja", Value = "Caja" },
                    new { Text = "Botella", Value = "Botella" },
                    new { Text = "Empaque", Value = "Empaque" },
                    new { Text = "Frasco", Value = "Frasco" },
                    new { Text = "Funda", Value = "Funda" }
                };

            cbProductPresentation.DataSource = presentation;
            cbProductPresentation.DisplayMember = "Text";
            cbProductPresentation.ValueMember = "Value";
        }

        private void LoadSupplierToProduct()
        {
            cbProductSupplier.DataSource = Suppliers;
            cbProductSupplier.DisplayMember = "CompanyName";
            cbProductSupplier.ValueMember = "Id";
        }

        private void ProductBindControls()
        {
            //Details
            txtProductBarCode.DataBindings.Add("Text", ProductSource, "BarCode");
            txtProductName.DataBindings.Add("Text", ProductSource, "Name");
            txtProductDescription.DataBindings.Add("Text", ProductSource, "Description");
            cbProductCategory.DataBindings.Add("SelectedValue", ProductSource, "CategoryId");
            cbProductType.DataBindings.Add("SelectedValue", ProductSource, "TypeId");
            cbProductPresentation.DataBindings.Add("SelectedValue", ProductSource, "Presentation");

            //Prices and Costs
            txtProductCostPrice.DataBindings.Add("Text", ProductSource, "CostPrice");
            txtProductSellingUnitPrice.DataBindings.Add("Text", ProductSource, "SellingUnitPrice");
            txtProductSellingPrice.DataBindings.Add("Text", ProductSource, "SellingPrice");
            txtProductITBIS.DataBindings.Add("Text", ProductSource, "ITBIS");
            nudProductUnits.DataBindings.Add("Value", ProductSource, "Units");
            nudProductQuantity.DataBindings.Add("Value", ProductSource, "Quantity");
            nudProductStockMin.DataBindings.Add("Value", ProductSource, "StockMin");

            //Others
            cbProductSupplier.DataBindings.Add("SelectedValue", ProductSource, "SupplierId");
            cbProductStatus.DataBindings.Add("SelectedValue", ProductSource, "Status");
            dtpProductExpirationDate.DataBindings.Add("Value", ProductSource, "ExpirationDate");
            txtProductComments.DataBindings.Add("Text", ProductSource, "Comments");

        }

        private void ProductUnBindControls()
        {
            //Details
            txtProductBarCode.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtProductDescription.DataBindings.Clear();
            cbProductCategory.DataBindings.Clear();
            cbProductType.DataBindings.Clear();
            cbProductPresentation.DataBindings.Clear();

            //Prices and Costs
            txtProductCostPrice.DataBindings.Clear();
            txtProductSellingUnitPrice.DataBindings.Clear();
            txtProductSellingPrice.DataBindings.Clear();
            txtProductITBIS.DataBindings.Clear();
            nudProductUnits.DataBindings.Clear();
            nudProductQuantity.DataBindings.Clear();
            nudProductStockMin.DataBindings.Clear();

            //Others
            cbProductSupplier.DataBindings.Clear();
            cbProductStatus.DataBindings.Clear();
            dtpProductExpirationDate.DataBindings.Clear();
            txtProductComments.DataBindings.Clear();
        }

        private void NewProduct()
        {
            gbProductList.Enabled = false;

            ProductUnBindControls();

            Validate = new Validation();

            Validate.Clear(tpProducts);

            _Product = new Product();
        }

        private void SetNewProduct()
        {

            _Product = new Product()
                {
                    BarCode = int.Parse(txtProductBarCode.Text.Trim()),
                    Name = txtProductName.Text.Trim(),
                    Description = txtProductDescription.Text.Trim(),
                    CategoryId = (Guid) cbProductCategory.SelectedValue,
                    TypeId = (Guid) cbProductType.SelectedValue,
                    Presentation = cbProductPresentation.SelectedValue.ToString(),

                    CostPrice = decimal.Parse(txtProductCostPrice.Text),
                    SellingUnitPrice = decimal.Parse(txtProductSellingUnitPrice.Text),
                    SellingPrice = decimal.Parse(txtProductSellingPrice.Text),
                    ITBIS = decimal.Parse(txtProductITBIS.Text),
                    Units = (int) nudProductUnits.Value,
                    Quantity = (int) nudProductQuantity.Value,
                    StockMin = (int) nudProductStockMin.Value,

                    SupplierId = (Guid) cbProductSupplier.SelectedValue,
                    Status = (bool) cbProductStatus.SelectedValue,
                    ExpirationDate = dtpProductExpirationDate.Value,
                    Comments = txtProductComments.Text.Trim()

                    //UserId and RegisterDate are already intialized in the constructor
                };


        }

        private void Saveproduct()
        {
            //Validate empty fields
            Validate = new Validation();

            if (Validate.Validate(tpProducts))
            {
                if (_Product != null)
                {
                    SetNewProduct();
                    
                    ProductSource.Add(_Product);

                    ProductBindControls();
                }

                //Validate if Changes
                var changes = ProductSource.RaiseListChangedEvents;
                if (changes)
                {
                    foreach (var product in Products)
                    {
                        product.Save();
                    }
                }

                //Reset
                _Product = null;

                gbProductList.Enabled = true;
            }
        }

        private void DeleteProduct()
        {
            try
            {
                var countRows = dgvProducts.SelectedRows.Count;
                if (countRows != 0)
                {
                    //Get the product
                    var index = dgvProducts.CurrentRow.Index;

                    var product = (Product)ProductSource[index];

                    //Unbound controls
                    ProductUnBindControls();

                    //Add the removed product so delet them after from DB
                    ProductSource.Remove(product);

                    //Remove it from DB
                    product.Remove();

                    //Reset controls
                    Validate = new Validation();
                    Validate.Clear(tpProducts);

                    //Bind Controls
                    ProductBindControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelProduct()
        {
            if (_Product != null)
            {
                _Product = null;

                Validate.Clear(tpProducts);

                ProductBindControls();

                gbProductList.Enabled = true;
            }

            dgvProducts.CancelEdit();
        }

        private void ProductFilter()
        {
            var filter = new List<Product>();
            
            var barCode = txtProductBarCodeFilter.Text.Trim();
            var name = txtProductNameFilter.Text.Trim();
            var category = cbProductCategoryFilter.SelectedIndex != -1
                ? cbProductCategoryFilter.SelectedValue.ToString(): null;

            var supplier = cbProductSupplierFilter.SelectedIndex != -1 
                ? cbProductSupplierFilter.SelectedValue.ToString(): null;

            //Search only By BarCode
            if (!string.IsNullOrEmpty(barCode) && (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(supplier)))
            {
                filter = Products.FindAll(e => e.BarCode.ToString().Contains(barCode));
            }
            
            //Serach only by Name
            else if (!string.IsNullOrEmpty(name) && (string.IsNullOrEmpty(barCode) && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(supplier)))
            {
                filter = Products.FindAll(e => e.Name.Contains(name));
            }

            //Serach only by Category
            else if (!string.IsNullOrEmpty(category) && (string.IsNullOrEmpty(barCode) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(supplier)))
            {
                filter = Products.FindAll(e => e.CategoryId.ToString().Contains(category));
            }

            //Serach only by Supplier
            else if (!string.IsNullOrEmpty(supplier) && (string.IsNullOrEmpty(barCode) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(category)))
            {
                filter = Products.FindAll(e => e.SupplierId.ToString().Contains(supplier));
            }

            //Search only By BarCode and Name
            else if ((!string.IsNullOrEmpty(barCode) && !string.IsNullOrEmpty(name)) && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(supplier))
            {
                filter = Products.FindAll(e => e.Name.Contains(name) && e.BarCode.ToString().Contains(barCode));
            }

            //Search only By BarCode and Category
            else if ((!string.IsNullOrEmpty(barCode) && !string.IsNullOrEmpty(category)) && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(supplier))
            {
                filter = Products.FindAll(e => e.BarCode.ToString().Contains(barCode) && e.CategoryId.ToString().Contains(category));
            }

            //Search only By BarCode and Supplier
            else if ((!string.IsNullOrEmpty(barCode) && !string.IsNullOrEmpty(supplier)) && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(category))
            {
                filter = Products.FindAll(e => e.BarCode.ToString().Contains(barCode) && e.SupplierId.ToString().Contains(supplier));
            }

            //Search only By Name and Category
            else if ((!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(category)) && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(supplier))
            {
                filter = Products.FindAll(e => e.Name.Contains(barCode) && e.CategoryId.ToString().Contains(category));
            }

            //Search only By Name and Supplier
            else if ((!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(supplier)) && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(category))
            {
                filter = Products.FindAll(e => e.Name.Contains(barCode) && e.SupplierId.ToString().Contains(supplier));
            }

            //Search only By Category and Supplier
            else if ((!string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(supplier)) && string.IsNullOrEmpty(barCode) && string.IsNullOrEmpty(name))
            {
                filter = Products.FindAll(e => e.CategoryId.ToString().Contains(category) && e.SupplierId.ToString().Contains(supplier));
            }

            //Search only By BarCode and Name and Category
            else if ((!string.IsNullOrEmpty(barCode) && !string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(category)) && string.IsNullOrEmpty(supplier))
            {
                filter = Products.FindAll(e => e.BarCode.ToString().Contains(barCode) && e.Name.Contains(name) && e.CategoryId.ToString().Contains(category));
            }

            //Search only By BarCode and Name and Category and Supplier
            else if (!string.IsNullOrEmpty(barCode) && !string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(supplier))
            {
                filter = Products.FindAll(e => e.BarCode.ToString().Contains(barCode) && e.Name.Contains(name) && e.CategoryId.ToString().Contains(category) 
                    && e.SupplierId.ToString().Contains(supplier));
            }

            dgvProducts.DataSource = filter;
        }

        private void ActivateDeActivateFilter()
        {
            gbFilters.Enabled = ckbProductActivateFilter.Checked;

            if (!ckbProductActivateFilter.Checked)
            {
                dgvProducts.DataSource = ProductSource;

                ClearProductFilters();
            }
        }

        private void LoadProductCategoryFilter()
        {
            var source = Category.GetByArea(Area.Product);

            cbProductCategoryFilter.DataSource = source;
            cbProductCategoryFilter.DisplayMember = "Name";
            cbProductCategoryFilter.ValueMember = "Id";

            cbProductCategoryFilter.SelectedIndex = -1;
        }

        private void LoadProductSupplierFilter()
        {
            var source = Supplier.GetAll();

            cbProductSupplierFilter.DataSource = source;
            cbProductSupplierFilter.DisplayMember = "CompanyName";
            cbProductSupplierFilter.ValueMember = "Id";

            cbProductSupplierFilter.SelectedIndex = -1;
        }

        private void ClearProductFilters()
        {
            txtProductBarCodeFilter.Clear();
            txtProductNameFilter.Clear();
            cbProductCategoryFilter.SelectedIndex = -1;
            cbProductSupplierFilter.SelectedIndex = -1;
        }


        //Controls methods
        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductTypes();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            NewProduct();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            Saveproduct();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            CancelProduct();
        }

        private void txtProductBarCode_Click(object sender, EventArgs e)
        {
            txtProductBarCode.Select(0, 0);
        }

        private void txtProductCostPrice_Click(object sender, EventArgs e)
        {
            txtProductCostPrice.Select(0, 0);
        }

        private void txtProductSellingUnitPrice_Click(object sender, EventArgs e)
        {
            txtProductSellingUnitPrice.Select(0, 0);
        }

        private void txtProductSellingPrice_Click(object sender, EventArgs e)
        {
            txtProductSellingPrice.Select(0, 0);
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            ProductFilter();
        }

        private void ckbProductActivateFilter_CheckedChanged(object sender, EventArgs e)
        {
            ActivateDeActivateFilter();
        }

        #endregion


        #region Equipment
        //Properties
        public List<Equipment>Equipments { get; set; }
        public Equipment _Equipment { get; set; }
        public BindingList<Equipment> EquipmentBindingList { get; set; }
        public BindingSource EquipmentSource { get; set; }
        
        
        //Private Methods
        private void LoadEquipmentStuffs()
        {
            LoadEquipments();

            FormatEquipmentDataGridView();

            EquipmentBindControls();

            LoadEquipmentCategories();

            LoadEquipmentStatus();

            LaodSupplierToEquipment();
        }
        
        private void LoadEquipments()
        {
            try
            {
                Equipments = Equipment.GetAll();

                if (Equipments != null)
                {
                    EquipmentBindingList = new BindingList<Equipment>(Equipments);

                    EquipmentSource = new BindingSource(EquipmentBindingList, null);

                    dgvEquipments.DataSource = EquipmentSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatEquipmentDataGridView()
        {
            //Invisible fields
            dgvEquipments.Columns["Id"].Visible = false;
            dgvEquipments.Columns["CategoryId"].Visible = false;
            dgvEquipments.Columns["TypeId"].Visible = false;
            dgvEquipments.Columns["UserId"].Visible = false;
            dgvEquipments.Columns["Comments"].Visible = false;
            dgvEquipments.Columns["AcquiredDate"].Visible = false;
            dgvEquipments.Columns["SupplierId"].Visible = false;

            //Header text to show
            dgvEquipments.Columns["Code"].HeaderText = "Código";
            dgvEquipments.Columns["Mark"].HeaderText = "Nombre";
            dgvEquipments.Columns["Model"].HeaderText = "Model";
            dgvEquipments.Columns["SerialNumber"].HeaderText = "No. Serial";
            dgvEquipments.Columns["CostPrice"].HeaderText = "Costo";
            dgvEquipments.Columns["Status"].HeaderText = "Estado";
            dgvEquipments.Columns["RegisterDate"].HeaderText = "Fecha Registro";
        }

        private void EquipmentBindControls()
        {
            //Details
            txtEquipmentCode.DataBindings.Add("Text", EquipmentSource, "Code");
            txtEquipmentMark.DataBindings.Add("Text", EquipmentSource, "Mark");
            txtEquipmentModel.DataBindings.Add("Text", EquipmentSource, "Model");
            cbEquipmentCategory.DataBindings.Add("SelectedValue", EquipmentSource, "CategoryId");
            cbEquipmentType.DataBindings.Add("SelectedValue", EquipmentSource, "TypeId");
            txtEquipmentCostPrice.DataBindings.Add("Text", EquipmentSource, "CostPrice");

            //Others
            cbEquipmentSupplier.DataBindings.Add("SelectedValue", EquipmentSource, "SupplierId");
            cbEquipmentStatus.DataBindings.Add("SelectedValue", EquipmentSource, "Status");
            dtpEquipmentAcquiredDate.DataBindings.Add("Value", EquipmentSource, "AcquiredDate");
            txtEquipmentComments.DataBindings.Add("Text", EquipmentSource, "Comments");
        }

        private void EquipmentUnBindControls()
        {
            //Details
            txtEquipmentCode.DataBindings.Clear();
            txtEquipmentMark.DataBindings.Clear();
            txtEquipmentModel.DataBindings.Clear();
            cbEquipmentCategory.DataBindings.Clear();
            cbEquipmentType.DataBindings.Clear();
            txtEquipmentCostPrice.DataBindings.Clear();

            //Others
            cbEquipmentSupplier.DataBindings.Clear();
            cbEquipmentStatus.DataBindings.Clear();
            dtpEquipmentAcquiredDate.DataBindings.Clear();
            txtEquipmentComments.DataBindings.Clear();
        }

        private void LoadEquipmentCategories()
        {
            Categories = Category.GetByArea(Area.Equipment);

            if (Categories != null)
            {
                cbEquipmentCategory.DataSource = Categories;
                cbEquipmentCategory.DisplayMember = "Name";
                cbEquipmentCategory.ValueMember = "Id";
            }
        }

        private void LoadEquipmentTypes()
        {
            if (cbProductCategory.SelectedIndex != -1)
            {
                var type = ((Category)cbProductCategory.SelectedItem).StockType;

                cbEquipmentType.DataSource = type;
                cbEquipmentType.DisplayMember = "Name";
                cbEquipmentType.ValueMember = "Id";
            }
        }

        private void LoadEquipmentStatus()
        {
            var status = new[]
                {
                    new {Text = "Activo", Value = true},
                    new {Text = "Inactivo", Value = false}
                };

            cbEquipmentStatus.DataSource = status;
            cbEquipmentStatus.DisplayMember = "Text";
            cbEquipmentStatus.ValueMember = "Value";
        }

        private void LaodSupplierToEquipment()
        {
            var supplier = Supplier.GetAll();

            cbEquipmentSupplier.DataSource = supplier;
            cbEquipmentSupplier.DisplayMember = "CompanyName";
            cbEquipmentSupplier.ValueMember = "Id";
        }

        private void NewEquipment()
        {
            gbEquipmentList.Enabled = false;

            EquipmentUnBindControls();

            Validate = new Validation();

            Validate.Clear(tpEquipments);

            _Equipment = new Equipment();
        }

        private void SetNewEquipment()
        {
            _Equipment = new Equipment()
                {
                    Code = txtEquipmentCode.Text.Trim(),
                    Mark = txtEquipmentMark.Text.Trim(),
                    Model = txtEquipmentModel.Text.Trim(),
                    SerialNumber = txtEquipmentSerialNumber.Text.Trim(),
                    CategoryId = (Guid)cbEquipmentCategory.SelectedValue,
                    TypeId = (Guid)cbEquipmentType.SelectedValue,
                    CostPrice = decimal.Parse(txtEquipmentCostPrice.Text),

                    SupplierId = (Guid)cbEquipmentSupplier.SelectedValue,
                    Status = (bool)cbEquipmentStatus.SelectedValue,
                    AcquiredDate = dtpEquipmentAcquiredDate.Value,
                    Comments = txtEquipmentComments.Text.Trim()
                };

            //UserId and RegisterDate are already intialized in the constructor
        }

        private void SaveEquipment()
        {
            //Validate empty fields
            Validate = new Validation();

            if (Validate.Validate(tpEquipments))
            {
                if (_Equipment != null)
                {
                    SetNewEquipment();

                    EquipmentSource.Add(_Equipment);

                    EquipmentBindControls();
                }

                //Validate if Changes
                var changes = EquipmentSource.RaiseListChangedEvents;
                if (changes)
                {
                    foreach (var equipment in Equipments)
                    {
                        equipment.Save();
                    }
                }

                //Reset
                _Equipment = null;

                gbEquipmentList.Enabled = true;
            }
        }
        
        private void DeleteEquipment()
        {
            try
            {
                var countRows = dgvEquipments.SelectedRows.Count;
                if (countRows != 0)
                {
                    //Get the product
                    var index = dgvEquipments.CurrentRow.Index;
                    
                    var equipment = (Equipment) EquipmentSource[index];

                    //U bound controls
                    EquipmentUnBindControls();

                    //Add the removed product so delet them after from DB
                    EquipmentSource.Remove(equipment);

                    //Remove it from DB
                    equipment.Remove();

                    //Reset controls
                    Validate = new Validation();
                    Validate.Clear(tpEquipments);

                    //Bind Controls
                    EquipmentBindControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void CancelEquipment()
        {
            if (_Equipment != null)
            {
                _Equipment = null;

                Validate.Clear(tpEquipments);

                EquipmentBindControls();

                gbEquipmentList.Enabled = true;
            }

            dgvEquipments.CancelEdit();
        }

        //Controls Methods
        private void btnNewEquipment_Click(object sender, EventArgs e)
        {
            NewEquipment();
        }

        private void btnDeleteEquiment_Click(object sender, EventArgs e)
        {
            DeleteEquipment();
        }

        private void btnSaveEquipments_Click(object sender, EventArgs e)
        {
            SaveEquipment();
        }

        private void btnCancelEquipment_Click(object sender, EventArgs e)
        {
            CancelEquipment();
        }

        private void cbEquipmentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEquipmentTypes();
        }

        private void dgvEquipments_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
        }

        private void txtEquipmentCostPrice_Click(object sender, EventArgs e)
        {
            txtEquipmentCostPrice.Select(0, 0);
        }
        
        #endregion


    }
}
