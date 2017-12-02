using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab2
{
    public class Hospital
    {
        Person[] babies;
        public static event BirthHandle PersonBirthEvent;
        public Hospital()
        {
            babies = new Person[2];
            babies[0] = new Person();
            Thread.Sleep(1000);
            babies[1] = new Person(40, 5, "Ben", "Ostiin");

            foreach (Person pers in babies)
            
                PersonBirthEvent += new BirthHandle(pers.Birth);

            
        }
        public void Birth(Person pers)
        {
            BornEventArgs args = new BornEventArgs();
            args.Name = pers.Name;
            args.DateOfBirth = DateTime.Now;
            Hospital.PersonBirthEvent(this, args);
        }


    }

}

