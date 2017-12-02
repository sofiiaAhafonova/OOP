using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public delegate void BirthHandle(Hospital pers, BornEventArgs e);
    public class BornEventArgs: EventArgs
    {
        public String name;
        public DateTime dateOfBirth;
        public String Name { get; set; }
        public  DateTime DateOfBirth { get; set; }
        public BornEventArgs() { }

    }
}
