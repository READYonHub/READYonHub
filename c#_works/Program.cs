using System;

namespace kiíírja_a_számok_összegét_és_a_karaktereket_a_tömbből
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "12,3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message = "";

            foreach (var value in values)
            {
                decimal number;
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");
            Console.ReadLine();
        }
    }
}
