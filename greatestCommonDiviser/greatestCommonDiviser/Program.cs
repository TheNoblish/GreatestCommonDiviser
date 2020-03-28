using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatestCommonDiviser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // this program uses euclidean methodology to calculate the greatest common divisor of two integers

            // this section should be pretty familiar at this point, being the standard methods of user input we've used before
            Console.WriteLine("Welcome to the Eucliditron 5000");
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("What would you like to do? (calculate, quit)");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "calculate":
                        {
                            Console.WriteLine("Please write the two integers you'd like to calculate for.");
                            string numb = Console.ReadLine();
                            // turning the input to the divisor is made as a seperate function for ease of testing
                            Console.WriteLine(InputToDivisor(numb));
                            break;
                        }
                    case "quit":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That doesn't look like a valid command");
                            break;
                        }
                }

            }
            

        }
        public static string InputToDivisor(string numb)
        {
            // splitting the input into seperate strings and checking if we have two
            string[] numbs = numb.Split(' ');
            if (numbs.Length == 2)
            {
                // the try catch function will attempt to do what is in try, and then move to catch if it fails to do something. 
                // for example if one of the inputs cant be made to an int it will jump out of try and into catch.
                try
                {
                    int a = Int32.Parse(numbs[0]);
                    int b = Int32.Parse(numbs[1]);
                    // finally this section returns the solution using the finddivisor function
                    return ("The greatest common divisor of " + a + " and " + b + " is " + FindDivisor(a, b) + ".");
                }
                catch
                {
                   return ("Sorry, it doesn't look like you entered two integers.");
                }
            }
            else
            {
                return ("Sorry, it doesn't look like you entered two integers.");
            }
        }
        public static int FindDivisor(int a, int b)
        {
            
            int diviser;
            int left = Math.Abs(a);
            int right = Math.Abs(b);
            // this do while loop covers the euclidean algorithm for finding the greatest common divisor
            // an indepth explanation of the algorithm can be found here: https://www.youtube.com/watch?time_continue=93&v=JUzYl1TYMcU&feature=emb_title
            do
            {
                diviser = remainder(left, right);
                left = right;
                right = diviser;
            } while (diviser != 0);

            return left;
        }
        
        public static int remainder(int a, int b)
        {
            // this function just calculates the remainder of two ints, theres no real reason for it to be a seperate function in this version of the program
            return a % b;
        }
    }
}
