using System;

namespace OOP_Introduction_Explained
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input;
                string name;

                Console.Write("Type 1 if you like to talk to others and type 2 if you would rather keep to yourself: ");
                input = Console.ReadLine();
                Person MyPerson = new Person();
                MyPerson.AskQuestion(int.Parse(input));
                Console.WriteLine("You are: " + MyPerson.GetPersonality());

                Console.Write("What is your name: ");
                name = Console.ReadLine();
                Student MyStudent = new Student();
                MyStudent.Name = name;
                Console.WriteLine("Your Name is: " + MyStudent.Name + " and your personality type is: " + MyStudent.GetPersonality());

            }
            catch
            {
                Console.WriteLine("Please enter an integer value.");
            }
        }
    }
}
