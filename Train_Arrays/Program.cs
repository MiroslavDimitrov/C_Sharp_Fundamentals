using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //this inout will define the size of the array with the results, also the iterations of the loop with the other input data
            int input = int.Parse(Console.ReadLine());

            //array for the results
            int[] nums = new int[input];
            //sum for the data
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                //numbers to be added in the empty array
                int current = int.Parse(Console.ReadLine());
                //adding the numbers and filling the array
                nums[i] = current;
                //sum every input number
                sum += current;
            }

            //print the array with the results
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
            //also print the sum of it's elements
            Console.WriteLine(sum);
        }
    }
}