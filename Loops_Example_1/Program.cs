/*
  Author: Thomas Overholt
  Date: 1/31/23
  Description: C# Console Application for iterative statement examples
*/


using System;

namespace Loops_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an interger positive number");
            
            Boolean done = false;
            
            while (!done)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("The entry is: " + input);
                    done = true;
                }
                catch
                {
                    Console.WriteLine("Enter an interger positive number");
                }

            }
            int i = 1;
            int even = 100;
            do
            {
                Console.WriteLine(even + " is an even number");
                even = 2 * i;
                i++;
            }
            while (even <= input);

        }
    }
}