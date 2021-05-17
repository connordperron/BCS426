using System;

namespace Week3
{
    class MainProgram
    {

        static public int TestMethod(int n, int opt1 = 100, int opt2 = 200, int opt3 = 300)
        {
            return (n + opt1 + opt2 + opt3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TestMethod(1));
            Console.WriteLine(TestMethod(1, opt3: 2));
        }
    }
}