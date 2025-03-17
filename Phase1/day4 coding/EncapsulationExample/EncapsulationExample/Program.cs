using System;

namespace EncapsulationExample

{
    public class Bank
    {
        // Hiding the member variable not to access directly
        private double balance;

        public double GetBalance()
        {
            return balance;

        }

        public void SetBalance(double balanceamount)
        {
            if (balanceamount > 0)
            {
                this.balance = balanceamount;
            }
            else
            {

                Console.WriteLine("Negative Value is not allowed ");

            }
        }

    }

    class Program
    {

        public static void Main(string[] args)
        {   //To access the member variables if it is public or member methods of any class we have to create an obj and then access it
            //new keyword is used to allocate the memory to that object
            //Bank() use to initialize the instance values of that class members
            // declaration


            //Console.WriteLine("Enter the amount to save :");
            //double am = Convert.ToDouble(Console.ReadLine());
            //Bank bank = new Bank();
            ////  Console.WriteLine(bank.balance);

            //bank.SetBalance(am);
            //Console.WriteLine(bank.GetBalance());
            VotingEncapsExample.run();
        }

    }


}
