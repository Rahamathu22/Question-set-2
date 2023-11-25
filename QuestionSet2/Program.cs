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
            Q9();
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

        public static void Q4()
        {
            int Number = GetInteger("Enter the number to find the number is odd or even:");
            if (Number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else if (Number % 2 != 0)
            {
                Console.WriteLine("The number is odd");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void Q5()
        {
            int Year = GetInteger("Enter the year to find the year is leap year or not:");
            if (Year % 4 == 0)
            {
                Console.WriteLine("The given year is the leapyear");
            }
            else if (Year % 4 != 0)
            {
                Console.WriteLine("The given year is not a leapyear");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void Q6()
        {
            int Age = GetInteger("Enter your age to check if you are eligible for voting:");
            if (Age >= 18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else if (Age < 18)
            {
                Console.WriteLine("You are not eligible for voting");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void Q7()
        {
            int Height = GetInteger("Enter your height in centimeter:");
            if (Height > 0 && Height <= 140)
            {
                Console.WriteLine("Short");
            }
            else if (Height > 140 && Height <= 160)
            {
                Console.WriteLine("Medium");
            }
            else if (Height > 160)
            {
                Console.WriteLine("Tall");
            }
        }

        public static void Q8()
        {
            int FirstValue = GetInteger("Enter the first value:");
            int SecondValue = GetInteger("Enter the second value:");
            int ThirdValue = GetInteger("Enter the third value:");
            if (FirstValue > SecondValue)
            {
                if (FirstValue < SecondValue)
                {
                    Console.WriteLine("The second value contains the largest number");
                }
                else
                {
                    Console.WriteLine("The first value contains the largest number");
                }
            }
            else if (SecondValue > ThirdValue)
            {
                if (SecondValue < ThirdValue)
                {
                    Console.WriteLine("The third value contains the largest number");
                }
                else
                {
                    Console.WriteLine("The second value contains the largest number");
                }
            }
            else
            {
                if (FirstValue > ThirdValue)
                {
                    Console.WriteLine("The first value contains the largest number");
                }
                else 
                {
                    Console.WriteLine("The third value contains the largest number");
                }
            }
        }

        public static void Q9()
        {
            int FirstValue = GetInteger("Enter the first value:");
            int SecondValue = GetInteger("Enter the second value:");
            int ThirdValue = GetInteger("Enter the third value:");
            if (FirstValue < SecondValue)
            {
                if (FirstValue > SecondValue)
                {
                    Console.WriteLine("The second value contains the smallest number");
                }
                else
                {
                    Console.WriteLine("The first value contains the smallest number");
                }
            }
            else if (SecondValue < ThirdValue)
            {
                if (SecondValue > ThirdValue)
                {
                    Console.WriteLine("The third value contains the smallest number");
                }
                else
                {
                    Console.WriteLine("The second value contains the smallest number");
                }
            }
            else
            {
                if (FirstValue < ThirdValue)
                {
                    Console.WriteLine("The first value contains the smallet number");
                }
                else
                {
                    Console.WriteLine("The third value contains the smallest number");
                }
            }
        }
    }
}
