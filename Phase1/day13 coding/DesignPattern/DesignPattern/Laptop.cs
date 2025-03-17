using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Laptop
    {

        public string processor { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string CPU { get; set; }



        public void showSpecification()
        {

            Console.WriteLine($"processor : {processor}");

        }
    }


}
