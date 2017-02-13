using System;
using System.Collections;

namespace ConsoleApplication1
{
	 // Stack Demo

        class Program
        {
            static void Main(string[] args)
            {
                Stack st = new Stack();

                st.Push('Y');
                st.Push('A');
                st.Push('S');
                st.Push('H');

                Console.WriteLine("Stack Data: ");
                foreach (char ch in st)
                {
                    Console.Write(ch + " ");
                }

                Console.WriteLine();

                st.Push('M');
                
                Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
                Console.WriteLine("Current stack: ");
                foreach (char ch in st)
                {
                    Console.Write(ch + " ");
                }

                Console.WriteLine();

                Console.WriteLine("Remove Stack Values ");
                st.Pop();
                st.Pop();

                Console.WriteLine("Current stack: ");
                foreach (char ch in st)
                {
                    Console.Write(ch + " ");
                }
                Console.ReadKey();
            }
        }
    /*Output
        Stack Data:
        H S A Y
        The next poppable value in stack: M
        Current stack:
        M H S A Y
        Remove Stack Values
        Current stack:
        S A Y
    */
}