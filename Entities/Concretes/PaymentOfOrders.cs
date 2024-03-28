namespace Entities.Concretes
{
    public class PaymentOfOrders
    {
        public int PaymentId { get; set; }
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public virtual Payment Payment { get; set; }
    }
}