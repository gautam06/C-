using System;

namespace ConsoleApplication1
{

    // Example Nullable Data Types ? 

    class Program
    {
        static void Main(String[] args)
        {

                int? num1 = null;
                int? num2 = 06;
                double? num3 = new double?();

                bool? boolval = new bool?();

                Console.WriteLine("Nullables Values: {0}, {1}, {2}", num1, num2, num3);
                Console.WriteLine("A Nullable boolean value: {0}", boolval);

            // Use Of The Null Coalescing Operator (??)

                double? num4 = null;
                double? num5 = 3.14157;
                double num6;
                num6 = num4 ?? 5.34; // if num4 is null than num3 = 5.34
                Console.WriteLine(" Value of num6: {0}", num6);
                num6 = num5 ?? 5.34; 
                Console.WriteLine(" Value of num6: {0}", num6);
                Console.ReadKey();
        }
    }

}

/* Output
        Nullables Values: , 6,
        A Nullable boolean value:
        Value of num6: 5.34
        Value of num6: 3.14157
*/