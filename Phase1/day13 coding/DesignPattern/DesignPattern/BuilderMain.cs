using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class BuilderMain
    {

        public static void Main(string[] args)
        {



            Laptop gamingLaptop = new Builder()
                                  .setProcessor("Intel core i9")
                                  .setRam("32 GB")
                                  .Build();

            gamingLaptop.showSpecification();

            Laptop companyLaptop = new Builder()
                                   .setProcessor("Intel core i5")
                                  .setRam("16 GB")
                                  .Build();



        }
    }
}

