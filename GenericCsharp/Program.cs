using System;

namespace GenericCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Max<double>(3.0, 5.0));
            Console.WriteLine(Max<int>(3, 5));
            Console.WriteLine(Max<decimal>(3.0m, (decimal)5.5));

        }
        static double Max1(double x, double y)
            {
            if (x < y) { return y; } else { return x; }
            }
            //Generic
            static T Max<T>(T x, T y) where T : IComparable<T>
            {
            if (x.CompareTo(y) < 0) return y;
            else return x;
            }


    }
}
