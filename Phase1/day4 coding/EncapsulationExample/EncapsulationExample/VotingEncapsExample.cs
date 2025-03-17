using System;


namespace EncapsulationExample
{
    class Voter
    {
        private DateTime dateOfBirth;

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public void SetDateOfBirth(DateTime dob)
        {
            dateOfBirth = dob;
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public bool IsEligibleForVoting()
        {
            return CalculateAge() >= 18;
        }
    }   
    internal class VotingEncapsExample
    {
        public static void run()
        {
            Console.Write("Enter the number of voters: ");
            int numVoters=Convert.ToInt32(Console.ReadLine());

           
            //creating the array of voters
            Voter[] voters = new Voter[numVoters];

            for (int i = 0; i < numVoters; i++)
            {
                voters[i] = new Voter();

                Console.Write($"Enter date of birth for Voter {i + 1} (yyyy-mm-dd): ");
                DateTime dob;
                while (!DateTime.TryParse(Console.ReadLine(), out dob))
                {
                    Console.Write($"Invalid format. Please enter again for Voter {i + 1} (yyyy-mm-dd): ");
                }

                voters[i].SetDateOfBirth(dob);
            }

            Console.WriteLine("\nVoting Eligibility Results:");
            for (int i = 0; i < numVoters; i++)
            {
                int age = voters[i].CalculateAge();
                Console.WriteLine($"\nVoter {i + 1}: Age = {age}");

                if (voters[i].IsEligibleForVoting())
                {
                    Console.WriteLine("Status: Eligible to vote");
                }
                else
                {
                    Console.WriteLine("Status: NOT eligible to vote");
                }
            }
        }
        }
}
