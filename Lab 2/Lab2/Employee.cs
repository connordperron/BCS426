using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{

    //Class for Lab 2

    //Question 2: Create a class Employee
        //  private and static field nextAvailableID(int): create a static constructor to initialize this field to a random number (hint: you can use System.Random class). 
        //You can assume that IDs are numbers between 1-9999. Since nextAvailableID is static, all the Employee objects will share this field.

        //with properties
            //FirstName  (string)
            //LastName (string), 
            //ID (int): make it read only to allow initializing only with a constructor and then no more. 

        //Add a constructor to allow setting properties FirstName and LastName. Hint: ID will be initialized to nextAvailableID (make sure to increment nextAvailableID by one)
        //Add ToString Method to display the full name and ID of the employee

    class Employee
    {

        static Random rand = new Random();
        private static int nextAvailableID = rand.Next(1, 9999);


        string _firstName;
        string _lastName;
        private readonly int _id;


        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _id = nextAvailableID++;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; }


        public override string ToString()
        {
            return "Employee #"+_id + ": " + _firstName + " "+  _lastName;
        }
    }
}
