using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopProject.Models
{
    public class Category : BaseModel
    {
        public int? ParentId { get; set; }
        public virtual Category? Parent { get; set; } 
        public virtual ICollection<Book> Books { get; set; } 
    }
}
