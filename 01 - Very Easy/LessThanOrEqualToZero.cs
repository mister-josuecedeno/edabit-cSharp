using System;

namespace Edabit_CSharp
{
    class Program
    {
        public static bool LessThanOrEqualToZero(double a)
        {
            return a <= 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LessThanOrEqualToZero(5));
            Console.WriteLine(LessThanOrEqualToZero(0));
            Console.WriteLine(LessThanOrEqualToZero(-5));
            Console.WriteLine(LessThanOrEqualToZero(1));
            Console.WriteLine(LessThanOrEqualToZero(2));
            Console.WriteLine(LessThanOrEqualToZero(1000));
            Console.WriteLine(LessThanOrEqualToZero(0.5));
        }
    }
}
