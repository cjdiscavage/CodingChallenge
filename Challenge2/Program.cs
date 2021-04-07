using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main()
        {
            //Each new term in the Fibonacci sequence is generated
            //by adding the previous two terms.By starting with
            //1 and 2, the first 10 terms will be:

            //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

            int num1 = 1; //Variables used to track the privious last 2 numbers to get the next one in the sequence
            int num2 = 2;

            int total = 0; //Holds the running total durring the program

            bool finished = false; //While loop condition

            while (!finished) //Main loop
            {
                if (num2 % 2 == 0)
                {
                    total += num2; //Adds the current number to the total if it's even
                }
                num2 += num1;
                num1 = num2 - num1;
                if (num2 > 4000000)
                {
                    finished = true; //Breaks the loop if the current number is over 4 million
                }
            }//While(!finished)
            Console.WriteLine(total); //Prints the result to the console
        }//Main()
    }
}