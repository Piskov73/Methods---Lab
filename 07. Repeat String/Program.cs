
using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            int number=int.Parse(Console.ReadLine());
            Console.WriteLine(ReperatString(input,number));

        }

        static string ReperatString(string input, int numbers)
        {
            string output = String.Empty; ;
            for (int i = 0; i < numbers; i++)
            {
                output += input;
            }
            return output;
        }
    }
}
