using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Dictionary<string, int> results = new Dictionary<string, int>();
            List<string> materials = new List<string>();

            while (true)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (input == "stop")
                {
                    break;
                }

                if (counter % 2 == 0)
                {
#pragma warning disable CS8604 // Possible null reference argument.
                    if (!materials.Contains(input))
                    {
                        materials.Add(input);
                    }
#pragma warning restore CS8604 // Possible null reference argument.
                    counter++;
                }
                else if (counter % 2 != 0)
                {
                    string key = materials.First();
#pragma warning disable CS8604 // Possible null reference argument.
                    int number = int.Parse(input);
#pragma warning restore CS8604 // Possible null reference argument.
                    if (!results.ContainsKey(key))
                    {
                        results.Add(key, number);
                        materials.RemoveAt(0);
                        counter++;
                    }
                    else
                    {
                        results[key] += number;
                        materials.RemoveAt(0);
                        counter++;
                    }
                }
            }

            foreach (var result in results)
            { 
                string material = result.Key;
                int value= result.Value;

                Console.WriteLine($"{material} -> {value}");
            }
        }
    }
}