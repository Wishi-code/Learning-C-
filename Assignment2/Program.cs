using System;
using System.Data;
namespace Assignment
{
    class program
    {
        static void Main(string[] args)
        {
            //while loop to output a list of 10 numbers from 0-10

            int i = 0;
            while (i <= 10)
            {   
                Console.WriteLine(i);
                i++;
            }
         // use a do while loop to allow the usernto enter a number and print a list of numbers.

         double  number;
            
            
                Console.WriteLine("Enter a number: ");
                number = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine( number);
                number++;
            }
             while (number <= 5);
                
        
        }
    }
}