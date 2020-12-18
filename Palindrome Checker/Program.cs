using System;

namespace Palindrome_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter any word here to see if it is a palindrome:  ");
                string input = Console.ReadLine();
                string reverseInput = "";
                string response = "";

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseInput += input[i].ToString();
                }
                Console.WriteLine("-------------------------\n");
                Console.WriteLine($"That word backwards is spelled {reverseInput}\n");

                if (input == reverseInput)
                {
                    Console.WriteLine("That word is a palindrome.\n");

                }
                else
                {
                    Console.WriteLine("That word is not a palindrome.\n");
                }

                Console.Write("Want to check another word? (Enter Y or N):  \n");
                Console.WriteLine();
                response = Console.ReadLine();
                Console.WriteLine();
                if (response.ToLower() == "y")
                {

                }
                else
                {
                    break;
                }
            }
        }
    }
}