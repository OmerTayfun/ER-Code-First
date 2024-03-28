using System.Runtime.InteropServices.Marshalling;

namespace Entities.Concretes
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public int OrderStatusTypeId { get; set; }
        public int UserAddressId { get; set; }
        public virtual OrderStatusType OrderStatusType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<Shipping> Shippings { get; set; }
        public virtual ICollection<PaymentOfOrders> PaymentOfOrders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

    }
}