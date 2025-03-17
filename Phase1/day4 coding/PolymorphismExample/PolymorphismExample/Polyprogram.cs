using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Distance
    {
        public int Kilometers;

        public Distance(int km)
        {

            Kilometers = km;

        }

        public static Distance operator +(Distance a, Distance b)
        {

            return new Distance(a.Kilometers + b.Kilometers);
        }

        public void result()
        {
            Console.WriteLine($"The total distance : {Kilometers}");

        }

    }
    class Program2
    {
        public static void run()
        {



            Distance d1 = new Distance(10);
            Distance d2 = new Distance(20);
            Distance totalDistance = d1 + d2;

            totalDistance.result();


        }
    }
}
