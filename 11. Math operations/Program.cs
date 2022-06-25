

using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firsrstNumb = double.Parse(Console.ReadLine());

            char operation = char.Parse(Console.ReadLine());

            double secondNumb = double.Parse(Console.ReadLine());
            Console.WriteLine(MathOperation(operation,firsrstNumb,secondNumb));

        }
        static double MathOperation(char operation, double first, double second)
        {
            double result = 0;
            if (operation == '+')
            {
                result = Collection(first, second);
            }
            else if (operation == '-')
            {
                result = Subtraction(first, second);
            }
            else if (operation == '*')
            {
                result = Multiplication(first, second);
            }
            else if (operation == '/')
            {
                result=Division(first, second);
            }
            return result;
        }
        static double Collection(double first, double second)
        {
            double result = first + second;
            return result;
        }
        static double Subtraction(double first, double second)
        {
            return first - second;
        }
        static double Multiplication(double first, double second)
        {
            return first * second;
        }
        static double Division(double first, double second)
        {
            return first / second;
        }
    }
}
