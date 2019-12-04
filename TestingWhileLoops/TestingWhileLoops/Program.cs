using System;

namespace TestingWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            while (num > 0)
            {
                Console.WriteLine(num);
                num = num - 1;
            }
        }
    }
}
