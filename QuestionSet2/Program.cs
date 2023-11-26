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
            Q16();
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
                     if (SecondValue < ThirdValue)
            {
                if (SecondValue > ThirdValue)
                {
                    Console.WriteLine("The third value contains the smallest number");
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

        public static void Q10()
        {
            int FirstValue = GetInteger("Enter the first value:");
            int SecondValue = GetInteger("Enter the second value:");
            int ThirdValue = GetInteger("Enter the third value:");
            int FourthValue = GetInteger("Enter the fourth value:");
            int biggest = FirstValue;
            if (SecondValue > biggest)
            {
                biggest = SecondValue;
            }
            else if (ThirdValue > biggest)
            {
                biggest = ThirdValue;
            }
            else if (FourthValue > biggest)
            {
                biggest = FourthValue;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("The biggest value is:"+biggest);
        }

        public static void Q11()
        {
            int FirstValue = GetInteger("Enter the first value:");
            int SecondValue = GetInteger("Enter the second value:");
            int ThirdValue = GetInteger("Enter the third value:");
            int FirstDiff = Math.Abs(FirstValue - SecondValue);
            int SecDiff = Math.Abs(SecondValue - ThirdValue);
            int ThirdDiff = Math.Abs(FirstValue - ThirdValue);
            if (FirstDiff < SecDiff)
            {
                if (FirstDiff > SecDiff)
                {
                    Console.WriteLine("The second and third value are closer to each other:");
                }
                else if (SecDiff < ThirdDiff)
                {
                    if (SecDiff > ThirdDiff)
                    {
                        Console.WriteLine("The first and third value are closer to each other:");
                    }
                }
                else
                {
                    if (FirstDiff < ThirdDiff)
                    {
                        Console.WriteLine("The first and second value are closer to each other:");
                    }
                }
            }
            

        }

        public static void Q12()
        {
            int FirstValue = GetInteger("Enter the first value:");
            int SecondValue = GetInteger("Enter the second value:");
            int ThirdValue = GetInteger("Enter the third value:");
            int FirstDiff = Math.Abs(FirstValue - SecondValue);
            int SecDiff = Math.Abs(SecondValue - ThirdValue);
            int ThirdDiff = Math.Abs(FirstValue - ThirdValue);
            if (FirstDiff > SecDiff)
            {
                if (FirstDiff < SecDiff)
                {
                    Console.WriteLine("The second and third value are farther to each other:");
                }
                else if (SecDiff > ThirdDiff)
                {
                    if (SecDiff < ThirdDiff)
                    {
                        Console.WriteLine("The first and third value are farther to each other:");
                    }
                }
                else
                {
                    if (FirstDiff > ThirdDiff)
                    {
                        Console.WriteLine("The first and second value are farther to each other:");
                    }
                }
            }
        }

        public static void Q13()
        {
            int FirstValue = GetInteger("Enter the first value:");
            int SecondValue = GetInteger("Enter the second value:");
            int ThirdValue = GetInteger("Enter the third value:");
            int Biggest = Math.Max(FirstValue, SecondValue);
            int Maximum = Math.Max(Biggest, ThirdValue);
            int Smallest = Math.Min(FirstValue, SecondValue);
            int Minimum = Math.Min(Smallest, ThirdValue);
            int Middle = (FirstValue + SecondValue + ThirdValue) - (Maximum + Minimum);
            Console.WriteLine(Minimum);
            Console.WriteLine(Middle);
            Console.WriteLine(Maximum);
        }

        public static void Q14()
        {
            Console.WriteLine("Enter three angles to check the given three angles can make a triangle");
            int FirstAngle = GetInteger("Enter the first Angle:");
            int SecondAngle = GetInteger("Enter the second Angle:");
            int ThirdAngle = GetInteger("Enter the third Angle:");
            int result = FirstAngle + SecondAngle + ThirdAngle;
            if (result == 180)
            {
                Console.WriteLine("The trinangle can be formed using these three angles");
            }
            else
            {
                Console.WriteLine("The trinangle cannot be formed using these three angles");
            }
        }

        public static void Q15()
        {
            int X = GetInteger("Enter the value for x:");
            int Y = GetInteger("Enter the value for y:");
            if (X == 0 && Y == 0)
            {
                Console.WriteLine("It lies on the center");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("It lies on the first quadrant");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("It lies on the second quadrant");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("It lies on the third quadrant");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("It lies on the fourth quadrant");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void Q16()
        {
            Console.WriteLine("Enter any character");
            char Value =char.Parse( Console.ReadLine());
            switch (Value)
            {
                case 'a':
                  {
                      Console.WriteLine("It is a vowel");
                      break;
                  }
                case 'e':
                  {
                      Console.WriteLine("It is a vowel");
                      break;
                  }
                case 'i':
                  {
                      Console.WriteLine("It is a vowel");
                      break;
                  }
                case 'o':
                  {
                      Console.WriteLine("It is a vowel");
                      break;
                  }
                case 'u':
                  {
                      Console.WriteLine("It is a vowel");
                      break;
                  }
                default:
                  {
                      Console.WriteLine("Invalid input");
                      break;
                  }
            }
        }
    }
}
