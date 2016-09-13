using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Employees;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Accounting
{
    public class AccountsReceivable : MongoEntity
    {
        //Constructor class
        public AccountsReceivable()
        {
           
        }

        //Private variables
        private List<AccountStatus> statuses;
        
        //Properties
        public int AccountNumber { get; set; }
        public int ReferenceNumber { get; set; }
        public string PersonType { get; set; }
        public string Customer { get; set; }
        public decimal Balance { get; set; }
        public List<AccountStatus> AccountStatuses
        {
            set
            {
                statuses = value;
                Balance = CalculateBalance(statuses);
            }
            get { return statuses; }
        }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RecordCreated { get; set; }

        
        //Methods
        public static int GetNexNumber()
        {
            var sortBy = SortBy.Descending("AccountNumber");

            var lastNumber = EntityService.GetCollection<AccountsReceivable>().FindAll().SetSortOrder(sortBy).SetLimit(1).ToList();

            if (lastNumber.Count == 0)
            {
                return 1;
            }
            else
            {
                var number = lastNumber[0].AccountNumber + 1;

                return number;
            }
        }

        public static AccountsReceivable GetAccount(string personType, int number)
        {
            var query = Query.And(Query.EQ("CustomerNumber", number),
               Query.EQ("PersonType", personType)
               );

            return EntityService.GetCollection<AccountsReceivable>().FindOne(query);
        }

        public static List<AccountsReceivable> GetAll()
        {
            return EntityService.GetCollection<AccountsReceivable>().FindAll().ToList();
        }

        public static List<AccountsReceivable> GetAccountsReceivables(int number, string personType)
        {
            var query = Query.And(Query.EQ("CustomerNumber", number),
                Query.EQ("PersonType", personType)
                );

            var collection = EntityService.GetCollection<AccountsReceivable>().Find(query).ToList();

            return collection;
        }

        public static List<AccountsReceivable> GetAccountsReceivables(Employee employee)
        {
            var query = Query.EQ("Number", employee.Number);

            var collection = EntityService.GetCollection<AccountsReceivable>().Find(query).ToList();

            return collection;
        }

        public static decimal CalculateBalance(List<AccountStatus> accountStatuses)
        {
            var debit = accountStatuses.Sum(e => e.Debit);
            var credit = accountStatuses.Sum(e => e.Credit);

            return debit - credit;

        }
    }
}
