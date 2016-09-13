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
    public class Supplier : MongoEntity
    {
        //Constructor Class
        public Supplier()
        {
            UserId = Usuario.CurrentUser.Id;
            RegisterDate = DateTime.Now;
        }

        
        //Info
        public string Code { get; set; }
        public string CompanyName { get; set; }
         
        public string ContactName { get; set; }
        public string TitleContactName { get; set; }

        public string Rnc { get; set; }
        
        //Contacts
        public string Telephone { get; set; }
        public string CellPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        //Address

        public string Country { get; set; }
        public string City { get; set; }
        public string Secction { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegisterDate { get; set; }

        public Guid UserId { get; set; }


        //Methods
        public static List<Supplier> GetAll()
        {
            return EntityService.GetCollection<Supplier>().FindAll().ToList();
        }

        public static Supplier GetById(Guid id)
        {
            var query = Query.EQ("_Id", id);

            return EntityService.GetCollection<Supplier>().FindOne(query);
        }

    }
}
