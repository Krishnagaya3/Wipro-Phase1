using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecurityExample
{
    public class UserAuthentication
    {
        private string Username;
        private string HashedPassword;

        public void Register(string username, string password)
        {
            Username = username;
            HashedPassword = HashPassword(password);
        }

        public bool Authenticate(string username, string password)
        {
            return Username == username && HashedPassword == HashPassword(password);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
