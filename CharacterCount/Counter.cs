using System;
using System.Collections.Generic;

namespace CharacterCount
{
    public class Counter
    {
        public static void Count(string text)
        {
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

            foreach (KeyValuePair<char, int> pair in totalCount)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);

            }
        }
    }
}
