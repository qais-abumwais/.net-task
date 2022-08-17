using System;

namespace Employees.Models
{
    public class Employee
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly double salary;

        public Employee(string firstName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public string FirstName => firstName;
        public string LastName => lastName;
        public double Salary => salary;
    }
}