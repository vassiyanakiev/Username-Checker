using System;
using System.Linq;

namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var username in usernames)
            {
                if (IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValid(string username)
        {
            return IsValidLenght(username) && ContaingValidSymbols(username);
        }

        private static bool ContaingValidSymbols(string username)
        {
            foreach (char symbol in username)
            {
                if (!char.IsLetterOrDigit(symbol) && symbol != '_' && symbol != '-')
                {
                    return false;
                }
               
            }

            return true;
        }

        private static bool IsValidLenght(string username)
        {
            return username.Length >= 3 && username.Length <= 16;
        }
    }
}
