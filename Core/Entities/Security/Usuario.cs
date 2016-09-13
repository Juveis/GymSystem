using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Security
    
{
    public class Usuario : MongoEntity
    {
        //Properties
        public Guid IdEmployee { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public bool Status { get; set; }
        public string Type { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime LastAccess { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegisterDate { get; set; }

        public List<Modulos> Modules { get; set; }

        public static Usuario CurrentUser;

        //Methods
        public static List<Usuario> ListaUsuarios()
        {
            try
            {
                var collection = EntityService.GetCollection<Usuario>().FindAll();
                var usuarios = collection.ToList();
                return usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }

        public static Usuario GetUser(string field, Guid value)
        {
            try
            {
                var query = Query.EQ(field, value);

                return EntityService.GetCollection<Usuario>().FindOne(query);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        //Overide
        public override string ToString()
        {
            return this.UserName;
        }
        
    }
}
