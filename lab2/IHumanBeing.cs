using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    interface IHumanBeing<T> where T: Person
    {
        String Gender {get; set;}

        int Weight { get; set; }

        int Height { get; set; }

        void BodyParams();
    }
}
