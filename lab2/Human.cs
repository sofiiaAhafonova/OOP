using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class Human
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
        public int Weight {
            get { return weight; }
            set {
                if (value < 3 || value > 300)
                    throw new ArgumentOutOfRangeException("Invalid weight");
                weight = value;
            }
        }
        public int Height {
            get { return height; }
            set {
                if (value < 50 || value > 250)
                    throw new ArgumentOutOfRangeException("Invalid height");
                height = value;
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                    this.gender = value;
                else
                    throw new InvalidArgException(" is not a gender", value);
            }
        }

        public abstract void Introduction();
    }
}
