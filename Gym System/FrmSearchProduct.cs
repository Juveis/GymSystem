using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Entidades.Billing;
using Core.Entities.Billing;
using Core.Entities.Inventory;

namespace GYM_System
{
    public partial class FrmSearchProduct : Form
    {
        public FrmSearchProduct()
        {
            InitializeComponent();
        }

        //Properties
        private Product _Product { get; set; }
        private List<Product> Products { get; set; }

        public BillDetail Detail { get; set; }

        //Methods
        public void GetProducts()
        {
            var name = txtName.Text;

            if (!string.IsNullOrEmpty(name))
            {
                Products = Product.GetByLike(name);

                dgvProducts.DataSource = Products;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetProducts();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _Product = Products[e.RowIndex];
            try
            {
                Detail = new BillDetail();
                Detail.SetProduct(_Product);

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Inventario", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
        }
    }
}
