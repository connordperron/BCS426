using System;

namespace Week3
{
    class classC
    {
        public classC(int newNumber) => cNumber = newNumber;
        public int cNumber { get; set; }
        public override string ToString() => cNumber.ToString();
    }
    class MainProgram
    {

        // parameter a: value type and passed by value
        static public void methodA(int a)
        {
            a = 111;
        }

        // parameter b: value type and passed by reference
        static public void methodB(ref int b)
        {
            b = 222;
        }

        // parameter c: reference type and passed by value
        static public void methodC(classC c)
        {
            c.cNumber = 333;
            c = new classC(111);
        }

        // parameter d: reference type and passed by reference
        static public void methodD(ref classC c)
        {
            c.cNumber = 444;
            c = new classC(111);
        }
        static void Main(string[] args)
        {
            var ma = 999;
            var mb = 999;
            var mc = new classC(999);
            var md = new classC(999);

            Console.WriteLine($"ma before methodA call: {ma}");
            methodA(ma);
            Console.WriteLine($"ma after methodA call: {ma}");

            Console.WriteLine($"mb before methodB call: {mb}");
            methodB(ref mb);
            Console.WriteLine($"mb after methodB call: {mb}");

            Console.WriteLine($"mc before methodc call: {mc}");
            methodC(mc);
            Console.WriteLine($"mc after methodb call: {mc}");

            Console.WriteLine($"md before methodc call: {md}");
            methodD(ref md);
            Console.WriteLine($"md after methodb call: {md}");
        }
    }
}