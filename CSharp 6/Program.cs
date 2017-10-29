using System;

namespace CSharp_6
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var person = CreatePerson();

            // Null-conditional operator
            var lastName = person?.LastName ?? "unknown";

            // String Interpolation
            Console.WriteLine($"The last name is : {lastName}");

            ShowNameOf();
        }

        private static void ShowNameOf()
        {
            Console.WriteLine($"Called in the class {nameof(Program)}");
        }

        private static Person CreatePerson()
        {
            return null;
        }
    }
}