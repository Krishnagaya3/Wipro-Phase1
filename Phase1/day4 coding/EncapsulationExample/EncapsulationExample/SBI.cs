using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class SBI : AbstractBank
    {    /*Overridden  -- contract says when you inherit the abstract class you have to override all the 
         abstract methods and give your own definition*/


        public override void BankTransfer()
        {

            Console.Write("Bank Amount Transferred");

        }

        public override void Deposit()
        {
            Console.Write("Bank Amount Deposited");

        }

        public override void MiniStatement()
        {
            Console.Write("Bank Amount Statement");

        }

        public override void OpenAccount()
        {
            Console.Write("SBI Account Opened");

        }

        public override void Withdraw()
        {
            Console.Write("Bank Amount Withdrawn");

        }
    }

}
