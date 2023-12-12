using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookShopProject.Models
{
    public class Library : BaseModel
    {
        public string Adress {  get; set; }
        public string PhoneNumber {  get; set; } 
        public bool IsOpen { get; set; }
        public bool IsClosed { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Shelf> Shelf { get; set; } 
    }
}
