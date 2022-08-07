using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            PrintCharacters(first, second);
        }

        /// <summary>
        /// Method who prints the range between two characters, exluding them from the output
        /// </summary>
        /// <param name="theFirst"></param>
        /// <param name="theSecond"></param>
        static void PrintCharacters(char theFirst, char theSecond)
        {
            if (theFirst > theSecond)
            {
                for (int i = theSecond + 1; i < theFirst; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
            else
            {
                for (int i = theFirst + 1; i < theSecond; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
        }
    }
}