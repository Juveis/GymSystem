using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Mongo.Entity;
using MongoDB.Driver.Builders;

namespace Core.Entities.Employees
{
    public class Employee : Person
    {
        //Properties
        public int Number { get; set; }
        public string JobPosition { get; set; }
        public decimal Salary { get; set; }
        public string DescriptionComments { get; set; }        

        
        //Methods
        public static List<Employee> GetEmployee(string field, string value)
        {
            var query = Query.EQ(field, value);

            var employeeList = EntityService.GetCollection<Employee>().Find(query).ToList();

            return employeeList;
        }

        public static Employee GetEmployeeById(Guid id)
        {
            var query = Query.EQ("_id", id);

            var employeeList = EntityService.GetCollection<Employee>().FindOne(query);

            return employeeList;
        }

        public static List<Employee> GetAll()
        {
            var allEmployee = EntityService.GetCollection<Employee>().FindAll().ToList();

            return allEmployee;
        }

        public static int GetNextNumber()
        {
            var sortBy = SortBy.Descending("Number");

            var collection = EntityService.GetCollection<Employee>().FindAll().SetSortOrder(sortBy).SetLimit(1).ToList();

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
        
    }
}
