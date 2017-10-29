using System;

namespace CSharp_6
{
    public class Person
    {
        public Person(DateTime birthday)
        {
            Birthday = birthday;
        }

        // read only property
        public DateTime Birthday { get; }
        
        // property default value
        public bool IsAdmin { get; set; } = false;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        // expression-bodied function
        public override string ToString() => $"{LastName}, {FirstName}";
    }
}