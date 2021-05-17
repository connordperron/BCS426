using System;


class MainProgram
{
    static public void methodA(params int[] data)
    {
        foreach (var x in data)
        {
            Console.WriteLine(x);
        }
    }
    static public void methodB(params object[] data)
    {
        foreach (var x in data)
        {
            Console.WriteLine(x);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("methodA(10)");
        methodA(10);
        Console.WriteLine("methodA(10, 20, 30)");
        methodA(10, 20, 30);

        /////////////////////////////////////
        Console.WriteLine("methodB(\"Mike\")");
        methodB("Mike");
        Console.WriteLine("methodB(\"Mike\", 10, 20, \"Tom\")");
        methodB("Mike", 10, 20, "Tom");
    }
}
