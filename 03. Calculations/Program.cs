
using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line – a string – "add", "multiply", "subtract", "divide".
            //•	On the second line – a number.
            //•	On the third line – another number.
            string action=Console.ReadLine();
            int firstNumb = int.Parse(Console.ReadLine());
            int secondtNumb = int.Parse(Console.ReadLine());
            if(action== "add")
            {
                Console.WriteLine(Aad(firstNumb,secondtNumb));
            }
            else if(action== "multiply")
            {
                Console.WriteLine(Multiply(firstNumb,secondtNumb));
            }
            else if(action== "subtract")
            {
                Console.WriteLine(Subtract(firstNumb,secondtNumb));
            }
            else if (action== "divide")
            {
                Console.WriteLine(Divide(firstNumb,secondtNumb));
            }
        }
         static int Aad(int firstNumb,int secondNumb)
        {
            int result = firstNumb + secondNumb;
            return result;
        }
        static int Multiply(int firstNumb, int secondNumb)
        {
            int result=firstNumb * secondNumb;
            return result;
        }
        static int Subtract(int firstNumb, int secondNumb)
        {
            int result = firstNumb - secondNumb;
            return result;
        }
        static int Divide(int firstNumb, int secondNumb)
        {
            int result = firstNumb / secondNumb;
            return result;
        }

    }
}
