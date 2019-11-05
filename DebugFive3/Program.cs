using System;
using static System.Console;


namespace DebugFive3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            int number;
            const int LOW = 0;
            const int HIGH = 99;
            const int NUMINROW = 20;
            for (letter = 'A'; letter <= 'Z'; ++letter)
                for (number = LOW; number <= HIGH; ++number)
                {
                    if (number % NUMINROW == 0)
                        WriteLine();
                    Write("{0}{1} ", letter.ToString(), number.ToString("D2"));
                }
        }
    }
}
