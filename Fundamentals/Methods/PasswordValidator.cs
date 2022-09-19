using System;
using System.Linq;
using System.Collections.Generic;

namespace passwordValidator
{
    internal class Program
    {
     
        static bool IsAllLettersOrDigitsOrUnderscores(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c) && c != '_')
                    return false;
            }
            return true;
        }
        static bool twoDigits(string word)
        {
            int count = 0;
            foreach (char c in word)
            {
                if (Char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void validation(string password)
        {
            bool flag = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                flag = false;
            }
            if (IsAllLettersOrDigitsOrUnderscores(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                flag = false;
            }
            if (twoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("Password is valid");
            }


        }
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            validation(password);

        }
    }
}