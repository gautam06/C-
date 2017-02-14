using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public class MyArray<T>
    {
        private T[] array;

        public MyArray(int size)
        {
            array  = new T[size + 1];
        }

        public T getItem(int i)
        {
            return array[i];
        }

        public void setItem(int i,T value)
        {
            array[i] = value;
        }
    }

    class TestMyArray
    {
        static void Main(String[] args)
        {
            //Storing int values
            MyArray<int> ma = new MyArray<int>(4);

            for (int i = 0; i < 4; i++)
            {
                ma.setItem(i,i*2);
            }

            Console.Write("\nMyArray Int Values: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(ma.getItem(i)+" ");    
            }

            //Storing char values

            Console.Write("\nMyArray Char Values: ");

            MyArray<char> mac = new MyArray<char>(3);

            mac.setItem(0,'G');
            mac.setItem(1,'B');
            mac.setItem(2,'P');

            for (int i = 0; i < 3; i++)
            {
                Console.Write(mac.getItem(i)+" ");
            }

            Console.ReadKey();
        }
    }

    /*Output
    
        MyArray Int Values: 0 2 4 6
        MyArray Char Values: G B P

    */
}	