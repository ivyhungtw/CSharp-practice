using System;

namespace HelloWorld
{
    public class Person
    {
        public Person()
        {
        }

        public string FirstName;
        public string LastName;

        public void Introduction()
        {
            Console.WriteLine($"I'm {FirstName} {LastName}");
        }
    }
}
