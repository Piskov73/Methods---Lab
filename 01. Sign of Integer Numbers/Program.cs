
using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            SignNumber(numb);

        }
        static void SignNumber(int number)
        {
            if (number > 0)
            {
                //"The number {number} is positive. "
                Console.WriteLine($"The number { number} is positive.");
            }
            else if (number < 0)
            {
                //"The number {number} is negative. "
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                //"The number {number} is zero. "
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
