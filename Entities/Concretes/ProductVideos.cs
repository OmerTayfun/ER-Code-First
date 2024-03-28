namespace Entities.Concretes
{
    public class ProductVideos
    {
        public int ProductVideosId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}