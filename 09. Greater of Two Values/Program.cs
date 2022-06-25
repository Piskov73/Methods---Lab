using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            //int, char or string
            if (inputType == "int")
            {
                int first=int.Parse(Console.ReadLine());
                int second=int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first,second));
            }
            else if (inputType == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (inputType == "string")
            {
                string first = Console.ReadLine();
                string second =Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }
        //GetMax
        static int GetMax(int firstNumb, int secondNumb)
        {
            if (firstNumb > secondNumb)
            {
                return firstNumb;
            }
            return secondNumb;
        }
        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            return secondChar;

        }

        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString)>=0)
            {
                return firstString;
            }
            return secondString;
        }
    }
}
