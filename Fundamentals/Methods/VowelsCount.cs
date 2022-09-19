using System;

namespace VowelCount
{
    internal class VowelsCount
    {
        static int vowelsCount(char[] letters)
        {
            int count = 0;
            for (int i = 0; i < letters.Length; ++i)
            {
                if (letters[i] == 'a' || letters[i] == 'e' || letters[i] == 'i' || letters[i] == 'o' || letters[i] == 'u' || letters[i] == 'A' || letters[i] == 'E' || letters[i] == 'I' || letters[i] == 'O' || letters[i] == 'U')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] letters = word.ToCharArray();
            Console.WriteLine(vowelsCount(letters));

        }
    }
}