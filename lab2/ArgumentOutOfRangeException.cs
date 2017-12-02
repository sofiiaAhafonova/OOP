using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ArgumentOutOfRangeException:Exception
    {
        protected string notAGender;

        protected ArgumentOutOfRangeException(): base(){ }

        public ArgumentOutOfRangeException(string value) :
         base(String.Format("{0} is not a gender.", value))
        {
            notAGender = value;
        }

        public ArgumentOutOfRangeException(string value, string message)
         : base(message)
         {
            notAGender = value;
        }
    }
}
