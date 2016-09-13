using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Members
{
    public class Packages
    {
        /*
        Membership states:
        -Activa
        -Cancelada
        -Vencida          
            
            */
        public int MembershipNumber { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime StartDate { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime EndDate { get; set; }
        public int State { get; set; }
        public int Renewals { get; set; }
        public int Visits { get; set; }
        public decimal MembershipCost { get; set; }
        public string Notes { get; set; }
        public DateTime RegisterDate { get; set; }
        public static Dictionary<string, int> States
        {
            get
            {
                var dic = new Dictionary<string, int>
                {
                    {"Activa", 1},
                    { "Cancelada", 2},
                    { "Vencida", 3}
                };

                return dic;
            }
        }


    }
}
