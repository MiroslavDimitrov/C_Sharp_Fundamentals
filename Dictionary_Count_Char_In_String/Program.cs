using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            //dict. for the results
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            //loop for the input
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            for (int i = 0; i < input.Length; i++)
            {
                //because we cannot compare char to string
                string letter = input[i].ToString();

                //if the current character is space --> continue with the next iteration
                if (letter == " ")
                {
                    continue;
                }
                else
                {
                    //if the letter does not exist in the collectin, add it with value 1
                    if (!dictionary.ContainsKey(letter))
                    {
                        dictionary.Add(letter, 1);
                    }
                    else
                    {
                        //if exist increase only the value of the current element
                        dictionary[letter]++;
                    }
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            //print the result
            foreach (var item in dictionary)
            {
                string letter = item.Key;
                int count = item.Value;
                Console.Write($"{letter} -> {count}");
                Console.WriteLine();
            }
        }
    }
}