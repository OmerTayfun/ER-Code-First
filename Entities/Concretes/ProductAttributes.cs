namespace Entities.Concretes
{
    public class ProductAttributes
    {
        public int ProductAttributesId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
       // public virtual ICollection<Product> Products { get; set; }
    }
}