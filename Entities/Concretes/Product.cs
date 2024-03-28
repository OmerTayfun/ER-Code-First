using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CrateDate { get; set; }
        public DateTime ModifiedDate { get; set;}
        public bool Status { get; set; }
        //Teke tek ilişkilerde sınıfın idsi tutulur.
        //Collection ile alınan sınıfların idsi tutulmaz.
        public virtual ICollection<ProductImages> ProductImages { get; set; }
        public virtual ICollection<ProductVideos>ProductVideos { get; set; }
        public virtual ICollection<ProductAttributes> ProductAttributes { get; set; }
        public virtual ICollection<CategoryOfProduct> Categories { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Favorite Favorite { get; set; }


    }
}
