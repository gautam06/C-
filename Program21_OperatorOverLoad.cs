using System;

namespace ConsoleApplication3
{
    class Matrix
    {
        private int[,] M = new int[3,3];
        public void InitMatrix()
        {
            Random r = new Random();
            for(int i=0; i<3; i++)
                for (int j = 0; j < 3; j++)
                {
                    M[i, j] = r.Next(1, 11);
                }
        }

        public void DisplayMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (M[i, j] < 10) Console.Write("0" + M[i, j] + " ");
                    else Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }
                
        }

        public static Matrix operator +(Matrix Ma1, Matrix Ma2) //Operator + Overload
        {
            Matrix Ma3 = new Matrix();
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Ma3.M[i, j] = Ma1.M[i, j] + Ma2.M[i, j];
                }
            }
            return Ma3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix M1 = new Matrix();
            M1.InitMatrix();

            Matrix M2 = new Matrix();
            M2.InitMatrix();

            Console.WriteLine("\nMatrix 1");
            Console.WriteLine("------------------");
            M1.DisplayMatrix();

            Console.WriteLine("\nMatrix 2");
            Console.WriteLine("------------------");
            M2.DisplayMatrix();

            Console.WriteLine("\n Addition Of Matrix By Operator Operload +");
            Console.WriteLine("------------------");
            Matrix M3 = M1 + M2;
            M3.DisplayMatrix();

            Console.ReadKey();
        }
    }

    /*Output
        
        Matrix 1
        ------------------
        04 03 08
        02 09 01
        02 01 04

        Matrix 2
        ------------------
        04 03 08
        02 09 01
        02 01 04

         Addition Of Matrix By Operator Operload +
        ------------------
        08 06 16
        04 18 02
        04 02 08

    =============================================================================*/
}
