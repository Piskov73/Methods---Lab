using System;

namespace _4._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            PrintTriangle(endNumber);

        }
        static void PrintTriangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
            for (int i = end-1; i >= 1; i--)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
