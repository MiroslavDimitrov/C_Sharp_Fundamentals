using System;

namespace Fundaentals
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int result = 0;
           
            result = numberOfPeople / capacity;
            if (result == 0)
            {
                result += 1;
            }
            else if(numberOfPeople % capacity >= 1)
            {
                result += 1;
            }

            Console.WriteLine(result);

        }
    }
}