using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Accounting
{
    public class AccountStatus
    {
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
