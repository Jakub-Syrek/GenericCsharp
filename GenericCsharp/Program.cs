using System;

namespace GenericCsharp
{
    class Point
    {
        public int X { get; set; } = 1;
        public int Y { get; set; } = 1;
        public int CompareTo(Point other)
        {
            return (X * X + Y * Y).CompareTo(other.X * other.X + other.Y * other.Y);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Max<double>(3.0, 5.0));
            Console.WriteLine(Max<int>(3, 5));
            Console.WriteLine(Max<decimal>(3.0m, (decimal)5.5));
            Console.WriteLine(Max<Point>(new Point(), new Point()));
        }
        static double Max1(double x, double y)
            {
            if (x < y) { return y; } else { return x; }
            }
            //Generic
        static T Max<T>(T x, T y , Comparison<T> funkcjaPorownujaca) //where T : IComparable<T>
            {
            if (funkcjaPorownujaca.Compare(x, y) < 0) return y;           //(x.CompareTo(y) < 0) return y;
            else return x;
            }


    }
}
