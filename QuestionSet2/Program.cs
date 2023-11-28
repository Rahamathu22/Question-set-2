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
            Q26();
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

        public static void Q17()
        {
            int Value = GetInteger("Enter the number of sides between (3 to 10) to find the shape:");
            switch (Value)
            {
                case 3:
                    {
                        Console.WriteLine("Triangle");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Square");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Pentagon");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Hexagon");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Heptagon");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Octagon");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Enneagon");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Decagon");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
            }
        }

        public static void Q18()
        {
            Console.WriteLine("Enter the month to find the number of days:");
            string Month = Console.ReadLine();
            switch (Month.ToLower())
            {
                case "january":
                    {
                        Console.WriteLine("There are 31 days in the month of january");
                        break;
                    }
                case "feburary":
                    {
                        Console.WriteLine("There are 28 days in the month of feurary");
                        break;
                    }
                case "march":
                    {
                        Console.WriteLine("There are 31 days in the month of march");
                        break;
                    }
                case "april":
                    {
                        Console.WriteLine("There are 30 days in the month of april");
                        break;
                    }
                case "may":
                    {
                        Console.WriteLine("There are 31 days in the month of may");
                        break;
                    }
                case "june":
                    {
                        Console.WriteLine("There are 30 days in the month of june");
                        break;
                    }
                case "july":
                    {
                        Console.WriteLine("There are 31 days in the month of july");
                        break;
                    }
                case "august":
                    {
                        Console.WriteLine("There are 31 days in the month of august");
                        break;
                    }
                case "september":
                    {
                        Console.WriteLine("There are 30 days in the month of september");
                        break;
                    }
                case "october":
                    {
                        Console.WriteLine("There are 31 days in the month of august");
                        break;
                    }
                case "november":
                    {
                        Console.WriteLine("There are 30 days in the month of november");
                        break;
                    }
                case "december":
                    {
                        Console.WriteLine("There are 31 days in the month of december");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
            }
        }

        public static void Q19()
        {
            int week = GetInteger("Enter the date to find the day:");
            if (week % 7 == 0)
            {
                Console.WriteLine("Sunday");
            }
            else if (week % 7 == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (week % 7 == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (week % 7 == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (week % 7 == 4)
            {
                Console.WriteLine("Thrusday");
            }
            else if (week % 7 == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (week % 7 == 6)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void Q20()
        {
            Console.WriteLine("Enter the length of size of a triangle to find the name of the triangle:");
            int FirstLength = GetInteger("Enter the length of size1 of a triangle:");
            int SecondLength = GetInteger("Enter the length of size2 of a triangle:");
            int ThirdLength = GetInteger("Enter the length of size3 of a triangle:");
            if (FirstLength == SecondLength && FirstLength == ThirdLength)
            {
                Console.WriteLine("It is an Equilateral triangle");
            }
            else if (FirstLength == SecondLength || SecondLength == ThirdLength || FirstLength == ThirdLength)
            {
                Console.WriteLine("It is an isosceles triangle");
            }
            else
            {
                Console.WriteLine("It is an scalene triangle");
            }
        }

        public static void Q21()
        {
            int Mark = GetInteger("Enter the Mark to view your grade:");
            if (Mark <= 100 && Mark >= 90)
            {
                Console.WriteLine("A");
            }
            else if (Mark < 90 && Mark >= 80)
            {
                Console.WriteLine("B");
            }
            else if (Mark < 80 && Mark >= 60)
            {
                Console.WriteLine("C");
            }
            else if (Mark < 60 && Mark >= 50)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static void Q22()
        {
            int Row = GetInteger("Enter the row number between(1 to 8):");
            int Column = GetInteger("Enter the column number between(1 to 8):");
            int sum=Row+Column;
            if (sum % 2 == 0)
            {
                Console.WriteLine("Black");
            }
            else
            {
                Console.WriteLine("White");
            }
        }

        public static void Q24()
        {
            int Buy = GetInteger("Enter the amount that you buy the product:");
            int Sale = GetInteger("Enter the amount that you sale to the customer:");
            int result = Math.Abs(Buy - Sale);
            if (Sale > Buy)
            {
                Console.WriteLine("Your profit is:" + result);
            }
            else
            {
                Console.WriteLine("Your loss is:"+result);
            }
        }

        public static void Q25()
        {
            int FirstValue = GetInteger("Enter the first number:");
            int SecondValue = GetInteger("Enter the second number:");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Modulo Division");
            int Value = GetInteger("Enter the number to perform the operation:");
            switch (Value)
            {
                case 1:
                    {
                        Console.WriteLine(FirstValue+SecondValue);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(FirstValue-SecondValue);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(FirstValue*SecondValue);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(FirstValue/SecondValue);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(FirstValue%SecondValue);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
            }
        }

        public static void Q26()
        {
            Console.WriteLine("1.Rock");
            Console.WriteLine("2.Paper");
            Console.WriteLine("3.Scissors");
            int value = GetInteger("Enter the number to choose your option:");
            Random r = new Random();
            int random = r.Next(1, 4);
            Console.WriteLine("Computer choice:"+random);
            int ComputerChoise=random;
            if (ComputerChoise == value)
            {
                Console.WriteLine("Match draw");
            }
            else if (ComputerChoise == 1 && value == 3)
            {
                Console.WriteLine("Computer win");
            }
            else if (ComputerChoise == 2 && value == 1)
            {
                Console.WriteLine("Computer win");
            }
            else if (ComputerChoise == 3 && value == 2)
            {
                Console.WriteLine("Computer win");
            }
            else
            {
                Console.WriteLine("You win");
            }

        }

    }
}
