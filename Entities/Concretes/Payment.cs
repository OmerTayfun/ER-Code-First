namespace Entities.Concretes
{
    public class Payment // ? 
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CardNumber { get; set; }
        public int PaymentTypeId { get; set; }
        public int OrderId { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Order Order { get; set; }
       
    }
}