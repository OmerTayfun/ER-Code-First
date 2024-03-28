namespace Entities.Concretes
{
    public class ShippingCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Shipping> Shippings { get; set; }
    }
}