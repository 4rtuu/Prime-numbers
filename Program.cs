using System;

namespace Primes
{
    class Program
    {
        private static void IteratePrimes(int max)
        {
            Console.WriteLine();

            for (int num = 2; num <= max; num++)
            {
                bool check = true;

                for (int i = 2; i < num/2; i++)
                {
                    if (num % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true && num != 4)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please provide a number:");

                if (!int.TryParse(Console.ReadLine(), out int max))
                {
                    Console.WriteLine("Your input is not a valid number.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();

                    break;
                }

                IteratePrimes(max);
            }
        }
    }
}
