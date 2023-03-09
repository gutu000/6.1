using System;
namespace Hej
{
    class program
    {
        static void Main(string[]args)
        {
            int summan = Addera(5, 15, 3);
            Console.WriteLine(summan);
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
    }
}