using System;

namespace ConsoleApplication4
{ 
    public class MyClass
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        static void OldMethod()
        {
            Console.WriteLine("You called old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("You called new method");
        }
        public static void Main()
        {
            //Below Line will give error
            //OldMethod();
            NewMethod();
            Console.ReadKey();
        }   
    }
}
    /*Output
    You called new method
    =====================================================================*/