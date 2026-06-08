using System;
namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement to ask the user to enter their salary and if the salary is greater than 50000, display they qualify for the bonus
            double salary;
            Console.WriteLine("Enter your salary: ");
            salary = double.Parse(Console.ReadLine());
            if (salary > 50000)
            {
                Console.WriteLine("You qualify for the bonus!");
            }
            else
            {
                Console.WriteLine("You do not qualify for the bonus.");
            }

            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine(" The number is positive.");
            }
            else
            {
                Console.WriteLine(" The number is negative.");
            }

            //if else if to ask the user to enter marks and display the grade based on the marks entered
            int marks;
            Console.WriteLine("Enter your marks: ");
            marks = int.Parse(Console.ReadLine());

            if (marks >= 90)
            {
                Console.WriteLine("You got an A!");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("You got a B!");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("You got a C!");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("You got a D!");
            }
            else
            {
                Console.WriteLine("You failed terribly!");
            }

        }
    }
}