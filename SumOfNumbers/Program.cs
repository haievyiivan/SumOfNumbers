using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; // Create variable to contain sum num

            // Loop
            for (int i = 1; i <= 10/*Num of numbers*/; i++)
            {
                Console.WriteLine(i); // Write num to the console

                sum += i; // Add num to sum variable
            }

            Console.WriteLine($"Sum = {sum}"); // Write sum to the console

            // ReadKey
            Console.ReadKey();
        }
    }
}
