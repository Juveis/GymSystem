using System.Collections.Generic;
using System.Linq;
using Mongo.Entity;

namespace Core.Entities.Members.Enums
{
    public class MembershipType : MongoEntity
    {
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Period { get; set; }

        public static List<MembershipType> GetAll()
        {
            var collection = EntityService.GetCollection<MembershipType>().FindAll().ToList();

            if (collection.Count == 0)
            {
                return new List<MembershipType>();
            }
            else
            {
                return collection;
            }

        }
    }
}
