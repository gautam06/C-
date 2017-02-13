using System;

namespace ConsoleApplication1
{
    // Check String contains word man 

    class Program
    {
        static void Main(String[] args)
        {
            String str = "Superman Vs Batman";

            if (str.Contains("man"))
            {
                Console.WriteLine("String contains word -> man");
            }
            else
            {
                Console.WriteLine("String does not contains word -> man");
            }
            Console.ReadKey();
        }
    }
}

/*Output
        String contains word -> man

    =================================================================================*/