using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Human
    {
        private string gender;
        protected int height;
        protected int weight;

        protected int age;

        public Human()
        {
            height = 180;
            weight = 75;
            gender = "male";
            age = 27;

        }
        public Human(int height, int weight, int age)
        {
            this.height = height;
            this.weight = weight;
            this.age = age;
            gender = "male";
        }
        public Human(int height, int weight)
        {
            this.height = height;
            this.weight = weight;
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                    this.gender = value;
                else
                    throw new ArgumentOutOfRangeException(
                    "Gender must be only male or female!");
            }
        }

        public abstract void Introduction();
        public void PrintChars()
        {
            Console.WriteLine("Height :{0}, weight:{1}, age:{2}, gender: {3}", height, weight, age, gender);
        }

    }
}
