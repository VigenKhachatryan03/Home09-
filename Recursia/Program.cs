using System;

namespace Recursia
{
    class Program
    {
        #region yalla
        //     5 (= 4( = 3(= 2(= 1 + 2) + 3) + 4 ) + 5)
        //0,1,1,2,3,5,8,13
        static int gago(int n)
        {
            if (n == 1)
            {
                return n;
            }
            return gago(n - 1) + n;
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {

                return n;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(gago(20));
            Console.WriteLine(Fibonachi(20));

            //for (int n = 10; n > 0; n--)
            //{
            //}
        }
        #endregion
    }
}
