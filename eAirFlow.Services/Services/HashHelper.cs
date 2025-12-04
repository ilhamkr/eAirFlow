using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public static class HashHelper
    {
        public static string GenerateSalt()
        {
            var bytes = new byte[16];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        public static string GenerateHash(string salt, string password)
        {
            using var sha = SHA256.Create();
            var combined = salt + password;
            var bytes = Encoding.UTF8.GetBytes(combined);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
