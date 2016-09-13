using System;

namespace Core.Entities.Members
{
    public class MemberReport
    {
        //Datos Personales
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        //Identificacion
        public string CardPassport { get; set; }
        public string Nationality { get; set; }

        //Contactos
        public string Telehone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }

        //Direccion
        public string City { get; set; }
        public string Country { get; set; }
        public string Secction { get; set; }
        public string Street { get; set; }
        public string House { get; set; }

        //Credit
        public decimal CreditLimit { get; set; }

        public DateTime RegisterDate { get; set; }

        public Guid UserId { get; set; }
        
        public int MembershipNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
