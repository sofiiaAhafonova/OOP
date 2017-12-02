using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

    public class Person : Human, IPersonality, IComparable<Person>
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

        public String PersonalInfo()
        {
           return ("My name is" + name + " " + surname);
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