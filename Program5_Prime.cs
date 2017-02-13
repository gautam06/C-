using System;

namespace ConsoleApplication1
{
    
    class Program
        {
            static void Main(String[] args)
            {
                int num1, num2;

                Console.WriteLine("Enter First Number: ");

                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number: ");

                num2 = Convert.ToInt32(Console.ReadLine());

                findPrimeNumbers(num1, num2);

                Console.ReadKey();

            }

            static void findPrimeNumbers(int num1, int num2)
            {
                var isPrime = false;

                Console.WriteLine("Prime Numbers Between " + num1 + " To " + num2);

                for (var i = num1; i <= num2; i++)
                {
                    isPrime = true;
                    for (var j = 2; j <= (i/2); j++)
                    {
                        if (i%j != 0) continue;
                        isPrime = false;
                        break;
                    }

                    if (isPrime == true && i != 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }

}

   /* Output

        Enter First Number:
        1
        Enter Second Number:
        15
        Prime Numbers Between 1 To 15
        2
        3
        5
        7
        11
        13

    */