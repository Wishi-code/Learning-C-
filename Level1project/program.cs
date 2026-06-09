using System;
namespace myApplication
{
    class Program
    {   


        // a method to get the students name

        static string GetStudentName()
        {//keep asking until a valid name is entered
             string name = "";
            while (string.IsNullOrWhiteSpace(name))
            {
            Console.WriteLine("Enter the students name:");
            name = Console.ReadLine();
            }
          return name;
        }

        // a method to get the students marks
        static int GetStudentMarks()
        {//keep asking until a valid marks is entered
             int marks = -1;
            while (marks < 0 || marks > 100)
            {
                Console.WriteLine("Enter the students marks:");
                marks = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The students marks are: " + marks);
            return marks;
        }
        //a method to calculate the grade
        static string CalculateGrade(int marks)
        {    
               
            if(marks >= 90)
            {
                return "A";
            }
            else if(marks >= 80)
            {
                return "B";
            }
            else if(marks >= 70)
            {
                return "C";
            }
            else if(marks >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void Main(string[] args)
        {
           string studentName = GetStudentName();
            int studentMarks = GetStudentMarks();
            string grade = CalculateGrade(studentMarks);



            Console.WriteLine($"The student {studentName} has {studentMarks}% and received a grade of {grade}.");
        }
    }
}   