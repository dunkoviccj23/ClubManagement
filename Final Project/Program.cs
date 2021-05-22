using System;
using System.Collections.Generic;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            string userInput = null;

            while (userInput != "5")
            {
                Console.WriteLine("Student Club Management");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Edit Student");
                Console.WriteLine("4. List Students");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Select an option:");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.Write("Enter student's first name: ");
                    string FirstName = Console.ReadLine();
                    Console.Write("Enter student's last name: ");
                    string LastName = Console.ReadLine();
                    Console.Write("Enter student's email address: ");
                    string Email = Console.ReadLine();
                    Student newStudent = new Student(FirstName, LastName, Email);
                    studentList.Add(newStudent);
                }
                if (userInput == "2")
                {
                    int i = 1;
                    Console.WriteLine("Enter the student number to delete: ");
                    foreach (Student stu in studentList)
                    {
                        Console.WriteLine($"{i} {stu.FirstName} {stu.LastName} | {stu.Email}");
                        i++;
                    }
                    int indexToRemove = Convert.ToInt32(Console.ReadLine());
                    studentList.RemoveAt(indexToRemove - 1);
                }
                if (userInput == "3")
                {
                    int i = 1;
                    foreach (Student stu in studentList)
                    {
                        Console.WriteLine($"{i} {stu.FirstName} {stu.LastName} | {stu.Email}");
                        i++;
                    }

                    Console.WriteLine("What user do you want to edit? Enter User Number: ");
                    int indexToEdit = Convert.ToInt32(Console.ReadLine());
                    Student studentToEdit = studentList[indexToEdit - 1];
                    Console.WriteLine(
                        $"Editing: {studentToEdit.FirstName} {studentToEdit.LastName} | {studentToEdit.Email}");
                    string studentInfoToEdit = null;
                    while (studentInfoToEdit != "4")
                    {
                        Console.WriteLine("What piece of info do you want to edit? Enter the info number: (Click 4 once to complete to exit to main menu) ");
                        Console.WriteLine("1. First Name");
                        Console.WriteLine("2. Last Name");
                        Console.WriteLine("3. Email");
                        Console.WriteLine("4. Exit");
                        studentInfoToEdit = Console.ReadLine();

                        if (studentInfoToEdit == "1")
                        {
                            Console.WriteLine("Enter the new first name: ");
                            studentToEdit.FirstName = Console.ReadLine();
                        }
                        else if (studentInfoToEdit == "2")
                        {
                            Console.WriteLine("Enter the new last name: ");
                            studentToEdit.LastName = Console.ReadLine();
                        }
                        else if (studentInfoToEdit == "3")
                        {
                            Console.WriteLine("Enter the new email: ");
                            studentToEdit.Email = Console.ReadLine();
                        }
                    }
                }
                if (userInput != "5")
                {
                    Console.WriteLine("Current list of students: ");
                    int j = 1;
                    foreach (Student stu in studentList)
                    {
                        Console.WriteLine($"{j} {stu.FirstName} {stu.LastName} | {stu.Email}");
                        j++;
                    }
                }
            }
        }
    }
}