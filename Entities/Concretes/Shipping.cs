namespace Entities.Concretes
{
    public class Shipping
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? ShippingCompanyId { get; set; } // Henüz şirket atanmadıysa null dönecektir.
        public string TrackingNumber { get; set; }
        public DateTime ShipmentDate { get; set; }
        public DateTime EstimateDelivery { get; set; }
        public DateTime DeliveryDate { get; set; }

        public virtual ShippingCompany ShippingCompany { get; set; }
        public virtual Order Order { get; set; }
    }
}