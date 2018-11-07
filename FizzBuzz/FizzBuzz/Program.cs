using System;

namespace FizzBuzz
{
    public class FizzBuzzService
    {

        /* Returns Fizz, Buzz, FizzBuzz or the number */
        public string Print(int n)
        {
            string result = "";

            bool fizz = IsDivisibleBy(n, 3);
            bool buzz = IsDivisibleBy(n, 5);


            if (fizz)
                result += "Fizz";

            if (buzz)
                result += "Buzz";

            if (!fizz && !buzz)
                result += n.ToString();

            return (result);
        }

        /* Boolean will return true if a is divisible by b */
        public bool IsDivisibleBy(int a, int b)
        {
            if (a % b == 0)
                return (true);

            return (false);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            /* Print introduction */
            Introduction();

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

        private static void Introduction()
        {
            Console.WriteLine("~= FizzBuzz =~");
            Console.WriteLine("This program prints out numbers from 1 to 100.");
            Console.WriteLine("However, for numbers divisible by 3, print \"Fizz\"");
            Console.WriteLine("For numbers divisible by 5, print \"Buzz\"");
            Console.WriteLine("And for numbers divisible by both 3 and 5, print \"FizzBuzz\"");
            Console.WriteLine("\r\nPress Enter to begin:_");
        }

    }
}
