using System;

namespace Week3
{
    class MyNumber
    {
        private int _number;
        public MyNumber()
        {
            _number = 999;
        }
        public MyNumber(int number)
        // another overload 
        {
            _number = number;
        }
        override public string ToString() => _number.ToString();

    }
    class MainProgram
    {

        static void Main(string[] args)
        {
            var mn1 = new MyNumber();
            var mn2 = new MyNumber(888);
            Console.WriteLine(mn1.ToString() + " " + mn2.ToString());

        }
    }

}