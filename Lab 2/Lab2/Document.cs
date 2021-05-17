using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    //Class for Lab 2

    //Question 1:	Create a C# class called Document with the following Properties: 
            // Name(string)
            // NumberOfPages(int)
            //	CreatedOn(DateTime) : make this a readonly property.Note that DateTime is a struct in the namespace System
              //    Add a constructor to allow initialization of all the properties setting properties Name and NumberOfPages front
              //	Add ToString Method(hint: override toString method of System.Object class) 


    class Document
    {
        string _name;
        int _numberOfPages;
        private readonly DateTime _createdOn;

        public Document(string name, int numberOfPages, DateTime createdOn)
        {
            _name = name;
            _numberOfPages = numberOfPages;
            _createdOn = createdOn;
        }

        public string Name { get; set; }

        public int NumberOfPages { get; set; }


        public DateTime CreatedOn { get; }


        public override string ToString()
        {
            return _name+" has "+_numberOfPages+" pages and was created on "+_createdOn;
        }

    }

}
