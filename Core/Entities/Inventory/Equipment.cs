using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades.Seguridad;
using Core.Entities.Security;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Inventory
{
    public class Equipment : Stock
    {
        //Constructor Class
        public Equipment()
        {
            UserId = Usuario.CurrentUser.Id;
            AcquiredDate = DateTime.Now;
        }
        
        //Properties
        public string Code { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime AcquiredDate { get; set; }

        //Methods
        public static List<Equipment> GetAll()
        {
            return EntityService.GetCollection<Equipment>().FindAll().ToList();
        }

        
        //Business Rules

        //Verify before delete Supplier if not is being using by an Equipment
        public static bool VerifyIfExistSupplier(Guid supplierid)
        {
            var query = Query.EQ("SupplierId", supplierid);

            var equipment = EntityService.GetCollection<Equipment>().FindOne(query);

            return equipment != null;
        }

        //Verify before delete Category if is not being using by an Equipment
        public static bool VerifyIfExistCategory(Guid catgoryId)
        {
            var query = Query.EQ("CategoryId", catgoryId);

            var category = EntityService.GetCollection<Equipment>().FindOne(query);

            return category != null;
        }
    }
}
