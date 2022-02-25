using System;

namespace Exercises
{
    class Swap
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a="+a+" b="+b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("After swap a=" + a +" b=" + b);
        }
    }
}
