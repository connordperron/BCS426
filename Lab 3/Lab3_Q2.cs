using System;
using static System.Console;
using System.Collections.Generic;

namespace Lab3_Q2
{

    public interface ISellable
    {
        //	Create an interface ISellable with the following
            //	Method sell that takes the count of the products to sell and returns the cost
        public decimal Sell(int count);
    }

    abstract class Product : ISellable
    {

        //Create an abstract class Product  with following 
	        //Properties Price(Decimal), Code(string), Description(string)

        private string _description;
        private decimal _price;
        private string _code;

        public Product (string description, decimal price, string code)
        {
            _description = description;
            _price = price;
            _code = code;
        }

        public string Description { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal Sell(int count)
        {
            return count * _price;
        }


    }

    class Book : Product, ISellable
    {

        private string _author;
        public Book(string description, decimal price, string code, string author) : base(description, price, code)
        {
            this.Description = description;
            this.Price = price;
            this.Code = code;
            _author = author;
        }

        public string Author { get; set; }

        public override string ToString()
        {
            return Description+ " was written by " +_author+ ". It costs " +Price+ " and has a code of "+Code;
        }
    }


    class Software : Product, ISellable
    {
        string _version;
        public Software(string description, decimal price, string code, string version) : base(description, price, code)
        {
            this.Description = description;
            this.Price = price;
            this.Code = code;
            _version = version;
        }

        public string Version { get; set; }

        public override string ToString()
        {
            return Description + " ver. " + _version + ". It costs " + Price + " and has a code of " + Code;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Finally, write a client code(main program) that will utilize the class and interface hierarchy you created.
            

            //Create two Book objects for the following books
            //C# 8.0 in a Nutshell, with price $50.99 and with ISBN 978-1492051138 by Jack Smith
            //C#: Advanced Features and Programming Techniques, with price $2.99 and with ISBN 100-1492051000 by Jill Smith
            //Ask the user how many of each book the user wants to buy and then display a report of how much the total cost is.
            Book b1 = new Book(description: "C# 8.0 in a Nutshell", price: 50.99m, code: "ISBN 978-1492051138", author: "Jack Smith");
            Book b2 = new Book(description: "C#: Advanced Features and Programming Techniques", price: 2.99m, code: "ISBN 100-1492051000", author: "Jill Smith");
            
            WriteLine("How many copies of " + b1.Description + " would you like to purchase?");
            int b1Copies = Convert.ToInt32(ReadLine());

            WriteLine("How many copies of " + b2.Description + " would you like to purchase?");
            int b2Copies = Convert.ToInt32(ReadLine());

            decimal total = b1.Sell(b1Copies) + b2.Sell(b2Copies);
            WriteLine("Your total will be $" + total);

            //Create a Software object for the following Software
            //Microsoft 365 Personal with price $69.99 and version 16.0.10827
            //Ask the user how many of the Microsoft 365  the user wants to buy and then display a report of how much the total cost is
            Software s1 = new Software(description: "Microsoft Office 365 Personnal", price: 69.99m, code: "ISBN 100-1492051000", version: "16.0.10827");


            WriteLine("How many copies of " + s1.Description + " would you like to purchase?");
            int s1Copies = Convert.ToInt32(ReadLine());

            total = s1.Sell(s1Copies);
            WriteLine("Your total will be $" + total);



        }
    }
}
