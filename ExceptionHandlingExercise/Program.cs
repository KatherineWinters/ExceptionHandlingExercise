﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str
            char[] arr = { '2', '3', '5', '6', '7', '9', 'k', 'j', 'w' };

            List<int> numbers = new List<int>();

            string str = "";
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (char character in arr)
            {
                // Now create a try catch
                try
                {
                    str = character.ToString();
                    int num = int .Parse(str);
                    numbers.Add(num);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }   
                    // Inside your try block
                        // set your string variable to each array element in your char[] to .ToString()
                        // Now, using int.Parse, parse your string variable and store in an int variable
                        // Then add each int to your list
                
                // catch your Exception:
                // in the scope of your catch you can use the following, 
                
                    //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                
            

            foreach (var num in numbers)
            {
               Console.WriteLine(num);
            }
        }
    }
}
