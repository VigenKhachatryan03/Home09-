using System;

namespace TryCatchFinally_stract_constructor
{
    struct Yalla
    {
        public static int age = 25;
        public static int ageBrother = 19;
         static Yalla()
        {
            Console.WriteLine("Yalla");
        }
        public static int Gumar()
        {
            return age + ageBrother;
        }
       
        public Yalla(int x)
        {
            age = x;
        }
        public Yalla(int u, int o)
        {
            age = u;
        }
    }
    class Program
    {
        
        static object Main(string[] args)
        {

        }
    }
}
