using System;

namespace InParameterSample
{
    struct AValueType
    {
        public int Data;
    }
    class ARefType
    {
        public int Data { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////
            // passing a value type
            ///////////////////////////////
            AValueType vt = new AValueType { Data = 40 };
            CantChange(vt);
                        
            int it = 40;
            CantChange(it);
            ///////////////////////////////
            // passing a reference type
            ///////////////////////////////
            ARefType rt = new ARefType { Data = 40 };
            CanChange(rt);
            Console.WriteLine(rt.Data);

        }
        static void CanChange(in ARefType a)
        {
            a.Data = 99; 
            //a = new ARefType{Data = 88};  // does not compile - readonly variable
            Console.WriteLine(a.Data);
        }

        static void CantChange(in AValueType a)
        {
            // a.Data = 99;  // does not compile - readonly variable
            Console.WriteLine(a.Data);
        }

        static void CantChange(in int x)
        {
            // x = 99; // does not compile - readonly variable
            Console.WriteLine(x);
        }
    }
}