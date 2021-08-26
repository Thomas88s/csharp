using System;
using System.Collections.Generic;
using Classes;

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company Acme = new Company(
                "Acme",
                new DateTime(2018, 3, 18)
            // new List<Employee>() { }
            );


            // Create three employees
            Employee craig = new Employee(
                "Craig",
                "Miller",
                "Ambassador",
                new DateTime(2018, 3, 14)
            );
            Employee wayne = new Employee(
                "Wayne",
                "Moss",
                "Popcorn Guy",
                new DateTime(2015, 2, 14)
            );
            Employee abby = new Employee(
                "Abby",
                "Roads",
                "Fulltime Happenstace",
                new DateTime(2018, 9, 15)
            );
            // Assign the employees to the company
            Acme.Employees.Add(craig);
            Acme.Employees.Add(wayne);
            Acme.Employees.Add(abby);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (var employee in Acme.Employees)
            {
                Acme.ListEmployees(employee);
            }
        }
    }
}
