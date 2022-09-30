using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PrintNumbers(1, number));
        }
        static int PrintNumbers(int currNumber, int maxNumber)
        {
            if (currNumber == maxNumber)
            {
                return maxNumber;
            }
            Console.Write(currNumber + " ");
            return PrintNumbers(currNumber + 1, maxNumber);
        }
    }
}
