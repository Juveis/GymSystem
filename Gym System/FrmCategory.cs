using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Entidades.Seguridad;
using Core.Entities.Inventory;
using Core.Entities.Security;

namespace GYM_System
{
    public partial class FrmCategory : Form
    {
        //Properties
        public List<Category> _Categories { get; set; }
        public Category _Category { get; set; }

        public BindingList<StockType> BindingList { get; set; }
        public BindingSource Source { get; set; }

        public List<StockType> TypeList { get; set; }


        //Class Constructor
        public FrmCategory()
        {
            InitializeComponent();

            LoadCategories();

            LoadAreas();

            //Show Current user
            lblUser.Text = Usuario.CurrentUser.UserName;
        }


        //Private methods
        private void LoadCategories()
        {
            try
            {
                _Categories = Category.GetAll();

                var bs = new BindingSource(){DataSource = _Categories};

                lbCategory.DataSource = bs;
                lbCategory.DisplayMember = "Name";
                lbCategory.ValueMember = "Description";

                //Load StockTypes
                LoadStockTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoadStockTypes()
        {
            if (_Category != null)
            {

                if (_Category.StockType == null)
                {
                    _Category.StockType = new List<StockType>();
                }

                BindingList = new BindingList<StockType>(_Category.StockType);
                Source = new BindingSource(BindingList, null);

                dgvStockTypes.DataSource = Source;

                //Formating
                FormatDataGridView();
            }
        }

        private void LoadAreas()
        {
            var area = new[]
                {
                    new { Text = "Productos", Value = Area.Product },
                    new { Text = "Equipos", Value = Area.Equipment },
                    new { Text = "Mobiliario", Value = Area.Furniture }
                };

            cbArea.DataSource = area;

            cbArea.DisplayMember = "Text";
            cbArea.ValueMember = "Value";
        }

        private void New()
        {
            gbCategory.Enabled = false;
            gbDetails.Enabled = true;

            lbCategory.SelectedIndex = -1;

            txtName.Clear();
            txtDescription.Clear();

            _Category = new Category();

            LoadStockTypes();
        }

        private void Add()
        {
            var name = txtName.Text;
            var description = txtDescription.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {


                if (lbCategory.SelectedIndex != -1)
                {
                    //This is to update the current category
                    var index = lbCategory.SelectedIndex;

                    _Categories[index].Name = name;
                    _Categories[index].Description = description;
                    _Categories[index].Area = (Area)cbArea.SelectedValue;
                }
                else
                {
                    if (DuplicateName(name))
                    {
                        MessageBox.Show("Ya existe una categoría llamada: " + name, "Duplicado", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Add the new one to the List (DataSource)
                        _Category.Name = name;
                        _Category.Description = description;
                        _Category.RegisterDate = DateTime.Now;
                        _Category.UserId = Usuario.CurrentUser.Id;
                        _Category.Area = (Area)cbArea.SelectedValue;

                        _Categories.Add(_Category);
                    }
                }

                RefreshListBox();

                //Clear TextBox
                txtName.Clear();
                txtDescription.Clear();

                gbCategory.Enabled = true;
                gbDetails.Enabled = false;
            }
        }

        private void Remove()
        {
            if (lbCategory.SelectedIndex != -1)
            {
                var category = (Category) lbCategory.SelectedItem;

                if (IsBeingUsed(category.Id))
                {
                    MessageBox.Show("Este Categoría está siendo usado por otra entidad", "No puede ser eliminado",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //Remove from the list
                    _Categories.Remove(category);

                    //Remove from the DB
                    category.Remove();

                    RefreshListBox();

                    //Clear TexBox
                    txtName.Clear();
                    txtDescription.Clear();
                }
            }
        }

        private void Edit()
        {
            if (lbCategory.SelectedIndex != -1)
            {
                gbCategory.Enabled = false;
                gbDetails.Enabled = true;

                txtName.Text = _Category.Name;
                txtDescription.Text = _Category.Description;
            }
        }

        private void ShowInformation()
        {
            if (lbCategory.SelectedIndex != -1)
            {
                txtName.Clear();
                txtDescription.Clear();

                _Category = (Category)lbCategory.SelectedItem;

                txtName.Text = _Category.Name;
                txtDescription.Text = _Category.Description;
                cbArea.SelectedValue = _Category.Area;

                //Load StockTypes
                LoadStockTypes();
            }
        }

        private void RefreshListBox()
        {
            //Refresh the listbox with the datasource
            ((CurrencyManager)lbCategory.BindingContext[lbCategory.DataSource]).Refresh();
        }

        private void SaveChanges()
        {
            foreach (var category in _Categories)
            {
                category.Save();
            }
        }

        private void FormatDataGridView()
        {
            if (dgvStockTypes.Columns["Id"] != null)
            {
                dgvStockTypes.Columns["Id"].ReadOnly = true;
                dgvStockTypes.Columns["Id"].Visible = false;
            }

            dgvStockTypes.Columns["Name"].HeaderText = "Nombre";
            dgvStockTypes.Columns["Description"].HeaderText = "Descripción";

            dgvStockTypes.Columns["Description"].Width = 300;

        }

        private bool DuplicateName(string name)
        {
            if (_Categories.Any(category => name.ToUpper() == category.Name.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Business Rules

        //Verfiy if the Category is being using by another entity
        private bool IsBeingUsed(Guid categoryId)
        {
            //Validate no product is usign this supplier
            if (Product.VerifyIfExistCategory(categoryId))
            {
                return true;
            }
            else if (Equipment.VerifyIfExistCategory(categoryId))
            {
                return true;
            }
            else if (Furniture.VerifyIfExistCategory(categoryId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Cotrols methods
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInformation();
        }

        private void FrmCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveChanges();
            Close();
        }
    }
}
