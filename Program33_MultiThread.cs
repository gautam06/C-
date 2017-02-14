 using System;
 using System.Threading;

    namespace MultithreadingEx
    {
        class Program
        {
            public static void CallToChildThread1()
            {
                Console.WriteLine("Child thread1 starts");
                Random r = new Random();
                int n = 0;
                for (int i = 0; i < 10; i++)
                {
                    n = r.Next(1, 11);
                    Thread.Sleep(2000);
                    Console.WriteLine("Thread1 Random No.: "+n);
                }
            }

            public static void CallToChildThread2()
            {
                Console.WriteLine("Child thread2 starts");
                int n = 0;
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    String c = char.ConvertFromUtf32(r.Next(65, 90));
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread2 Random Character: "+c);
                }
            }

            static void Main(string[] args)
            {
                ThreadStart childref1 = new ThreadStart(CallToChildThread1);
                ThreadStart childref2 = new ThreadStart(CallToChildThread2);
                Console.WriteLine("In Main: Creating the Child thread");
                Thread childThread1 = new Thread(childref1);
                Thread childThread2 = new Thread(childref2);
                childThread1.Start();
                childThread2.Start();
                Console.ReadKey();
            }
        }
    }

    /*Output
        In Main: Creating the Child thread
        Child thread1 starts
        Child thread2 starts
        Thread2 Random Character: X
        Thread1 Random No.: 10
        Thread2 Random Character: Q
        Thread2 Random Character: I
        Thread1 Random No.: 7
        Thread2 Random Character: H
        Thread2 Random Character: Q
        Thread1 Random No.: 4
        Thread2 Random Character: B
        Thread2 Random Character: J
        Thread1 Random No.: 3
        Thread2 Random Character: J
        Thread2 Random Character: S
        Thread1 Random No.: 7
        Thread2 Random Character: A
        Thread1 Random No.: 1
        Thread1 Random No.: 4
        Thread1 Random No.: 4
        Thread1 Random No.: 8
        Thread1 Random No.: 1
    */
