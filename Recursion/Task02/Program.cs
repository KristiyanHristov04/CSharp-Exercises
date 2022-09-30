using System;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PrintNumbersReversed(number, 1));
        }
        static int PrintNumbersReversed(int currNumber, int minNumber)
        {
            if (currNumber == minNumber)
            {
                return minNumber;
            }
            Console.Write(currNumber + " ");
            return PrintNumbersReversed(currNumber - 1, minNumber);
        }
    }
}
