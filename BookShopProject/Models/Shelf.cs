using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopProject.Models
{
    public class Shelf : BaseModel
    {
        public string ShelfNumber {  get; set; }
        public virtual ICollection<Book> Books { get; set; } 
    }
}
