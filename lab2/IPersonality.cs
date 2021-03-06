﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    interface IPersonality<T> where T : Person
    {
        String Name { get; set; }

        String Surname { get; set; }

        String PersonalInfo();

        void Introduction();
    }
}
