// Created by MAYSOON ALI AHMAD ALSHDAIFAT

using System;

namespace YourNamespace
{
    // The Employee class represents an employee with Id, FirstName, and LastName properties.
    public class Employee
    {
        // Unique identifier for the employee
        public int Id { get; set; }

        // Employee's first name
        public string FirstName { get; set; }

        // Employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are the same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, but not both, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Return true if the Ids are equal
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be done in pairs with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the == operator
            return !(emp1 == emp2);
        }

        // Override Equals for correct behavior in collections and comparisons
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and compare Ids
            if (obj is Employee other)
                return this.Id == other.Id;
            return false;
        }

        // Override GetHashCode to match the logic in Equals
        public override int GetHashCode()
        {
            // Use Id's hash code
            return Id.GetHashCode();
        }
    }
}