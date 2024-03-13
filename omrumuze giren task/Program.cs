using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omrumuze_giren_task
{
    class Program
    {
        static void Main(string[] args)

        {
            Writer writer1 = new Writer("Lev","Tolstoy");
            Writer writer2 = new Writer("Zlatan", "ibrahimovic");
            Writer writer3 = new Writer("Ferhad", "Azadaliyev");
            WriterServices writerr1 = new WriterServices("idiot",560,"Roman",30,"Tolstoy");
            WriterServices writerr2 = new WriterServices("i am zlatan ibrahimovic", 250, "biografiya", 50, "Zlatan");
            WriterServices writerr3 = new WriterServices("Mauqli", 700, "Animal", 10, "Ferhad");

            BookServices book1 = new BookServices("Idiot", 560, "Roman", 30,"Tolstoy");
            BookServices book2 = new BookServices("i am zlatan ibrahimovic",250,"biografiya",50,"Zlatan");
            BookServices book3 = new BookServices("Mauqli",700,"Animal",10,"Ferhad");

            List<Book> kitablar = new List<Book> { book1,book2, book3 };
            List<WriterServices> yazicilar = new List<WriterServices> { writerr1 };

            book1.ShowBookName();
            book1.ShowAuthor();
            book1.ShowPageCount();
            book1.FindMaxPageCount(kitablar);
            book1.ShowAuthorAndName(kitablar);
            book1.ShowPrice(kitablar);
            book1.ShowBooksGenre(kitablar);
            Console.WriteLine("///////////////////");
           


        }
        
    }

}
