using System;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(number));

            //Fibonacci Sequence(Bonus)
            for (int i = 1; i <= 10; i++)
            {
                int fibonacci = Fibonacci(i);
                string text = string.Format($"Fibonacci of {i} is {fibonacci}");
                Console.WriteLine(text);
            }
        }
        private static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 2) + Fibonacci(n - 1);
            }
        }
    }
}
