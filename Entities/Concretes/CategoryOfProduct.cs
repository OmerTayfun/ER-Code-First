namespace Entities.Concretes
{
    public class CategoryOfProduct
    {
        //Ara tablonun idsi genellikle yazılmaz.
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Product Product { get; set; }

    }
}