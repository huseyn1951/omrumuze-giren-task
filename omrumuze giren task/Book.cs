using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omrumuze_giren_task
{
    public class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }

        public Book(string name, int pageCount, string genre, int price,string author)
        {
            Name = name;
            PageCount = pageCount;
            Genre = genre;
            Price = price;
            Author = author;
        }
    }
}
