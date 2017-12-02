using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(40, 5, "Stiv", "Ostiin");
            p.Gender = "male";
           
            Hospital h = new Hospital();
            h.Birth(p);
 Console.ReadKey();
        }
    }
}
