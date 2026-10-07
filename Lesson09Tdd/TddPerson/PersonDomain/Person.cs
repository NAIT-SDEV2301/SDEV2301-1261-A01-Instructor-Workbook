using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDomain
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        //public string FullName
        //{
        //    get
        //    {
        //        return $"{LastName}, {FirstName}";
        //    }
        //}
        public string FullName => $"{LastName}, {FirstName}";

        public string? PreferredName { get; }

        public string DisplayName => PreferredName ?? FullName;

        public Person(string firstName, string lastName, string? preferredName = null)
        {
            // if (firstName == "")
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First Name cannot be blank.");
            }
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
            PreferredName = preferredName?.Trim();
        }

    }
}
