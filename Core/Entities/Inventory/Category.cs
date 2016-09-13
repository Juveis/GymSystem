using System.Collections.Generic;
using System.Linq;
using Mongo.Entity;
using MongoDB.Driver.Builders;

namespace Core.Entities.Inventory
{
    public class Category : BasicInfo
    {
        //Properties
        public List<StockType> StockType { get; set; }
        public Area Area { get; set; }

        //Methods
        public static List<Category> GetAll()
        {
            return EntityService.GetCollection<Category>().FindAll().ToList();
        }

        public static List<Category> GetByArea(Area area)
        {
            var query = Query.EQ("Area", area);

            return EntityService.GetCollection<Category>().Find(query).ToList();
        }
    }
}
