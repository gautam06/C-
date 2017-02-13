using System;

namespace ConsoleApplication1
{

    // Find Factorial
    
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            FindFactorial(num);

            Console.ReadKey();
        }

        static void FindFactorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact *= num--;
            }
            Console.WriteLine("Factorial of {0} is: {1}",num,fact);            
        }
    }

}