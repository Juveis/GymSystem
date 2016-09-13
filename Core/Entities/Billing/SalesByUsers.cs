namespace Core.Entities.Billing
{
    public class SalesByUsers
    {
        public string User { get; set; }
        public int NumberOfSales { get; set; }
        public decimal Total { get; set; }
    }
}
