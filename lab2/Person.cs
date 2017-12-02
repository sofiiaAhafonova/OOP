using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    //delegate void PersonBirth(Hospital hosp, BornEventArgs e);
    public class Person : Human, IPersonality<Person>, IComparable<Person>, IHumanBeing<Person>
    {
        
        protected String name;
        protected String surname;

        public String Name { get; set; }
        public String Surname { get; set; }
        public Person() : base()
        {
            name = "John";
            surname = "Joe";
        }
        public Person(int height, int weight, String name, String surname) : base(height, weight)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.surname = surname;
        }
        public override void Introduction()
        {
            Console.WriteLine($"Hello, I'm {name} {surname}, my height is {height} and weight {weight}");
        }
        public String PersonalInfo()
        {
           return ("My name is" + name + " " + surname);
        }
        public void Birth(Hospital h, BornEventArgs b)
        {
            Console.WriteLine("I was borned at " + DateTime.Now);
        }
        public void BodyParams()
        {
            Console.WriteLine($"Weight :{weight} kg; height: {height} cm");
        }
        //compares two Person's surnames and names and returns int that 
        //indicates their relative position in the sort order
        public int CompareTo(Person other)
        {
            if (other == null)
                throw new NullReferenceException();
            int flag = String.Compare(this.surname, other.surname, true);
            if (flag == 0)
                return String.Compare(this.name, other.name, true);
            return flag;
           
        }
    }
}