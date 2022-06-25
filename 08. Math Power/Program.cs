using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            The first number – the base
            //•	The second number – the power
            double numBase=double.Parse(Console.ReadLine());

            int numbPower = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(numBase,numbPower));

        }
        static double MathPower(double basse, int power)
        {
            double result = 1.0;
            for (int i = 0; i < power; i++)
            {
                result *= basse;
            }
            return result;
        }
    }
}
