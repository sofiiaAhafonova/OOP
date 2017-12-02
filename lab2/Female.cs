using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Female : Person
    {
        static string gender;
        static Female()
        {
            gender = "female";
        }
        public Female()
        {
            height = 168;
            weight = 55;
            age = 22;
            name = "Jane";
            surname = "Dou";
        }
        public Female(int height, int weight, int age, String name, String surname):base(height,weight, name, surname)
        { 
        }
        public void AnalyzeBMI()
        {
            Console.Write("I'm a woman. My BMI is {0:0.##} ", BMI.ComputeBMI(weight, height));
            if (BMI.ComputeBMI(weight, height) < 16)
                Console.Write("so I'm too slim");
            else
                Console.Write("so I'm fat");
        }

        public override void Introduction()
        {
            Console.WriteLine("I'm a Woman");
        }
    }
}
