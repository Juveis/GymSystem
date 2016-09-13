using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mongo.Entity;
using MongoDB.Driver.Builders;

namespace Core.Entities.Members
{
    public class MembershipsPackages :  MongoEntity
    {
        public int MemberNumber { get; set; }
        public List<Packages> PackagessList { get; set; }


        //Methods
        public static MembershipsPackages GerMembershipsPackages(int memberNumber)
        {
            var query = Query.EQ("MemberNumber", memberNumber);

            return EntityService.GetCollection<MembershipsPackages>().FindOne(query);
        }

    }
}
