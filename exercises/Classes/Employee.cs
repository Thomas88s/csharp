using System;
using System.Collections.Generic;
using Classes;

namespace Classes
{

    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Employee(string FirstName, string LastName, string Title, DateTime StartDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.StartDate = StartDate;
        }
    }
}