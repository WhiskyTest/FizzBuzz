using System;

namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public string Print(int n)
        {
            if ((n % 3 == 0) && (n % 5 == 0))
                return "FizzBuzz";
            else if (n % 3 == 0)
                return "Fizz";
            else if (n % 5 == 0)
                return "Buzz";
            else
                return n.ToString();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            /* Print introduction */
            Console.WriteLine("~= FizzBuzz =~");
            Console.WriteLine("This program prints out numbers from 1 to 100.");
            Console.WriteLine("However, for numbers divisible by 3, print \"Fizz\"");
            Console.WriteLine("For numbers divisible by 5, print \"Buzz\"");
            Console.WriteLine("And for numbers divisible by both 3 and 5, print \"FizzBuzz\"");
            Console.WriteLine("\r\nPress Enter to begin:_");

            /* Wait for user to press Enter */
            Console.ReadKey();

            /* Create a new instance of FizzBuzzServer */
            FizzBuzzService _fizzbuzz = new FizzBuzzService();

            /* Begin loop, checking x for it's "divisibility" */
            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine("{0}", _fizzbuzz.Print(x));

            }

            /* Wait for user to press Enter */
            Console.ReadKey();
        }
    }
}
