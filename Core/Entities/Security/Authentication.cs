using System;
using Core.Entidades.Seguridad;
using Mongo.Entity;
using MongoDB.Driver.Builders;

namespace Core.Entities.Security
{
    public class Authentication
    {
        public static bool Authenticate(string struser, string password)
        {
            password = Encrypt.encrypt_using_sha256(password);

            try
            {
                var criterio = Query.And(
                    Query.EQ("UserName", struser),
                    Query.EQ("Password", password),
                    Query.EQ("Status", true)
                );

                var collection = EntityService.GetCollection<Usuario>();
                var user = collection.FindOneAs<Usuario>(criterio);


                if (user != null)
                {
                    Usuario.CurrentUser = user;
                    Usuario.CurrentUser.LastAccess = DateTime.Now;
                    Usuario.CurrentUser.Save();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }


        }
    }
}
