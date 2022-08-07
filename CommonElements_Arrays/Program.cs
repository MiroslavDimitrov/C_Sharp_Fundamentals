using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //first array with elements/list/
            List<string> first = Console.ReadLine().Split(" ").ToList();
            //second array/list/
            List<string> second = Console.ReadLine().Split(" ").ToList();
            //one for the results
            List<string> results = new List<string>();

            //first loop starts from the second list and iterate it
            for (int i = 0; i < second.Count; i++)
            {
                //second iterate and in there there is a logical check for equal elemnte
                for (int j = 0; j < first.Count; j++)
                {
                    //check for equal elements
                    if (second[i].Contains(first[j]))
                    {
                        //add it to the empty/by this moment list with the results
                        results.Add(second[i]);
                    }
                }
            }
           
            //print the list with the results
            for (int i = 0; i < results.Count; i++)
            {
                Console.Write(results[i] + " ");
            }
        }
    }
}