using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Fibonacci sequence is defined by the recurrence relation:

            //Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.  F12 is the first term to contain three digits.

            //What is the index of the first term in the Fibonacci sequence to contain 10 digits?

            int num1 = 1; //Variables to hold the current and previous number of the sequence
            int num2 = 2;
            int counter = 3; //The current term of the sequence

            bool finished = false; //Loop condition

            while (!finished) //Iterates through the sequence
            {
                if (num2 < 1000000000) //If the current number is less than 10 digits
                {
                    num2 += num1;
                    num1 = num2 - num1;
                    counter++;
                }
                else
                {
                    finished = true;
                }
            }
            Console.WriteLine(counter);
        }
    }
}