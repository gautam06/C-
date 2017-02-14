#define DEBUG
using System;
using System.Diagnostics;

namespace ConsoleApplication4
{ 
    public class Myclass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Test
    {
        static void function1()
        {
            Myclass.Message("In Function 1.");
            function2();
        }
        static void function2()
        {
            Myclass.Message("In Function 2.");
        }

        public static void Main()
        {
            Myclass.Message("In Main function.");
            function1();
            Console.ReadKey();
        }
    }
    /*Output
    In Main function.
    In Function 1.
    In Function 2.
    */
}