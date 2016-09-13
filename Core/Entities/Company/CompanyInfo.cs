using Mongo.Entity;

namespace Core.Entities.Company
{
    public class CompanyInfo : MongoEntity
    {
        public string CommercialName { get; set; }
        
        public string RNC { get; set; }

        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebPage { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string Section { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }

        public static CompanyInfo GetInfo()
        {
            var info = new CompanyInfo()
                {
                    CommercialName = "ZION WELLNESS CENTER",
                    Phone = "(809)-276-9222",
                    City = "SANTIAGO",
                    Street = "AV. 27 DE FEBRERO",
                    Building = "PLAZA ALFA"
                };

            return info;
        }
    }
}
