using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omrumuze_giren_task
{
    public class WriterServices : BookServices

    {
        public WriterServices(string name, int pageCount, string genre, int price, string author) : base(name, pageCount, genre, price, author)
        {

        }
        public void ShowAuthtorsBooks(List<WriterServices> yazicilar)
        {
            foreach (var yazici in yazicilar)
            {
                Console.WriteLine(yazici.Name);
            }

        }
    }
}
