using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Memberships;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Core.Entities.Members
{
    public class Member : Person
    {
        //Properties
        //public List<Membership> Memberships { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime InscriptionDate { get; set; }
        public string Ocupation { get; set; }
        public List<AnthropometricMeasurements> AnthropometricMeasurementses { get; set; }


        //Methods
        public static List<Member> GetMembers(string field, string value)
        {
            var members = new List<Member>();


            if (field == "Number")
            {
                int number;

                var result = int.TryParse(value, out number);

                if (result)
                {
                    var query = Query.EQ(field, number);

                    members = EntityService.GetCollection<Member>().Find(query).SetSortOrder(SortBy.Ascending("Number")).ToList();
                }
                else
                {
                    members = null;
                }
            }
            else
            {
                var query = Query.EQ(field, value);

                members = EntityService.GetCollection<Member>().Find(query).SetSortOrder(SortBy.Ascending("Number")).ToList();
            }
            return members;
        }

        public static List<Member> GetMembers(IMongoQuery criteria)
        {
            var customerList = EntityService.GetCollection<Member>().Find(criteria).SetSortOrder(SortBy.Ascending(".Number")).ToList();
            return customerList;
        }

        public static Member GetMember(int Number)
        {
            var query = Query.EQ("Number", Number);

            return EntityService.GetCollection<Member>().FindOne(query);
        }

        public static List<Member> GetAll()
        {
            var allCustomers = EntityService.GetCollection<Member>().FindAll().SetSortOrder(SortBy.Ascending(".Number")).ToList();

            return allCustomers;
        }

        public static int GetNextMemberNumber()
        {
            var sortBy = SortBy.Descending(".Number");

            var collection = EntityService.GetCollection<Member>().FindAll().SetSortOrder(sortBy).SetLimit(1).ToList();

            if (collection.Count != 0)
            {
                var number = collection[0].Number + 1;
                return number;
            }
            else
            {
                return 1;
            }
        }

        public static string StrGetNextMemberNumber()
        {
            var sortBy = SortBy.Descending(".Number");

            var collection = EntityService.GetCollection<Member>().FindAll().SetSortOrder(sortBy).SetLimit(1).ToList();
            
            if (collection.Count != 0)
            {
                var number = collection[0].Number + 1;
                return number.ToString("0000");
            }
            else
            {
                return 1.ToString("0000");
            }

            
        }

        public static List<Member> GetTodaysBirthdays()
        {
            var today = DateTime.Now.Date;

            var customers = EntityService.GetCollection<Member>().FindAll().ToList().FindAll(e => e.BirthDate.Month == today.Month
                                                                                        && e.BirthDate.Day == today.Day);
            return customers;
        }

        public static List<MemberReport> Report(List<Member> customerList)
        {
            var customerReport = new List<MemberReport>();
            
            foreach (var customer in customerList)
            {
                customerReport.Add(
                    new MemberReport()
                        {
                            FirstName = customer.FirstName,
                            MiddleName = customer.MiddleName,
                            FirstLastName = customer.FirstLastName,
                            SecondLastName = customer.SecondLastName,
                            BirthDate = customer.BirthDate,
                            Gender = customer.Gender,
                            CardPassport = customer.CardPassport,
                            Nationality = customer.Nationality,
                            Telehone = customer.Telehone,
                            CellPhone = customer.CellPhone,
                            Email = customer.Email,
                            City = customer.City,
                            Country = customer.Country,
                            Secction = customer.Secction,
                            Street = customer.Street,
                            House = customer.House,
                            CreditLimit = customer.CreditLimit,
                            RegisterDate = customer.RegisterDate,
                            UserId = customer.UserId,

                            MembershipNumber = customer.Number,
                            //Type = customer.Membership.Type,
                            //Status = customer.Membership.State
                        }
                    
                    );
            }

            return customerReport;
        }


        //Bussines Rules
        /*The "Exist" mehthod is to validate if exist another customer with the same Card/Passport number*/
        public static bool Exist(Member customer, string cardPassport)
        {
            bool _exist = false;

            var query = Query.EQ("CardPassport", cardPassport);

            var collection = EntityService.GetCollection<Member>().Find(query).ToList();

            if (customer.Id != Guid.Empty)
            {
                if (collection.Count > 0)
                {
                    if (customer.Id == collection[0].Id)
                    {
                        _exist = false;
                    }
                }
            }
            else if (collection.Count > 0)
            {
                _exist = true;
            }

            return _exist;
        }
    }
}
