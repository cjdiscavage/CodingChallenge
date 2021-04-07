using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main()
        {
            //If we list all the natural numbers below 10
            //that are multiples of 3 or 5, we get 3, 5,
            //6 and 9.The sum of these multiples is 23.

            //Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.

            int total = 0; //Stores total value
            int count = 3; //Number to be added to total

            while (count < 1000) //Adds all numbers below 1000 that are divisible by 3
            {
                total += count;
                count += 3;
            }
            count = 5; //Starts adding numbers divisible by 5
            while (count < 1000) //Adds all numbers below 1000 that are divisible by 5
            {
                total += count;
                count += 5;
            }
            count = 15; //Starts removing duplicate numbers
            while (count < 1000) //Removes 1 of each number that have been added twice
            {
                total -= count;
                count += 15;
            }
            Console.WriteLine($"All numbers divisible by 3 or 5 that are below 1000 add up to {total}.");
        }//Main()
    }
}