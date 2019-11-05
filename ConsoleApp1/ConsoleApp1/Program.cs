using System;

namespace ConsoleApp1
{
    class Program
    {
        static int doubleNum(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The answer is - {0}", doubleNum(2, 4));
        }
    }
}
