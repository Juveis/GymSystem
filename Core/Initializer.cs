using System;
using System.Windows.Forms;
using Core.Entidades.Billing.Payments;
using Core.Entities;
using Core.Entities.Accounting;
using Core.Entities.Billing;
using Core.Entities.Company;
using Core.Entities.Employees;
using Core.Entities.Inventory;
using Core.Entities.Members;
using Core.Entities.Members.Enums;
using Core.Entities.Memberships;
using Core.Entities.Security;
using Mongo.Entity;

namespace Core
{
    public class Initializer
    {
        public static void InitializeMongoDb(string connectionString)
        {
            try
            {
                //string connectionStringKey = ConfigurationManager.AppSettings.Get("copymongozionsystem");

                //string connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;
                

                var dataBaseInfo = DatabaseSettings.Parse(connectionString);
                
                EntitySettings.Register<Usuario>(dataBaseInfo, "Usuarios");

                EntitySettings.Register<Member>(dataBaseInfo, "Member");
                EntitySettings.Register<Membership>(dataBaseInfo, "Membership");
                EntitySettings.Register<MembershipsPackages>(dataBaseInfo, "MembershipsPackages");
                EntitySettings.Register<Employee>(dataBaseInfo, "Employee");
                EntitySettings.Register<Country>(dataBaseInfo, "Country");
                
                EntitySettings.Register<AccesRegister>(dataBaseInfo, "RegistroAcceso");

                EntitySettings.Register<CompanyInfo>(dataBaseInfo, "CompanyInfo");

                EntitySettings.Register<MembershipType>(dataBaseInfo, "MembershipType");
                EntitySettings.Register<MembershipPayments>(dataBaseInfo, "MembershipPayments");

                EntitySettings.Register<Category>(dataBaseInfo, "Category");
                EntitySettings.Register<Stock>(dataBaseInfo, "Stock");
                EntitySettings.Register<Supplier>(dataBaseInfo, "Supplier");
                EntitySettings.Register<Product>(dataBaseInfo, "Product");
                EntitySettings.Register<Equipment>(dataBaseInfo, "Equipment");
                EntitySettings.Register<Furniture>(dataBaseInfo, "Furniture");

                EntitySettings.Register<Bill>(dataBaseInfo, "Bill");
                EntitySettings.Register<Reconcile>(dataBaseInfo, "Reconcile");
                EntitySettings.Register<Payments>(dataBaseInfo,"Payments");
                EntitySettings.Register<Reconcile>(dataBaseInfo, "Reconcile");

                EntitySettings.Register<AccountsReceivable>(dataBaseInfo, "AccountsReceivable");

                EntitySettings.Register<EmployeeLogs>(dataBaseInfo, "EmployeeLogs");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
