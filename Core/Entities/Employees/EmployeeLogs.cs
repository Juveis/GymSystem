using System;
using System.Collections.Generic;
using System.Linq;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Employees
{
    public class EmployeeLogs : MongoEntity
    {
        
        //Properties
        public int EmployeeNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CheckIn { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CheckOut { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegisterDate { get; set; }

        //Methods
        public static bool LogEmployee(string number)
        {
            //Get Employee
            var employeeQuery = Query.EQ("Number", int.Parse(number));

            var EmployeeCollection = EntityService.GetCollection<Employee>().Find(employeeQuery).ToList();

            if (EmployeeCollection.Count == 0)
            {
                return false;
            }
            else
            {
                var employee = EmployeeCollection[0];
                
                //Get Log
                var logQuery = Query.And(
                    Query.EQ("EmployeeNumber", int.Parse(number)),
                    Query.GTE("RegisterDate", DateTime.Now.Date)
                    );

                var LogCollection = EntityService.GetCollection<EmployeeLogs>().Find(logQuery).ToList();

                //Verify if exist logs that belongs to this employee
                if (LogCollection.Count == 0)
                {
                    //Create new log
                    var log = new EmployeeLogs()
                        {
                            EmployeeNumber = employee.Number,
                            FirstName = employee.FirstName,
                            LastName = employee.FirstLastName,
                            CheckIn = DateTime.Now,
                            RegisterDate = DateTime.Now
                        };
                    log.Save();
                }
                else
                {
                    //Update last log
                    var index = LogCollection.Count - 1;

                    var log = LogCollection[index];

                    log.CheckOut = DateTime.Now;

                    log.Save();
                }

                return true;
            }
            
        }

        public static List<EmployeeLogs> GetByDate(DateTime start, DateTime end)
        {
            var query = Query.And(
               Query.GTE("RegisterDate", start.Date),
               Query.LTE("RegisterDate", end.Date.AddDays(1))
               );

            var list = EntityService.GetCollection<EmployeeLogs>().Find(query).ToList();

            return list;
        }
    }
}
