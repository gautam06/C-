using System;

namespace ConsoleApplication1
{

    // Array Sorting

    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Enter Array Size: ");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] A = InputArrayValues(n);

            performSorting(A);

            DisplayArrayValues(A);

            Console.ReadKey();
        }

        public static int[] InputArrayValues(int n)
        {
            int[] A = new int[n];

            Console.WriteLine("Enter Array Values: ");

            for (int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            return A;
        }

        public static void DisplayArrayValues(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }

        public static void performSorting(int[] A)
        {
            Console.WriteLine("Perform Sorting Operation");
            Console.WriteLine("-----------------------------");

            int temp = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                temp = A[0];
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
        }
    }

}


    /*Output
        Enter Array Size: 5
        Enter Array Values:
        5
        2
        1
        8
        6
        Perform Sorting Operation
        -----------------------------
        1
        2
        5
        6
        8
    ==================================================================================*/