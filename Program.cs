// Created by MAYSOON ALI AHMAD ALSHDAIFAT

using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values to its properties
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Smith"
            };

            // Create the second Employee object and assign values to its properties
            Employee emp2 = new Employee
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Johnson"
            };

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = emp1 == emp2;

            // Display the result of the comparison
            Console.WriteLine($"Are Employee 1 and Employee 2 equal? {areEqual}");

            // Change emp2's Id to match emp1's Id
            emp2.Id = 1;

            // Compare again after changing the Id
            areEqual = emp1 == emp2;
            Console.WriteLine($"Are Employee 1 and Employee 2 equal after changing Id? {areEqual}");

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}