namespace Entities.Concretes
{
    public class Favorite
    {
        public DateTime CreateTime { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}