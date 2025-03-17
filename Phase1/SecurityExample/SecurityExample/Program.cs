using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace SecurityExample
{
    internal class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            ConfigureLogging();
            var auth = new UserAuthentication();
            var encryption = new DataEncryption();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the Secure Application!");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter username: ");
                        string regUser = Console.ReadLine();
                        Console.Write("Enter password: ");
                        string regPass = Console.ReadLine();
                        Console.Write("Enter data to encrypt: ");
                        string sensitiveData = Console.ReadLine();

                        auth.Register(regUser, regPass);
                        string encryptedData = encryption.Encrypt(sensitiveData);
                        Console.WriteLine("User registered successfully!");
                        Console.WriteLine("Encrypted Data: " + encryptedData);
                        break;

                    case "2":
                        Console.Write("Enter username: ");
                        string loginUser = Console.ReadLine();
                        Console.Write("Enter password: ");
                        string loginPass = Console.ReadLine();
                        if (auth.Authenticate(loginUser, loginPass))
                        {
                            logger.Info($"User {loginUser} logged in successfully.");
                            Console.Write("Enter encrypted data to decrypt: ");
                            string encryptedText = Console.ReadLine();
                            try
                            {
                                string decryptedData = encryption.Decrypt(encryptedText);
                                Console.WriteLine("Decrypted Data: " + decryptedData);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid encrypted data.");
                            }
                        }
                        else
                        {
                            logger.Warn($"Failed login attempt for user: {loginUser}");
                            Console.WriteLine("Invalid username or password.");
                        }
                        break;

                    case "3":
                        running = false;
                        logger.Info("Application exited.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        private static void ConfigureLogging()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logfile.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;
        }
    }

}
