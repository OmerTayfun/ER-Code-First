namespace Entities.Concretes
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CrateDate { get; set; }
        public DateTime ModifieDate { get; set; }
        public bool Status { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }

    }
}