using System.ComponentModel;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace IterationStatements
{
    public class Program
    {
        public static void Count()
        {
            var myCount = new List<int>();
            var num = 1000;
            do
            {
                num--;
                myCount.Add(num);
            } while (num > -1000);
            foreach(var i in myCount)
            {
               Console.WriteLine(i);
            }
                
        }

        public static void Count2()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void CountBy3()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void EqualCheck(int num1, int num2)
        {
            num1 = 5;
            num2 = 6;
            var check = (num1 == num2) ? "equal" : "not equal";
            Console.WriteLine(check);
        }

        public static void EvenIntCheck(int num)
        {
            var check = (num % 2 == 0) ? "even" : "odd";
            Console.WriteLine(check);
        }

        public static void PosNumCheck(int num5)
        {
            var check = (num5 > 0) ? "positive" : "negative";
            Console.WriteLine(check);
        }

        public static void AgeCheck(int num6)
        {
            var check = (num6 >= 18) ? "You can vote" : "You can't vote";
            Console.WriteLine(check);
        }

        public static void IntBetween(int num7)
        {
            var check = (-10 < num7 && num7 < 10) ? "between" : "not between";
            Console.WriteLine(check);
        }

        public static void MultTable(int num8)
        {

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num8} x {i} = {num8 * i}");
            }

        }
        

        
        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through - 1000
            Count();
            Count2();

            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            CountBy3();

            //Write a method to accept two integers as parameterss and check whether they are equal or not
            Console.WriteLine("Type a number");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type another number");
            var num2 = int.Parse(Console.ReadLine());
            EqualCheck(num1, num2);

            //Write a method to check whether a given number is even or odd
            Console.WriteLine("Type a number");
            var num = int.Parse(Console.ReadLine());
            EvenIntCheck(num);

            //Write a method to check whether a given number is positive or negative
            Console.WriteLine("Type a number");
            var num5 = int.Parse(Console.ReadLine());
            PosNumCheck(num5);

            //Write a method to read the age of a candidate and determine whether they can vote.
            Console.WriteLine("What is your age?");
            var num6 = int.Parse(Console.ReadLine());
            AgeCheck(num6);

            //Write a method to check if an integer (from the user) is in the range -10 to 10
            Console.WriteLine("Type a number to see if it is between -10 and 10");
            var num7 = int.Parse(Console.ReadLine());
            IntBetween(num7);

            //Write a method to display the multiplication table (from 1 to 12) of a given integer
            Console.WriteLine("Type a number");
            var num8 = int.Parse(Console.ReadLine());
            MultTable(num8);
        }
    }
}
