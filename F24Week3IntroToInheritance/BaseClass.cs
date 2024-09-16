using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24Week3IntroToInheritance
{
    public class BaseClass
    {
        public int _id;

        public BaseClass()
        {
            Console.WriteLine("Base class constructor called");
        }

        public BaseClass(string message)
        {
            Console.WriteLine("Base class constructor with message: " + message);
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base("hello")
        {
            Console.WriteLine("Derived class constructor called");
        }
    }
}
