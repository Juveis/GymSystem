using System;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Inventory
{
    public abstract class Stock : MongoEntity
    {
        protected Stock()
        {
            RegisterDate = DateTime.Now;
        }
        
        public Guid CategoryId { get; set; }
        public Guid TypeId { get; set; }

        public string Comments { get; set; }

        public Guid SupplierId { get; set; }

        public decimal CostPrice { get; set; }

        public bool Status { get; set; }

        public Guid UserId { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegisterDate { get; set; }
    }
}
