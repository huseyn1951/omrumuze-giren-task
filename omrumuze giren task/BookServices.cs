using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omrumuze_giren_task
{
    public class BookServices:Book
    {
        public BookServices(string name,int pageCount,string genre,int price,string author): base(name,pageCount,genre,price,author)
        {

        }

        public void ShowBookName()
        {
            Console.WriteLine(this.Name);
        }

        public void ShowAuthor()
        {
            Console.WriteLine(this.Author);
        }

        public void ShowPageCount()
        {
            Console.WriteLine(this.PageCount);
        }
        public void FindMaxPageCount(List<Book> kitablar)
        {
            int max = 0;

            foreach (var book in kitablar)
            {
                if (book.PageCount > max)
                {
                    max = book.PageCount;
                }
            }

            Console.WriteLine(max);
        }

        public void ShowAuthorAndName(List<Book> kitablar)
        {
            foreach (var book in kitablar)
            {
                Console.WriteLine(book.Name +  " " + book.Author);
            }
        }

        public void ShowPrice(List<Book> kitablar)
        {
            foreach (var book in kitablar)
            {
                Console.WriteLine(book.Price);
            }
        }

        public void ShowBooksGenre(List<Book> kitablar)
        {
            foreach (var book in kitablar)
            {
                Console.WriteLine(book.Genre);
            }
        }

       /* public void ShowGenreCount(List<Book> kitablar)
        {
            foreach (var book in kitablar)
            {
                Console.WriteLine(book.Genre);

                if (Genre.Count<string>
                {

                }
            }

        }*/





    }
}
