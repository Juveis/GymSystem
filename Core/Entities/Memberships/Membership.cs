using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Members;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Memberships
{
    public class Membership : MongoEntity
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime RegisterDate { get; set; }
        
        
        //Static Methods
        public static List<Membership> GetAll()
        {
            return EntityService.GetCollection<Membership>().FindAll().ToList();
        }
        public static int GetNextMembershipNumber()
        {
            var sortBy = SortBy.Descending("Number");

            var collection = EntityService.GetCollection<Membership>().FindAll().SetSortOrder(sortBy).SetLimit(1).ToList();
            
            return collection[0].Number + 1;
        }
    }
}
