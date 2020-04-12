using System;

namespace myApp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 7;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // Suma
            int c = a + b;
            Console.WriteLine("-> a + b = " + c);

            // Resta
            c = a - b;
            Console.WriteLine("-> a - b = " + c);

            // Multiplicación
            c = a * b;
            Console.WriteLine("-> a * b = " + c);

            // División
            c = a / b;
            Console.WriteLine("-> a / b = " + c);

            // Consistent with our math rules
            int d = a + b * c;
            Console.WriteLine("-> a + b * c " + d);

        }

        static void MaxandMinIntegers()
        {
            int min = int.MinValue;
            int max = int.MaxValue;

            // Show limits for int type
            Console.WriteLine($"The range of integers is {min} to {max}");

            // Demostrate how happens when we have a number that is not in those limits.
            int overflow = max + 3;
            int underflow = min - 3;

            Console.WriteLine($"An example of overflow: {overflow}");
            Console.WriteLine($"An example of overflow: {underflow}");
        }

        static void Main(string[] args)
        {
            WorkingWithIntegers();
            MaxandMinIntegers();
        }
    }
}
