using System;

namespace LearnWeekly
{
    struct S
    {
        public int Data { get; set; }
    } 

    class mainProgram
    {
        static void Main(string[] args)
        {

            var s1 = new S();
            s1.Data = 10;
            
            var s2 = new S();
            s2.Data = 20;

            Console.WriteLine(object.Equals(s1, s2)); // return false
            Console.WriteLine(object.ReferenceEquals(s1, s2)); // always return false with value types
            s2.Data = 10;
            Console.WriteLine(object.Equals(s1, s2));  // return true

        }
    }
}
