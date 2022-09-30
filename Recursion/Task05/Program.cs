using System;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            Console.WriteLine(PrintDigitsCount(number, count));
        }
        static int PrintDigitsCount(int number, int count)
        {
            if (number < 10)
            {
                count++;
                return count;
            }    
            count++;
            return PrintDigitsCount(number / 10, count);
        }
    }
}
