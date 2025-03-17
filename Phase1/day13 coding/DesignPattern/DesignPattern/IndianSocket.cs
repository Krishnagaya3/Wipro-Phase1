using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    //What we need
    public interface IndianSocket
    {
        void plugIn();  // This means Indian socket  need a 3- pin plug
    }


    //what we have
    class AmericanCharger
    {
        void connect()
        {
            Console.WriteLine("Charging with 2 pin");
        }
    }

    class ChargerAdapter : IndianSocket
    {
        private AmericanCharger charger;

        public ChargerAdapter(AmericanCharger charger)
        {
            this.charger = charger;
        }

        public void plugIn()
        {
            Console.WriteLine("Using adapter to convert 2-pin to 3-pin");
        }
    }

    public class AdapterExample
    {

        public static void Main(string[] args)
        {
            AmericanCharger charger = new AmericanCharger();

            // we are making indian to use the american one with an indian socket
            IndianSocket adapter = new ChargerAdapter(charger);
            adapter.plugIn();

        }

    }
}
