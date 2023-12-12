using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopProject.Models
{
    public class Publisher : BaseModel
    {
        public int PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string Adress { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<Author> Authors { get; set; } 
    }
}
