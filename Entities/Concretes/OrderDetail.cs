namespace Entities.Concretes
{
    public class OrderDetail // Bir sipariş detayının birden fazla siparişi olamaz.
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Piece { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order {  get; set; }

    }
}