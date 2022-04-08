using System;

namespace Csharppractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ConvertToSeconds(5);
            //Console.WriteLine("To find area of a triangle:");

            //Console.Write("Enter side:");
            //float side = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Enter height:");
            //float height = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine($"Area of a triangle with side {side} units and height {height} units is {AreaOfTriangle(side, height)}");
            //Issumlessthanhundred(10, 90);
            //Issumlessthanhundred(99, 0);
            //Issumlessthanhundred(100, 1);

            //Issumlessthanhundred(n1,n2);


            //NameShuffle("Rajeev Sharma");
            //NameShuffle("O Donald Trump");


            Collatz(10);
            Collatz(100);

        }


        static void ConvertToSeconds(int minutes)
        {
            Console.WriteLine($"{minutes} minutes equals { minutes * 60} seconds");
        }
       static double AreaOfTriangle(float side, float height)
        {
            return (double)(side * height / 2);
        }

        static void IsSumLessThanHundred(int number1,int number2)
        {
            if (number1 + number2 < 100)
                Console.WriteLine($"{number1} + {number2} is Less Than 100");
            else
                Console.WriteLine($"{number1} + {number2} is Not Less Than 100");
        }

        static void NameShuffle(string fullName)
        {
            string[] nameArray = fullName.Split(' ');
            Console.WriteLine($"\"{fullName}\" --> { nameArray[1]} {nameArray[0]}");

            int spacePosition = fullName.IndexOf(' ');

            Console.WriteLine($"\"{fullName}\" --> { nameArray[1]} {nameArray[0]}");
        }

        static long Factorial(int number)
        {
            //long factorial = 1;
            //for(int i = number; i > 0; i--)
            //{
            //    factorial *= i;
            //}
            //return factorial;

            ////recyrsive way

            if (number > 0)
                return number * Factorial(number - 1);


            else
                return 1;
        }

        static void Collatz(uint number)
        {
            int steps = 0;
            uint n = number;
            while (n > 1)
            {
                string evenOrOddString = " ";
                string StepDescriptionString = " ";

                if (n % 2 == 0)
                {
                    evenOrOddString = "even";
                    StepDescriptionString = $"{n} / 2 = ";
                }
                else
                {
                    evenOrOddString = "odd";
                    StepDescriptionString = $"{n} * 3 + 1 = ";
                }
                uint previousNo = n;
                n = (n % 2 == 0) ? (n / 2) : (n * 3 + 1);
                steps++;

                Console.WriteLine($"{steps}.{ previousNo} is { evenOrOddString} - { StepDescriptionString}{ n} ");
            }
            Console.WriteLine($"Total steps for Collatz({number}) is {steps}");

        }

    }
}
