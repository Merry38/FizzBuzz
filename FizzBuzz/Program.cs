using System;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
    /// <summary>
    /// Solution for the FizzBuzz Kata found at http://codingdojo.org/kata/FizzBuzz/
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point, produces the output for numbers 1 to 100
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // Iterate from 0 because it's more intuitive
            for (int i = 0; i < 100; i++)
                Console.WriteLine(FizzBuzz(i + 1));

            Console.Read();
        }

        /// <summary>
        /// Returns FizzBuzz if the argument is divisible by 15,
        /// Fizz if divisible by 3 or contains a 3, Buzz if divisible by 5
        /// or contains a 5, the number itself in all other cases
        /// </summary>
        /// <param name="aNumber"></param>
        /// <returns></returns>
        public static string FizzBuzz(int aNumber)
        {
            if (aNumber % 15 == 0)
                return "FizzBuzz";
            else if (aNumber % 3 == 0)
                return "Fizz";
            else if (aNumber % 5 == 0)
                return "Buzz";
            else if (Regex.Match(aNumber.ToString(), ".*3.*").Success)
                return "Fizz";
            else if (Regex.Match(aNumber.ToString(), ".*5.*").Success)
                return "Buzz";
            else
                return aNumber.ToString();
        }
    }
}
