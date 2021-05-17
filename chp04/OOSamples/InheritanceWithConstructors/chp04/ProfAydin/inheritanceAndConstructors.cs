using System;

namespace LearnCSharp
{
    class A
    {
        private int a;
        public A(int ia)
        {
            a = ia; Console.WriteLine("constructor A is called");

        }
    }


    class B : A
    {
        private int b;
        public B(int ia, int ib) : base(ia)
        {
            b = ib;
            Console.WriteLine("parameter constructor B is called");

        }
        public B() : base(ia: -1)
        {
            b = -2;
            Console.WriteLine("default constructor B is called");
        }
    }

    class Program
    {
        static void Main()
        {
            B b = new B();
        }
    }
}
