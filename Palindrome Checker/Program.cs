using System;

namespace Palindrome_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //initial prompt for a user value input
                Console.Write("Enter any word here to see if it is a palindrome:  ");
                string input = Console.ReadLine();
                string reverseInput = "";
                string response = "";

                /*index starts at input.length - 1, which for the word "Ferrari" means 6. Then while index is greater than or equal to 0 the
                for loop iterates in a negative/reverse direction*/
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    /* reverseInput equals reverseInput concatenated to include the value of the character at the current index position during
                    each cycle of the for loop. The result is the user input value is spelled backward one letter at a time. With the word 
                    "Ferrari", for example, this loop would operate to concatenate "i" + "r" + "r" + "a" + "r" + "e" + "f" */
                    reverseInput += input[i].ToString();
                }
                Console.WriteLine("-------------------------\n");
                Console.WriteLine($"That word backwards is spelled {reverseInput}\n");

                //simple evaluation to check whether the word is spelled the same backwards and forewards
                if (input == reverseInput)
                {
                    Console.WriteLine("That word is a palindrome.\n");
                }
                else
                {
                    Console.WriteLine("That word is not a palindrome.\n");
                }

                /*prompt to check with the user wants to try another word. If user inputs "Y" or "y" to answer affirmatively, the app runs
                again; if user inputs anything other than "Y" or "y" the app closes*/
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