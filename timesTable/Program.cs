using System;

namespace timesTable
{
    class Program
    {
        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number} times table:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        static void RunTimesTable()
        {
            bool isnumber;

            do
            {
                Console.WriteLine("Enter a Number between 0 and 255");
                isnumber = byte.TryParse(Console.ReadLine(), out byte number);

                if (isnumber)
                {
                    TimesTable(number);
                }
                else
                {
                    Console.WriteLine("You didn't enter a real number");
                }

            } while (isnumber);

        }

        static void Main(string[] args)
        {
            RunTimesTable();
        }

    }

}

