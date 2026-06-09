using System;
namespace Level2
{
    class Person
    {
        //encapsulation
        public string Name
        {get; set;}



    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "John";
            Console.WriteLine(person1.Name);
        }
    }}
