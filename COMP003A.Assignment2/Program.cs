/*
 * Author: Joseph Sandoval
 * Course: COMP-003A
 * Purpose: week 2 assignment
 */
using System.Numerics;

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            string username;
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Middle Name");
            string MiddleName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age in 2023");
            string inputAge = Console.ReadLine();

            
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($" hello, {firstName} {MiddleName} {lastName}. You were born in {yearBorn}.");

            int integer1;
            int integer2;

            Console.WriteLine("Enter an integer for integer1");
            integer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer for integer2");
            integer2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            Console.WriteLine("Enter Radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The area is = {Math.PI * radius * radius}");
            Console.WriteLine($"The circumference is = {2 * Math.PI * radius}");



            

























        }
    }
}
