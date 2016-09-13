using Core.Entities.Members;

namespace PunchSystem
{
    public class ValidateCustomer
    {
        public void Access(Member customer)
        {
            //if (customer.Membership.NextPay.Date >= DateTime.Now.Date)
            //{
            //    var access = new AccesRegister
            //        {
            //            MembershipNumber = customer..Number,
            //            FirstName = customer.FirstName,
            //            LastName = customer.FirstLastName,
            //            DateHour = DateTime.Now,
            //            Approved = true
            //        };

            //    access.Save();

            //    customer.Membership.State = "Activa";
            //    customer.Save();
            //}
            //else
            //{
            //    var access = new AccesRegister
            //        {
            //            MembershipNumber = customer..Number,
            //            FirstName = customer.FirstName,
            //            LastName = customer.FirstLastName,
            //            DateHour = DateTime.Now,
            //            Approved = false
            //        };

            //    access.Save();

            //    customer.Membership.State = "Inactiva";
            //    customer.Save();
            //}
        }
    }
}
