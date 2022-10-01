using System;

namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = IsPrime(number, 2, 10);
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
        static bool IsPrime(int number, int startIndex, int endIndex)
        {
            if (startIndex == endIndex && number % 10 == 0)
            {
                return false;
            }
            else if (startIndex == endIndex && number % 10 != 0)
            {
                return true;
            }
            else if (number % startIndex == 0 && startIndex != number)
            {
                return false;
            }
            return IsPrime(number, startIndex + 1, endIndex);
        }
    }
}
