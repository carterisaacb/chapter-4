using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            int faren;
            int userEntry;
            Console.WriteLine("Temperature at 8AM");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry > 100)
            {
                Console.WriteLine("IT IS SO HOT");
            }
            else if (userEntry <= 32)
            {
                Console.WriteLine("It is FREEZING");
            }
            Console.WriteLine("Temperature at 12PM");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry > 100)
            {
                Console.WriteLine("IT IS SO HOT");
            }
            else if (userEntry < 32)
            {
                Console.WriteLine("It is FREEZING");
            }
            Console.WriteLine("Temperature at 5PM");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry > 100)
            {
                Console.WriteLine("IT IS SO HOT");
            }
            else if (userEntry < 32)
            {
                Console.WriteLine("It is FREEZING");
            }


        }
    }
}
