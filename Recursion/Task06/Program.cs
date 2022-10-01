using System;

namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int startNumber = 1;
            Console.WriteLine(PrintEvenNumbers(startNumber, number));
            Console.WriteLine(PrintOddNumbers(startNumber, number));
        }
        static int PrintEvenNumbers(int startNumber, int endNumber)
        {
            if (startNumber == endNumber)
            {
                if (startNumber % 2 != 0)
                {
                    return startNumber - 1;
                }
                return startNumber;
            }
            if (startNumber % 2 == 0 && startNumber + 2 <= endNumber)
            {
                Console.Write(startNumber + " ");
            }
            return PrintEvenNumbers(startNumber + 1, endNumber);
        }

        static int PrintOddNumbers(int startNumber, int endNumber)
        {
            if (startNumber == endNumber)
            {
                if (startNumber % 2 == 0)
                {
                    return startNumber - 1;
                }
                return startNumber;
            }
            if (startNumber % 2 != 0 && startNumber + 2 <= endNumber)
            {
                Console.Write(startNumber + " ");
            }
            return PrintOddNumbers(startNumber + 1, endNumber);
        }
    }
}
