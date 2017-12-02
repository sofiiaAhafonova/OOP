﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    [Serializable()]
    public class InvalidArgException : System.Exception
    {
        public InvalidArgException() : base() { }
        public InvalidArgException(string message) : base(message) { }
        public InvalidArgException(string message, String value) : base(message)
        {
            Console.WriteLine(value + message);
        }
        public InvalidArgException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidArgException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
