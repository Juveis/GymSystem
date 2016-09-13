using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mongo.Entity;

namespace Core.Entities.Programs
{
    public class Program : MongoEntity
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Period { get; set; }
        public DateTime RegisterDate { get; set; }

        public static List<Program> GetPrograms()
        {
            try
            {
                var programs = EntityService.GetCollection<Program>().FindAll().ToList();

                return programs;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
