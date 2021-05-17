using System;

namespace Lab5
{

    public class ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public ComplexNumber(double r = -1, double i = -1)
        {
            RealPart = r;
            ImaginaryPart = i;
        }
        public override string ToString() => $"{RealPart} + {ImaginaryPart}i";

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) =>
                new ComplexNumber(a.RealPart + b.RealPart, a.ImaginaryPart + b.ImaginaryPart);

        public static bool operator ==(ComplexNumber left, ComplexNumber right) { 
                return (left.RealPart.Equals (right.RealPart) && left.ImaginaryPart.Equals (right.ImaginaryPart));
            }


        public static bool operator !=(ComplexNumber left, ComplexNumber right)
        {
            return (!(left.RealPart.Equals(right.RealPart)) && !(left.ImaginaryPart.Equals(right.ImaginaryPart)));
        }


    }

    class Program
    {
        static void Main()
        {
            var complexNumber1 = new ComplexNumber(10, 20);
            var complexNumber2 = new ComplexNumber(100, 200);
            ComplexNumber result;

            Console.WriteLine("First complex number is " + complexNumber1);
            Console.WriteLine("Second complex number is " + complexNumber2);

            result = complexNumber1 + complexNumber2;
            Console.WriteLine("Adding the two complex numbers we get " + result);

            if (complexNumber1 == complexNumber2)
            {
                Console.WriteLine("The two numbers are the SAME");
            }
            else
            {
                Console.WriteLine("The two numbers are NOT the SAME");
            }
        }
    }
}

