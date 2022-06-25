

using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumb = int.Parse(Console.ReadLine());
            inputNumb=Math.Abs(inputNumb);
            Console.WriteLine(GetMultipleOfEvenAndOdds(inputNumb));
            
        }
        static int GetSumOfEvenDigits(int numb)
        {
            int resulr = 0;
            while (numb>0)
            {
                int a = numb % 10;
                    numb=numb/10;
                if (a % 2 == 0)
                {
                    resulr += a;
                }
            }
            return resulr;
        }
        static int GetSumOfOddDigits(int numb)
        {
            int resulr = 0;
            while (numb > 0)
            {
                int a = numb % 10;
                numb = numb / 10;
                if (a % 2 != 0)
                {
                    resulr += a;
                }
            }
            return resulr;
        }
        static int GetMultipleOfEvenAndOdds(int numb)
        {
            int resulr = GetSumOfEvenDigits(numb)*GetSumOfOddDigits(numb);
            return resulr;
        }

    }

    
    //•	Create a method called GetMultipleOfEvenAndOdds()
    //•	Create a method GetSumOfEvenDigits()
    //•	Create GetSumOfOddDigits()

}
