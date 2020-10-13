using System;
using System.Collections.Generic;

namespace CharacterCount
{
    class Program
    {
        //you will write a program to count the number of times each character occurs in a string and then print results to the console.

        //1. Loop through the string one character at a time,
        //2. Store and/or update the count for a given character using an appropriate data structure - Dictionary.
        //3. Loop through the data structure to print the results(one character and its count per line).

        //You’ll need to initialize the counts for the characters in some fashion.
           //It’s probably better to do this as you go through the string instead of doing so before you loop through it.(WHY?)

        static void Main(string[] args)
        {
            string exampleText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Counter.Count(exampleText);

            Console.ReadLine();
        }
    }
}
