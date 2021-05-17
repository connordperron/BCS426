using System;
using static System.Console;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.question2();
        }


        public static void question1()
        {
            // Write a C# .NET Core Console App that asks the user to enter a character and line number and then displays a triangle of  that size with the given character. 
            //For example, if the user entered * as a character and 3 as line number then you display the following triangle on the console window.
            //   *
            //  * *
            // * * *

            WriteLine("What Character would you like to display?");
            string character = ReadLine();

            WriteLine("How many rows of " + character + " would you like to display?");
            int num = Convert.ToInt32(ReadLine());

            for (int i = 0; i < num; i++)
            {

                for (int j = num - i; j > 1; j--)
                {
                    Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Write(character + " ");
                }
                WriteLine();
            }

        }


        public static void question2()
        {

            // Modify your program above to display a diamond shape rather than a triangle. For example, if the user entered * as a character and 3 as line number then you display the following diamond on the console window.
            //  *
            // * *
            //* * *
            // * *
            //  *


            WriteLine("What Character would you like to display?");
            string character = ReadLine();

            WriteLine("How many characters wide would you like you diamond of " + character + "'s?");
            int num = Convert.ToInt32(ReadLine());

            for (int i = 0; i < num; i++)
            {

                for (int j = num - i; j > 1; j--)
                {
                    Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Write(character + " ");
                }
                WriteLine();
            }

            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = num - i; j > 1; j--)
                {
                    Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Write(" " +character);
                }

                WriteLine();


            }
        }



            public static void question3()
        {
            //Write a C# .NET Core Console App that asks the user to enter a number and then displays a string with the original number followed by the reverse of the number. 
            //For example, if the user entered 123 as an int you program should create a string "123321" and display it on the screen

            WriteLine("Please enter a number: ");
            string num = ReadLine();

            int len = num.Length;
            for (int j = 0; j < len; j++)
            {
                Write(num[j]);
            }
            for (int k = len; k > 0; k--)
            {
                Write(num[k - 1]);
            }
        }

        public static void question4()
        {
            // Write a C# Core Console App that validates a password string entered by the user to conform to the following rules:

            //  Length between 6 and 15 characters.
            //	At least one uppercase letter(A - Z).
            //	At least one lowercase letter(a - z).
            //	At least one digit(0 - 9).
            //	At least one supported special character such as ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .

            WriteLine("Please enter a secure password: ");
            string pass = ReadLine();

            bool isLong = false;
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            if (pass.Length >5 && pass.Length < 16)
            {
                isLong = true;
            }

            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsLetter(pass[i]) && Char.IsUpper(pass[i]))
                {
                    hasUpperCase = true;
                }
            }

            for (int i =0; i < pass.Length; i++)
            {
                if (Char.IsLetter(pass[i]) && Char.IsLower(pass[i]) )
                {
                    hasLowerCase = true;
                }
            }

            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsDigit(pass[i]))
                {
                    hasDigit = true;
                }
            }

            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsSymbol(pass[i]) || Char.IsPunctuation(pass[i]))
                {
                    hasSpecialChar = true;
                }
            }

            if (isLong && hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar)
            {
                WriteLine("Your password is secure. Please do not share it with anyone!");
            }

            else
            {
                WriteLine("Your pasword is NOT secure. Please enter another.");
                Program.question4();
            }
        }
    }
}
