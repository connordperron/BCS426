
using Lab3_Q1.Roman;
using System;
using System.Collections;

namespace Lab3_Q1
{
    namespace Roman
    {
        public static class RomanConversion
        {
            public static String toRoman(this int input)
            {
                string numeral = "";

                if (input < 0)
                    return "That is not a valid number";

                else if (input < 1)
                    return "There is no Roman Numberal for 0";

                while (input != 0)
                {

                    if (input >= 1000)
                    {
                       numeral+= "M"; input -= 1000;
                    }

                    else if (input >= 900)
                    {
                        numeral += "CM"; input -= 900;
                    }

                    else if (input >= 900)
                    {
                        numeral += "CM"; input -= 900;
                    }

                    else if (input >= 500)
                    {
                        numeral += "D"; input -= 500;
                    }

                    else if (input >= 400)
                    {
                        numeral += "CD"; input -= 400;
                    }

                    else if (input >= 100)
                    {
                        numeral += "C"; input -= 100;
                    }

                    else if (input >= 90)
                    {
                        numeral += "XC"; input -= 90;
                    }

                    else if (input >= 50)
                    {
                        numeral += "L"; input -= 50;
                    }

                    else if (input >= 40)
                    {
                        numeral += "XL"; input -= 40;
                    }

                    else if (input >= 10)
                    {
                        numeral += "X"; input -= 10;
                    }

                    else if (input >= 9)
                    {
                        numeral += "IX"; input -= 9;
                    }

                    else if (input >= 5)
                    {
                        numeral += "V"; input -= 5;
                    }

                    else if (input >= 4)
                    {
                        numeral += "IV"; input -= 4;
                    }

                    else if (input >= 1)
                    {
                        numeral += "I"; input--;
                    }
                }
                return numeral;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 99;
            string s = i.toRoman();
            Console.WriteLine(s);

        }

    }
}
