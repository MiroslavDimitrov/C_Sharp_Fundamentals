using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(CountVowels(input));
        }
        /// <summary>
        /// Method to sum the count of vowels in the input string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static int CountVowels(string str)
        {
            int sum = 0;
            //loop for the string
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals('a') || str[i].Equals('e') || str[i].Equals('i') || str[i].Equals('o') || str[i].Equals('u')
                    || str[i].Equals('A') || str[i].Equals('E') || str[i].Equals('I') || str[i].Equals('O') || str[i].Equals('U'))
                {
                    sum += 1;
                }
            }
            return sum;
        }
    }
}