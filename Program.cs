using System;
using StudentDatabaseApp.Models;  // Reference to the Models namespace where Student class is located

namespace StudentDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())  // Create an instance of the database context
            {
                // Create a new student object
                var student = new Student
                {
                    FirstName = "John",   // Assign first name
                    LastName = "Doe",     // Assign last name
                    EnrollmentDate = DateTime.Now  // Assign current date as enrollment date
                };

                // Add the student to the database
                context.Students.Add(student);

                // Save the changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");  // Confirmation message
            }
        }
    }
}
