using System;
using System.Collections.Generic;

namespace CharacterCount
{
 //you will write a program to count the number of times each character occurs in a string and then print results to the console.

    public class Counter
    {
        public static void Count(string text)
        {
            //Loop through the string one character at a time.
            //You’ll need to initialize the counts for the characters in some fashion.
                //It’s probably better to do this as you go through the string instead of doing so before you loop through it.(WHY?)

            //Store and/or update the count for a given character using an appropriate data structure - Dictionary.
            //create Dictionary to store: Dictionary<char, int>

            Dictionary<char, int> totalCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (totalCount.ContainsKey(text[i]))
                {
                    char existingLetter = text[i];
                    totalCount[existingLetter]++;
                }
                else
                {
                    totalCount.Add(text[i], 1);
                }
            }

            //Loop through the data structure to print the results(one character and its count per line).
            foreach (KeyValuePair<char, int> pair in totalCount)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);

            }
        }
    }
}
