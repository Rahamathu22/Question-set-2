using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Q3();
        }

        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }

        public static double GetDouble(string message)
        {
            Console.WriteLine(message);
            double Number = double.Parse(Console.ReadLine());
            return Number;
        }

        public static void Q1()
        {
            int Number = GetInteger("Enter the number to find the number is positive,negative or 0:");
            if (Number == 0)
            {
                Console.WriteLine("The number is equal to zero");
            }
            else if (Number > 0)
            {
                Console.WriteLine("The number is positive integer");
            }
            else if (Number < 0)
            {
                Console.WriteLine("The number is negative integer");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void Q2()
        {
            int FirstValue = GetInteger("Enter the first value:");
            int SecondValue = GetInteger("Enter the second value:");
            if (FirstValue == SecondValue)
            {
                Console.WriteLine("The first and second values are equal");
            }
            else if (FirstValue != SecondValue)
            {
                Console.WriteLine("The first and second values are not equal");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void Q3()
        {
            double FirstValue = GetDouble("Enter the first value:");
            double SecondValue = GetDouble("Enter the second value:");
            if (FirstValue == SecondValue)
            {
                Console.WriteLine("The first and second values are equal");
            }
            else if (FirstValue != SecondValue)
            {
                Console.WriteLine("The first and second values are not equal");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

    }
}
