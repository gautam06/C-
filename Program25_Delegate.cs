using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    delegate T MyNumber<T>(T n);
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            MyNumber<int> n1 = new MyNumber<int>(AddNum);
            MyNumber<int> n2 = new MyNumber<int>(MultNum);

            n1(06);
            Console.WriteLine("Value of Num: {0}", getNum());
            n2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }

    /*Output
        Value of Num: 16
        Value of Num: 80
    */
}