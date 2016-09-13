using System;
using System.Collections.Generic;
using Mongo.Entity;

namespace Core.Entities
{
    public abstract class Person : MongoEntity
    {
        #region //Propiedades

        public int Number { get; set; }
        public string Status { get; set; }

        //Personal Information
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        //Identification
        public string CardPassport { get; set; }
        public string Nationality { get; set; }

        //Contacts
        public string Telehone { get; set; }
        public string CellPhone { get; set; }
        public string OfficeTelephone { get; set; }
        public string Email { get; set; }

        //Address
        public string City { get; set; }
        public string Country { get; set; }
        public string Secction { get; set; }
        public string Street { get; set; }
        public string House { get; set; }

        //Notes
        public List<string> Notes { get; set; }

        //Credit
        public decimal CreditLimit { get; set; }

        public DateTime RegisterDate { get; set; }

        public Guid UserId { get; set; }
        #endregion
    }
}
