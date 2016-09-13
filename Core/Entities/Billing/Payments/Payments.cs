using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entidades.Billing.Payments
{
    public class Payments : MongoEntity
    {
        
        //Properties
        public int Number { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }
        public int AccounNumber { get; set; }
        public string Customer { get; set; }
        public string PayMethod { get; set; }
        public string DocNumber { get; set; }
        public decimal Amount { get; set; }
        public string Cashier { get; set; }
        public Guid UserId { get; set; }
        
        //Methods
        public static int GetNextNumber()
        {
            var sort = SortBy.Descending("Number");

            var payments = EntityService.GetCollection<Payments>().FindAll().SetSortOrder(sort).SetLimit(1).ToList();

            if (payments.Count == 0)
            {
                return 1;
            }
            else
            {
                return payments[0].Number + 1;
            }
            
        }

        public static decimal GetTotalPayment(DateTime start, DateTime end)
        {
            var query = Query.And(
               Query.GTE("Date", start.Date),
               Query.LTE("Date", end.Date)
               );

            var payments = EntityService.GetCollection<Payments>().Find(query).ToList();

            return payments.Sum(e => e.Amount);
        }

    }
}
