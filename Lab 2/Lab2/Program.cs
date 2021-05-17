using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;


namespace Lab2
{
    // Main Method for Lab 2 Q1 + Q2

    //Question 1: write a Main method to test your class Document. 
    //a)	Create document1 with name “PhoneNumbers.txt” and 3 pages
    //b)	Create document2 with name “Report.docx” and 30 pages
    //c)	Demo how you cannot change the CreatedOn property of each document object


    //Question 2: write a Main method to test your class Employee. 
    //a)	Create four Employee objects with references e1, e2, and e3 by providing first and last name of each employee
    //b)	Display the full name and id of each employee - note that each employee will have an automatically generated ID by the class Employee.



    class Program
    {
        static void Main(string[] args)
        {
            // Question1
            Document document1 = new Document(name: "PhoneNumbers.txt", numberOfPages:3, createdOn:DateTime.Today);
            Document document2 = new Document(name: "Report.docx", numberOfPages: 30, createdOn: DateTime.Now);

            WriteLine(document1);
            WriteLine(document2);

            document1.Name = "PhoneNumbers2.txt";
            document2.NumberOfPages = 32;

            WriteLine(document1);
            WriteLine(document2);

            // The following line is used to show that the CreatedOn variable is "Read Only" and thus cannot be changed after the object is constructed. It is commented out due to it causing errors.
            //document1.CreatedOn = DateTime.Now;



            // Question2
            Employee e1 = new Employee(firstName: "Connor", lastName: "Perron");
            Employee e2 = new Employee(firstName: "Ilknur", lastName: "Aydin");
            Employee e3 = new Employee(firstName: "John", lastName: "Smith");

            WriteLine("1st \t" +e1);
            WriteLine("2nd \t" +e2);
            WriteLine("3rd \t" +e3);

            
        }
    }
}


