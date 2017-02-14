using System;

namespace ConsoleApplication4
{  
	//Anonymous Method

    delegate void NumberChanger(int n);
        class TestDelegate
        {
            static int num = 10;
            public static void AddNum(int p)
            {
                num += p;
                Console.WriteLine("Named Method: {0}", num);
            }

            public static void MultNum(int q)
            {
                num *= q;
                Console.WriteLine("Named Method: {0}", num);
            }

            public static int getNum()
            {
                return num;
            }
            static void Main(string[] args)
            {
                //create delegate instances using anonymous method
                NumberChanger nc = delegate (int x)
                {
                    Console.WriteLine("Anonymous Method: {0}", x);
                };

                //calling the delegate using the anonymous method 
                nc(10);

                //instantiating by named methods 
                nc = new NumberChanger(AddNum);

                //calling named methods 
                nc(5);

                //instantiating by named methods 
                nc = new NumberChanger(MultNum);

                //calling named methods 
                nc(2);
                Console.ReadKey();
            }
        }
}		
    /*Output
        Anonymous Method: 10
        Named Method: 15
        Named Method: 30
    */