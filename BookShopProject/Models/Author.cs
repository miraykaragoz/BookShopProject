using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopProject.Models
{
    public class Author : BaseModel
    {
        public string Biography { get; set; }
        public int DateOfBirth { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<Publisher> Publishers { get; set; } 
    }
}
