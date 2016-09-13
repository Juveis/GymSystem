using System.Collections.Generic;
using System.Linq;
using Mongo.Entity;

namespace Core.Entities
{
    public class Country : MongoEntity
    {
        //PROPERTIES
        public string CountryName { get; set; }
        public List<City> Cities { get; set; }

        public static List<Country> Countries { get; set; }

        public static void GetCountries()
        {
            Countries = EntityService.GetCollection<Country>().FindAllAs<Country>().ToList().OrderBy(x => x.CountryName).ToList();
        }
        
        //CLASS CITY
        public class City
        {
            public string CityName { get; set; }
        }
    }
}
