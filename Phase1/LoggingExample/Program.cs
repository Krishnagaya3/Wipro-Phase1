using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace LoggingExample
{
    public class AuthenticationService
    {
        private static readonly Logger logger=LogManager.GetCurrentClassLogger();

        private Dictionary<string, string> _users = new Dictionary<string, string>()
        {
            {"niti","password123" },
            {"john","password12345" }
        };

        public bool Login(string username, string password)
        {
            logger.Info($"Login attempt has made : {username}");
            if (!_users.ContainsKey(username))
            {
                logger.Warn($"Login failed : Incorrect password for the user : {username}");
                Console.WriteLine("Invalid Username and password");
                return false;
            }

            logger.Info($"Login successful for username : {username}");
            Console.WriteLine("Login Successful");
            return true;
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {

            //congigure NLog
            var config= new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logfile.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
            config.AddRule(LogLevel.Debug, LogLevel.Fatal,logconsole); // create a log rule wat we want store or display on console
            config.AddRule(LogLevel.Debug, LogLevel.Fatal,logfile);
            LogManager.Configuration=config; // use to apply all the configuration you have set


            AuthenticationService authenticationService = new AuthenticationService();

            //authenticationService.Login("niti", "password123");
            //authenticationService.Login("nitifd", "password123"); //should fail to loin

            int choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Enter your choice:");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Username: ");
                            string username = Console.ReadLine();
                            Console.Write("Enter Password: ");
                            string password = Console.ReadLine();
                            authenticationService.Login(username, password);
                            break;
                        case 2:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            } while (choice != 2);

        }

    }
}
