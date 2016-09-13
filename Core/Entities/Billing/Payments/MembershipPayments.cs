using System;
using System.Collections.Generic;
using System.Linq;
using Mongo.Entity;
using Core.Entities.Members;
using Core.Entities.Members.Enums;
using Core.Entities.Security;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entidades.Billing.Payments
{
    public class MembershipPayments : MongoEntity
    {
        public int MembershipNumber { get; set; }
        public decimal Amount { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime PayDate { get; set; }

        public Guid UserId { get; set; }

        public static List<MembershipPayments> GetPaymentsHistory(string period)
        {
            var date = DateTime.Now;

            switch (period)
            {
                case "Hoy" :
                    date = DateTime.Now;
                    break;

                case "Semana":
                    date = DateTime.Now.AddDays(-7);
                    break;

                case "Mes":
                    date = DateTime.Now.AddMonths(-1);
                    break;

                case "Año":
                    date = DateTime.Now.AddYears(-1);
                    break;
            }

            var criteria = Query.And(
                Query.GTE("PayDate", new BsonDateTime(new DateTime(date.Year, date.Month, date.Day)))
                );

            return EntityService.GetCollection<MembershipPayments>().Find(criteria).ToList();
        }

        public static List<MembershipPayments> GetPaymentsHistoryByDate(DateTime start, DateTime end)
        {
            var query = Query.And(
                Query.GTE("PayDate", start.Date),
                Query.LTE("PayDate", end.Date)
                );

            return EntityService.GetCollection<MembershipPayments>().Find(query).ToList();
        }

        public static void Pay(Member customer, MembershipType membershipType, int quantity)
        {
            if (customer != null && membershipType != null)
            {
                var total = membershipType.Price * quantity;

                //Add the new Payment
                var payment = new MembershipPayments()
                {
                    MembershipNumber = customer.Number,
                    Amount = total,
                    PayDate = DateTime.Now,
                    UserId = Usuario.CurrentUser.Id
                };
                payment.Save();

                //Update the Customer's information
                
                customer.Save();
            }
        }
    }
}
