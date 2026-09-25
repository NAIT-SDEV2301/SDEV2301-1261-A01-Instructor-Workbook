using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDomain.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Constructor_ValidName_SetsNames()
        {
            var person = new Person("Ada", "Lovelace");

            Assert.Equal("Ada", person.FirstName);
            Assert.Equal("Lovelace", person.LastName);
        }

        [Fact]
        public void FullName_ValidName_ReturnsLastCommaFirst()
        {
            var person = new Person("Ada", "Lovelace");

            Assert.Equal("Lovelace, Ada", person.FullName);
        }
    }
}
