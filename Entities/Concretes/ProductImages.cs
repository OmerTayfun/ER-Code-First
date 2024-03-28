namespace Entities.Concretes
{
    public class ProductImages
    {
        public int ProductImagesId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}