using System;
using System.Windows.Forms;
using Core.Entities.Inventory;
using Core.Entities.Members.Enums;

namespace Core.Entities.Billing
{
    public class BillDetail
    {
        public BillDetail()
        {
            Quantity = 1;
        }
        
        //Private variables
        private string _barCode;
        private decimal _itbis;
        private int _quantity;
        //private Product _product;

        //Properties
        public string BarCode 
        {
            get { return _barCode; }
            set
            {
                _barCode = value;
               //SetProduct(_barCode);
            }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal ITBIS { get; set; }
        public int Quantity 
        { 
            get { return _quantity; } 
            set
            {
                _quantity = value;
                CalculateITBIS(_quantity);
                CalculateTotal(_quantity);
            }
        }
        public decimal Total { get; set; }



        private void Set(Product product)
        {
            if (product != null)
            {
                if (product.Quantity > 0)
                {
                    BarCode = product.BarCode.ToString();
                    Name = product.Name;
                    Description = product.Description;
                    Price = product.SellingUnitPrice;
                    _itbis = product.ITBIS;

                    CalculateITBIS(Quantity);
                    CalculateTotal(Quantity);
                }
                else
                {
                    throw new ArgumentException("No hay en existencia");
                }
            }
        }
        
        
        
        //Public Methods
        public void SetProduct(Product product)
        {
            Set(product);
        }

        public void SetProduct(string code)
        {
            var product = Product.GetByBarCode(code);
            Set(product);
        }

        public void SetMembership(MembershipType membership)
        {
            if (membership != null)
            {
                BarCode = "MB-0000";
                Name = membership.Type;
                Description = membership.Period;
                Price = membership.Price;
                Quantity = 1;
                ITBIS = 0;
            }
        }

        private void CalculateITBIS(decimal quantity)
        {
            this.ITBIS = ((Price * _itbis) / 100) * quantity;
        }

        private void CalculateTotal(decimal quantity)
        {
            Total = (Price * quantity);
        }
    }
}
