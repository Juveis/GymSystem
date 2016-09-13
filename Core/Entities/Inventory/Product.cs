using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Core.Entidades.Seguridad;
using Core.Entities.Security;
using Mongo.Entity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Inventory
{
    public class Product : Stock
    {
        
        public Product()
        {
            UserId = Usuario.CurrentUser.Id;
            ExpirationDate = DateTime.Now;
        }
        //Properties
        public int BarCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public decimal SellingUnitPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int Units { get; set; }

        public int Quantity { get; set; }
        public int StockMin { get; set; }

        public decimal ITBIS { get; set; }

        public string Presentation { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime ExpirationDate { get; set; }

        //Methods
        public static List<Product> GetAll()
        {
            return EntityService.GetCollection<Product>().FindAll().ToList();
        }

        public static Product GetByBarCode(string barCode)
        {
            var query = Query.EQ("BarCode",int.Parse(barCode));

            return EntityService.GetCollection<Product>().FindOne(query);
        }

        public static void UpdateProduct(int code, int quantity)
        {
            var query = Query.EQ("BarCode", code);

            var product = EntityService.GetCollection<Product>().FindOne(query);

            product.Quantity -= quantity;

            product.Save();
        }

        public static bool ExistInStock(int code)
        {
            try
            {
                var query = Query.EQ("BarCode", code);

                var product = EntityService.GetCollection<Product>().FindOne(query);

                return product.Quantity > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Product> GetByLike(string name)
        {
            var query = Query.Matches("Name", BsonRegularExpression.Create(new Regex(name, RegexOptions.IgnoreCase)));

            return EntityService.GetCollection<Product>().Find(query).ToList();
        }

        //Business Rules

        //Verify before delete Supplier if is not being using by a product
        public static bool VerifyIfExistSupplier(Guid supplierid)
        {
            var query = Query.EQ("SupplierId", supplierid);

            var supplier = EntityService.GetCollection<Product>().FindOne(query);
            
            return supplier != null;
        }
        
        //Verify before delete Category if is not being using by a product
        public static bool VerifyIfExistCategory(Guid catgoryId)
        {
            var query = Query.EQ("CategoryId", catgoryId);

            var category = EntityService.GetCollection<Product>().FindOne(query);

            return category != null;
        }
    }
}
