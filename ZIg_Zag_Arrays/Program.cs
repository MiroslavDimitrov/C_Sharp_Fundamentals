using System;
using System.Linq;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //input number for iterations of the first loop
            int input = int.Parse(Console.ReadLine());
            //first loop for the results with capacity equal to the input number
            int[] first = new int[input];
            //second loop with the same purpose as the first one
            int[] second = new int[input];

            //the loop from where we will take our input data
            for (int i = 0; i < input; i++)
            {
                //take it as an array, and split it
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                //if the number is even we added the data this way so the numbers can be added in a zig-zag way
                if (i % 2 == 0)
                {
                    first[i] = numbers[0];
                    second[i] = numbers[1];
                }
                //odd number
                else
                {
                    first[i] = numbers[1];
                    second[i] = numbers[0];
                }
            }

            //print the results
            for (int i = 0; i < first.Length; i++)
            {
                Console.Write(first[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < second.Length; i++)
            {
                Console.Write(second[i] + " ");
            }
        }
    }
}