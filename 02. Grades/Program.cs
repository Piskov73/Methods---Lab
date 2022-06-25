

using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	2.00 – 2.99 - "Fail"
            //•	3.00 – 3.49 - "Poor"
            //•	3.50 – 4.49 - "Good"
            //•	4.50 – 5.49 - "Very good"
            //•	5.50 – 6.00 - "Excellent"
            double grade=double.Parse(Console.ReadLine());
            Console.WriteLine(Grades(grade));


        }
        static string Grades(double grade)
        {
            string result = "";
            if (grade >= 2.0 && grade < 3.0)
            {
                result = "Fail";
            }
            else if(grade >=3.0&&grade < 3.5)
            {
                result = "Poor";
            }
            else if (grade >= 3.5 && grade < 4.5)
            {
                result = "Good";
            }
            else if (grade >= 4.5 && grade < 5.5)
            {
                result = "Very good";
            }
            else
            {
                result = "Excellent";
            }
            return result;
        }
    }
}
