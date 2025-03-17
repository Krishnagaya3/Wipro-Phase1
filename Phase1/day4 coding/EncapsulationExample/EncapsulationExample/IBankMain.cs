using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    internal interface IBankMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Bank Name for which you want make transactions : ");
            String bn = Console.ReadLine();

            AbstractBank bnb = BankNames.GetBankName(bn);
            bnb.OpenAccount();
            bnb.BankTransfer();


        }
    }
}
