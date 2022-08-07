using System;
namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string input = Console.ReadLine();


#pragma warning restore CS8602 // Dereference of a possibly null reference.
            int sum = 0;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            for (int i = 0; i < input.Length; i++)
            {
                //get the numeric value of every single character
                int num = (int)Char.GetNumericValue(input[i]);
                //sum it
                sum += num;
            }
            
            //print the result
            Console.WriteLine(sum);
        }
    }
}