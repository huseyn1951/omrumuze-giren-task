using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omrumuze_giren_task
{
    public class Writer
    {
        public string Name { get; set; }

        public string Surname { get; set; }

      


        public Writer(string name,string surname)
        {
            Name = name;
            Surname = surname;
            
        }
    }
}
