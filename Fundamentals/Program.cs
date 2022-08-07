namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            int firstNum = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
            int secondNum = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
            int thirdNum = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
            int fourthNum = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            int sum = firstNum + secondNum;
            int devide = sum / thirdNum;
            int multiply = devide * fourthNum;

            Console.WriteLine(multiply);
        }
    }
}