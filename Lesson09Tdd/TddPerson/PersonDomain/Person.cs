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

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
