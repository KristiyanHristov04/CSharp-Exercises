using System;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string numberToString = Convert.ToString(number);
            string newNumber = string.Empty;
            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                newNumber += numberToString[i];
            }
            int newNumberConvertedToInt = Convert.ToInt32(newNumber);
            Console.WriteLine(PrintIndividualDigits(newNumberConvertedToInt));
        }
        static int PrintIndividualDigits(int number)
        {
            if (number < 10)
            {
                return number;
            }
            Console.Write(number % 10 + " ");
            return PrintIndividualDigits(number / 10);
        }
    }
}
