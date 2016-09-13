using System;
using Mongo.Entity;
using MongoDB.Driver.Builders;

namespace Core.Entities.Inventory
{
    public class Furniture : Stock
    {
        //Business Rules

        //Verify before delete Supplier if not is being using by another object
        public static bool VerifyIfExistSupplier(Guid supplierid)
        {
            var query = Query.EQ("SupplierId", supplierid);

            var furniture = EntityService.GetCollection<Furniture>().FindOne(query);

            return furniture != null;
        }

        //Verify before delete Category if is not being using by a Furniture
        public static bool VerifyIfExistCategory(Guid catgoryId)
        {
            var query = Query.EQ("CategoryId", catgoryId);

            var category = EntityService.GetCollection<Furniture>().FindOne(query);

            return category != null;
        }
    }
}
