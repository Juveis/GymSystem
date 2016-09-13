using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades.Billing;
using Core.Entidades.Seguridad;
using Core.Entities.Security;
using Mongo.Entity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Core.Entities.Billing
{
    public class Reconcile : MongoEntity
    {
        //Class constructor
        public Reconcile()
        {
            //Number = GetNextNumber();
        }

        
        //Properties
        public int Number { get; set; }

        public int BillsFrom { get; set; }
        public int BillsUntil { get; set; }

        public int VoidedBills { get; set; }

        public List<SalesByUsers> _SalesByUsers { get; set; }

        public decimal Cash { get; set; }
        public int NumberOfSalesCash { get; set; }
        public decimal Card { get; set; }
        public int NumberOfSalesCards { get; set; }
        public decimal Credit { get; set; }
        public int NumberOfSalesCredit { get; set; }
        public decimal Check { get; set; }
        public int NumberOfSalesCheck { get; set; }

        //Payments
        public decimal TotalPayments { get; set; }

        //Total Reconcile
        public decimal TotalSoldAmount { get; set; }

        public Guid UserId { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegisterDate { get; set; }


        //Private Methods
        
        //Public static methods
        public static int GetNextNumber()
        {
            var sortBy = SortBy.Descending("Number");

            var collection = EntityService.GetCollection<Reconcile>().FindAll().SetSortOrder(sortBy).SetLimit(1).ToList();

            if (collection.Count != 0)
            {
                var number = collection[0].Number + 1;

                return number;
            }
            else
            {
                return 1;
            }
        }

        public static Reconcile GenerateReconcile(DateTime start, DateTime end)
        {
            var bills = Bill.GetByDate(start, end);

            if (bills.Count == 0)
            {
                return null;
            }
            else
            {
                var billsFrom = bills[0].Number;
                var billsUntil = bills[bills.Count - 1].Number;

                #region//Totals
                var voidedBills = bills.Count(bill => bill.Condition == "Anulada");

                var cash = bills.Where(bill => bill.PaymentMethod == "Efectivo" && bill.Condition != "Anulada").Sum(bill => bill.Total);
                var card = bills.Where(bill => bill.PaymentMethod == "Tarjeta" && bill.Condition != "Anulada").Sum(bill => bill.Total);
                var credit = bills.Where(bill => bill.PaymentMethod == "Crédito" && bill.Condition != "Anulada").Sum(bill => bill.Total);
                var check = bills.Where(bill => bill.PaymentMethod == "Cheque" && bill.Condition != "Anulada").Sum(bill => bill.Total);

                //Numbers of sales by type
                var numberCash = bills.Count(bill => bill.PaymentMethod == "Efectivo" && bill.Condition != "Anulada");
                var numberCard = bills.Count(bill => bill.PaymentMethod == "Tarjeta" && bill.Condition != "Tarjeta");
                var numberCredit = bills.Count(bill => bill.PaymentMethod == "Crédito" && bill.Condition != "Crédito");
                var numberCheck = bills.Count(bill => bill.PaymentMethod == "Cheque" && bill.Condition != "Anulada");

                var totalSoldAmount = cash + card + credit + check;
                #endregion

                #region//Get Total Payments

                var totalPayments = Entidades.Billing.Payments.Payments.GetTotalPayment(start, end);

                #endregion

                #region//Get the sales by users

                var salesByUsers = new List<SalesByUsers>();

                var sales = bills.GroupBy(e => e.UserId).Select(grp => grp.First()).ToList();

                foreach (var sale in sales)
                {
                    var user = Usuario.GetUser("_id", sale.UserId).UserName;
                    var total = bills.Where(e => e.UserId == sale.UserId).Sum(e => e.Total);
                    var numberOfSales = bills.Count(e => e.UserId == sale.UserId);

                    salesByUsers.Add(
                        new SalesByUsers()
                        {
                            User = user,
                            Total = total,
                            NumberOfSales = numberOfSales
                        }
                        );
                }
                #endregion

                #region//Create the Reconcile
                var reconcile = new Reconcile()
                {
                    BillsFrom = billsFrom,
                    BillsUntil = billsUntil,

                    VoidedBills = voidedBills,

                    _SalesByUsers = salesByUsers,

                    Cash = cash,
                    Card = card,
                    Credit = credit,
                    Check = check,

                    NumberOfSalesCards = numberCard,
                    NumberOfSalesCash = numberCash,
                    NumberOfSalesCredit = numberCredit,
                    NumberOfSalesCheck = numberCheck,

                    TotalPayments = totalPayments,

                    TotalSoldAmount = totalSoldAmount,

                    UserId = Usuario.CurrentUser.Id,

                    RegisterDate = DateTime.Now
                };

                //Return Reconcile
                return reconcile;
                #endregion
            }
        }

        //Bussiness Rules

        //Verify pending reconcile

    }
}
