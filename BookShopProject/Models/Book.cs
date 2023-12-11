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
        public int PageCount {  get; set; } = 0;
        public string? ISBN { get; set; }
        public bool IsDigital { get; set; } = false;
        public DateTime YearOfPublication { get; set; } 
        public string? Img { get; set; }
        public ICollection<Publisher> Publisher { get; set; } = new List<Publisher>();
        public ICollection<Category> categories { get; set; } = new List<Category>();
        public ICollection<Author> Authors { get; set; } = new List<Author>();
        public virtual Shelf Shelf {  get; set; } 
    }
}
