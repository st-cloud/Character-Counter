﻿using System;
using System.Collections.Generic;

namespace CharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Counter.Count(exampleText);

            Console.ReadLine();
        }
    }
}
