using Passwords_Gen.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords_Gen.Service.Services
{
    public class PasswordService : IPasswordService
    {
        public string GenerateRandomPassword(int length)
        {
            var charsLetters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%&*()[{}]/?";
            Random rndLetters = new();
            var randLetters = new String(Enumerable.Repeat(charsLetters, length)
                .Select(s => s[rndLetters.Next(s.Length)]).ToArray());
            var result = new StringBuilder(randLetters);
            return result.ToString();
        }
    }
}
