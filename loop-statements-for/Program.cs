﻿using System;

namespace loop_statements_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            for(int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
            for(int i = text.Length-1; i>= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
            int numberOfDigits = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(char.IsDigit(text[i]))
                {
                    numberOfDigits++;
                }
            }
            Console.WriteLine($"Textul introdus are {numberOfDigits} cifre");
        }
    }
}
