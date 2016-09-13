using System;
using System.Collections.Generic;
using System.Linq;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Members
{
    public class AccesRegister : MongoEntity
    {
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime DateHour { get; set; }
        
        public int MembershipNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Approved { get; set; }

        public static List<AccesRegister> GetAccessHistory()
        {
            var date = DateTime.Now;

            var criteria = Query.And(
                Query.GTE("DateHour", date.Date)
                );

            return EntityService.GetCollection<AccesRegister>().Find(criteria).ToList();
        }

        public static AccesRegister GetLastRecord()
        {
            var sort = SortBy.Descending("DateHour");

            var collection =
                EntityService.GetCollection<AccesRegister>().FindAll().SetSortOrder(sort).SetLimit(1).ToList();

            if (collection.Count != 0)
            {
                return collection[0];
            }
            else
            {
                return null;
            }
        }

        public static List<AccesRegister> GetByDate(DateTime start, DateTime end)
        {
            var query = Query.And(
                Query.GTE("DateHour", start.Date),
                Query.LTE("DateHour", end.Date.AddDays(1))
                );

            var list = EntityService.GetCollection<AccesRegister>().Find(query).ToList();

            return list;
        }

        public static List<AccesRegister> GetByDate(DateTime start, DateTime end, bool aproved)
        {
            var query = Query.And(
                Query.GTE("DateHour", start.Date),
                Query.LTE("DateHour", end.Date.AddDays(1)),
                Query.EQ("Approved", aproved)
                );

            var list = EntityService.GetCollection<AccesRegister>().Find(query).ToList();

            return list;
        }
    }
}
