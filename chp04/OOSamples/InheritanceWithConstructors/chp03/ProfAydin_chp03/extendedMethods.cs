using System;

namespace LearnCSharp
{
    public class Person
    {
        public Person(string firstName="first", string lastName="last")
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; }
        public string LastName { get; }
        
    }

    public static class  ExtendedPerson        
    {
        public static string getFullName(this Person p)
        {
            return p.FirstName + " "+ p.LastName;
    }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            var p = new Person("Katharina", "Nagel");
            Console.WriteLine(p.getFullName());
            //Console.WriteLine(ExtendedPerson.getFullName(p));
        }
    }
}
