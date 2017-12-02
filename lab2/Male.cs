using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Male: Person
    { 
        static string gender;
        static Male()
        {
            gender = "male";
            Console.WriteLine("This is static constructor");
        }
        public Male() : base() { }
        public Male(int height, int weight, String name, String surname) : base(height, weight, name, surname)
        {
        }
        public void AnalyzeBMI()
        {
            Console.Write("I'm a man. My BMI is {0:0.##} but I don't care what it means", BMI.ComputeBMI(weight, height));
        }
        public override void Introduction()
        {
            Console.WriteLine("I'm a Man");
        }
    }
}
