// Author: Jonathan Spalding
// Assignment: Lab 23
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 3/31/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using static System.Console;

namespace Split_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // State contstants and other variables used.
            const int NUMBERS = 10;
            int input;
            int arrayTotal = 1;
            int count = 0;
            // create an array and assign a number size to it.
            int[] a1 = new int[NUMBERS];
            // writeline that explains the instructions.
            WriteLine("Please enter up to 10 numbers below. Enter 0 to finish early.");
            // do while loop that runs up to 10 times, or until 0 is entered.
            do
            {
                //WriteLine that asks to enter a number.
                WriteLine("Please enter your number here:");
                //sets the input to a variable.
                input = int.Parse(ReadLine());
                // set the index for a1 equal to the number entered by the user.
                a1[count] = input;
                // increment count so that we can move to the next index number in the array.
                count++;
            // while loop that ends if 0 was entered, or if ten numbers were entered.    
            } while (count < NUMBERS && input != 0);
            // call back the method Add Array. Thus showing the writeline with the total.
            AddArray(a1, arrayTotal);
            //keeps the cursor there until the user presses enter.
            ReadKey(true);
        }
        // The AddArray method
        // Purpose: multiplies all of the values together, and WriteLines the product.
        // Parameters: int[] a1, int arrayTotal
        // returns: none
        static void AddArray(int[] a1, int arrayTotal)
        {
            // for loop that runs ten times.
            for (var j = 0; j < a1.Length; j++)
            {
                // if statement that only adds the numbers if they were not 0. 
                //(this helps because a c# array is defaulted to have the values filled with 0 already. WHICH REALLY SCREWS YOU UP WHEN YOU'RE MULTIPLYING. I had to find this out online. Is there somewhere in the book or in your videos that teaches us that an array is filled with all 0's? Because it would have saved me a ton of time if I knew that to start...)
                if (a1[j] !=0 || j == 0)
                {
                    // multiply each number together.
                    arrayTotal = a1[j] * arrayTotal;
                }
            }
            //WriteLine the total for the user to see.
            WriteLine($"The total product of all those numbers you entered is {arrayTotal}.");
        }
    }
}
