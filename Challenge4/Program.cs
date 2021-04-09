using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               The following iterative sequence is defined for the set of positive integers:

               n → n/2 (n is even)
               n → 3n + 1 (n is odd)

               Using the rule above and starting with 13, we generate the following sequence:
               13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

               It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it
               has not been proven yet (Collatz Problem), it is thought that all starting numbers finish at 1.

               Which starting number, under one thousand, produces the longest chain?

               NOTE: Once the chain starts the terms are allowed to go above one thousand.
             */


            int num = 1; //Number variable
            int count = 1; //Count the amount of numbers in a chain
            bool finished = false; //Loop condition

            List<int> startNums = new List<int>();
            List<int> counts = new List<int>();

            while (!finished) //Loop to get starting numbers
            {
                if (num < 1000) //If num is less than 1000
                {
                    startNums.Add(num); //Add all numbers from 1-999 to a list
                    num++; //Increment num
                }
                else //Once num reaches 1000
                {
                    finished = true; //Break the loop
                }
            }

            foreach (int item in startNums) //Counts the length of each 
            {
                num = item; //Put item into a variable so it can be modified
                count = 1; //Reset the count between numbers
                while (num != 1) //Loop until item == 1
                {
                    if (num % 2 == 0) //If the number is even
                    {
                        num /= 2; //Divide by 2
                    }
                    else //If the number is odd
                    {
                        num *= 3; //Multiply by 3 then add 1
                        num += 1;
                    }
                    count++; //Increment the counter by 1
                }
                counts.Add(count); //Adds the sequence length
            }
            int max = counts.IndexOf(counts.Max()); //Finds the index of the max sequence length
            Console.WriteLine(max + 1); //Prints to console and adds one to fix the 0 based index
        }
    }
}