using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookShopProject.Models
{
    public class Book : BaseModel
    {
        public int ShelfId { get; set; }
        public string Language { get; set; }
        public int PageCount {  get; set; } = 0;
        public string? ISBN { get; set; }
        public bool IsDigital { get; set; } = false;
        public DateTime YearOfPublication { get; set; } 
        public string? Img { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; } 
        public virtual ICollection<Category> Categories { get; set; } 
        public virtual ICollection<Author> Authors { get; set; } 
        public virtual Shelf Shelf {  get; set; } 
    }
}
