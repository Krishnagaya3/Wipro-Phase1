using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    class ParentClass
    {

        public ParentClass()
        {

            Console.WriteLine("Base Class Constructor Called :");
        }
        private void licenseDetails()
        {

            Console.WriteLine("Method 1 called :");

        }
        public void Method2()
        {

            Console.WriteLine("Method 2 called :");

        }
    }


    class ConsumedClass : ParentClass

    {
        private ConsumedClass()
        {
            Console.WriteLine("Child Class Constructor Called :");

        }
        public void Method3()
        {

        }
        public static void Main()
        {

            ConsumedClass c = new ConsumedClass();
            c.Method2();
            c.Method3();

            // We have not created any object of Parent Class 
            ParentClass pobj; // pobj is a variable of Parent class
            ConsumedClass cobj = new ConsumedClass(); // cobj is an instance of class child
                                                      // We can initialize a Parent class variable using child class instance 
            pobj = cobj; // here pobj is a reference of parent class created by using child class instance

            ParentClass pobj2 = new ConsumedClass();
            pobj2.Method2();

            // We cannot call any pure child class members using the reference variable of Parent
            // pobj2.method3();

            ConsumedClass cobj2 = (ConsumedClass)new ParentClass(); //down casting


        }
    }
}
