using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] results = new int[number];

            for (int i = 0; i < number; i++)
            {
                char character = char.Parse(Console.ReadLine());
                results[i] = character;
            }

            for (int i = 0; i < results.Length; i++)
            {
                sum += results[i];
            }

            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}