using System;

namespace TryCatchFinally_struct
{
    class Program
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

        struct Car
        {
            public static string brend;
            public static string model;
            public static int motor;
            public static int CountOfDoor;

            public Car(int a, int c)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Brend {brend}, model {model}, motor {motor} and count of door is {CountOfDoor}");
            }
            public Car(int data)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Brend {brend}, model {model}, motor {motor} and count of door is {CountOfDoor} and this car made in {data}");

            }
        }
        static void Main(string[] args)
        {
            try
            {
                //Yalla.age = 5;
                //Yalla o = new Yalla();
                //Console.WriteLine(Yalla.age);
                //Yalla o1 = new Yalla(85);
                //Console.WriteLine(Yalla.age);
                //Yalla o2 = new Yalla(85, 99);
                //Console.WriteLine(Yalla.age);
                //Console.WriteLine(Yalla.Gumar());
                Car BMW = new Car(1936);
                

                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(9 / a);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("it's not boringggggggggggggggggg");
                Console.ResetColor();
            }

        }
    }
}
    

