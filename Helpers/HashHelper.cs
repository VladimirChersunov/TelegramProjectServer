using BCrypt.Net;
using System.Security.Cryptography;

namespace server.Helpers
{
    public static class HashHelper
    {
        public static string HashPassword(string password)
        {
            string pswToHash = password + "~KIN^XX";
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hash = BCrypt.Net.BCrypt.HashPassword(pswToHash, salt);
            return hash;
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password+"~KIN^XX", hashedPassword);
        }
    }
}
