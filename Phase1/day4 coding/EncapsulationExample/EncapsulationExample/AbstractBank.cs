using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public abstract class AbstractBank
    {
        //Service Part - functionalities :Bank Transfer , Withdraw , Deposit , Statement Generation , Loan , Enquire

        //Bank : SBI, Axis, PNB

        /* Abstract class is like a concrete class but here the methods are abstract and non-abstract , it also contains 
        attribute 0 to 100%*/
        /* When you want to share the common methods among all the concrete classes you use abstract class */

        public abstract void OpenAccount();
        public abstract void BankTransfer();

        public abstract void Withdraw();

        public abstract void Deposit();


        public abstract void MiniStatement();

        public void BankHolidays()
        {
            Console.WriteLine("Off DAYS");


        }
    }

    public class BankNames
    {

        public static AbstractBank GetBankName(string bankName)
        {

            AbstractBank bankobj = null;

            if (bankName == "SBI")
            {
                bankobj = new SBI();
            }
            else if (bankName == "Axis")
            {
                bankobj = new Axis();
            }
            return bankobj;
        }




    }
}
