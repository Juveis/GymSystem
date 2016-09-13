using System;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Inventory
{
    public abstract class BasicInfo : MongoEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegisterDate { get; set; }

        public Guid UserId { get; set; }
    }
}
