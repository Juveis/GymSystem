using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Members;
using Core.Entities.Accounting;
using Core.Entidades.Billing;
using Core.Entities.Employees;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Billing
{
    public class Bill : MongoEntity
    {
        public Bill()
        {
            
        }
        //Variables
        
        //Properties
        public int Number { get; set; }
        public string Customer { get; set; }
        public int Membersip { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime BillDate { get; set; }

        public string CashRegister { get; set; }
        public string NCF { get; set; }

        public string PaymentMethod { get; set; }
        public string DocumentNumber { get; set; }
        public decimal ReceivedPay { get; set; }
        public decimal Change { get; set; }

        public decimal ITBIS { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public string Condition { get; set; }

        public List<BillDetail> Details { get; set; }

        public string Employee { get; set; }

        public Guid UserId { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegisterDate { get; set; }


        //Methods
        public static string GetNextNumber()
        {
            var sortBy = SortBy.Descending("Number");

            var collection = EntityService.GetCollection<Bill>().FindAll().SetSortOrder(sortBy).SetLimit(1).ToList();

            if (collection.Count == 0)
            {
                return 1.ToString("000000");
            }
            else
            {
                var number = collection[0].Number + 1;

                return number.ToString("000000");
            }
        }

        public static List<Bill> GetByNumber(int number)
        {
            var query = Query.EQ("Number", number);

            var bill = EntityService.GetCollection<Bill>().Find(query).ToList();

            return bill;
        }

        public static List<Bill> GetByDate(DateTime start, DateTime end)
        {
            var query = Query.And(
                Query.GTE("BillDate", start.Date),
                Query.LTE("BillDate", end.Date.AddDays(1))
                );

            var bills = EntityService.GetCollection<Bill>().Find(query).SetSortOrder(SortBy.Ascending("Number")).ToList();

            return bills;
        }

        public static List<Bill> GetAll()
        {
            var bills = EntityService.GetCollection<Bill>().FindAll().ToList();
            return bills;
        }

        public static void SellByCredit(object person, int billNumber, decimal amount)
        {
            //For Customers
            if (person.GetType() == typeof (Member))
            {
                var customer = (Member) person;

                var accounts = AccountsReceivable.GetAccountsReceivables(customer.Number, "Cliente");

                if (accounts.Count != 0)
                {
                    var account = accounts[0];

                    var status = account.AccountStatuses;

                    status.Add(
                        new AccountStatus()
                            {
                                Date = DateTime.Now,
                                Debit = amount,
                                Description = "Por concepto de Factura No.: " + billNumber.ToString("0000")
                            });

                    account.AccountStatuses = status;

                    account.Save();
                }
                else
                {
                    var status = new List<AccountStatus>();
                    status.Add(new AccountStatus()
                        {
                            Date = DateTime.Now,
                            Debit = amount,
                            Description = "Por concepto de Factura No.: " + billNumber.ToString("0000")
                        });

                    var accountsReceivable = new AccountsReceivable()
                        {
                            AccountNumber = AccountsReceivable.GetNexNumber(),
                            ReferenceNumber = customer.Number,
                            PersonType = "Cliente",
                            Customer = customer.FirstName + " " + customer.FirstLastName,
                            AccountStatuses = status,
                            RecordCreated = DateTime.Now
                        };

                    accountsReceivable.Save();
                }

            }
            
                // For Employess
            else
            {
                if (person.GetType() == typeof (Employee))
                {
                    var employee = (Employee) person;

                    var accounts = AccountsReceivable.GetAccountsReceivables(employee.Number, "Empleado");

                    if (accounts.Count != 0)
                    {
                        var account = accounts[0];

                        var status = account.AccountStatuses;

                        status.Add(
                            new AccountStatus()
                                {
                                    Date = DateTime.Now,
                                    Debit = amount,
                                    Description = "Por concepto de Factura No.: " + billNumber.ToString("0000")
                                });

                        account.AccountStatuses = status;

                        account.Save();
                    }
                    else
                    {
                        var status = new List<AccountStatus>();
                        status.Add(new AccountStatus()
                            {
                                Date = DateTime.Now,
                                Debit = amount,
                                Description = "Por concepto de Factura No.: " + billNumber.ToString("0000")
                            });

                        var accountsReceivable = new AccountsReceivable()
                            {
                                AccountNumber = AccountsReceivable.GetNexNumber(),
                                ReferenceNumber = employee.Number,
                                PersonType = "Empleado",
                                Customer = employee.FirstName + " " + employee.FirstLastName,
                                AccountStatuses = status,
                                RecordCreated = DateTime.Now
                            };

                        accountsReceivable.Save();
                    }
                }
            }
        }

    }
}