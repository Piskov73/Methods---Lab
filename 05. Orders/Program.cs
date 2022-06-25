using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  coffee – 1.50
            //•	water – 1.00
            //•	coke – 1.40
            //•	snacks – 2.00
            string product=Console.ReadLine();
            int numberOfProducts=int.Parse(Console.ReadLine());
            Console.WriteLine($"{Orders(product,numberOfProducts):f2}");

        }
        static double Orders(string product,int numberOfProducts)
        {
            double priceSum=0;
            switch (product)
            {
                case "coffee":
                    priceSum = 1.50 * numberOfProducts;
                    break;
                case "water":
                    priceSum = 1.00 * numberOfProducts;
                    break;
                case "coke":
                    priceSum = 1.40 * numberOfProducts;
                    break;
                case "snacks":
                    priceSum = 2.00 * numberOfProducts;
                    break;

              
            }
            return priceSum;
        }
    }
}
