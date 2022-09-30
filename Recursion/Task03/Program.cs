using System;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int startingIndex = 1;
            int sum = 0;
            Console.WriteLine(SumNumbers(startingIndex, number, sum));
        }
        static int SumNumbers(int currNumber, int maxNumber, int sum)
        {
            if (currNumber > maxNumber)
            {
                return sum;
            }
            sum += currNumber;
            return SumNumbers(currNumber + 1, maxNumber, sum);
        }
    }
}
