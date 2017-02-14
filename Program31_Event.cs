using System;

namespace ConsoleApplication4
{  
		//event example

        //declare delegate
        public delegate string MyDel(string str);

        class EventProgram
        {
            //declare event using event 

            event MyDel MyEvent;

            public EventProgram()
            {
                this.MyEvent += new MyDel(this.WelcomeUser);
            }

            public string WelcomeUser(string username)
            {
                return "Welcome " + username;
            }

            static void Main(string[] args)
            {
                EventProgram obj1 = new EventProgram();
                string result = obj1.MyEvent("Gautam");
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
}		
    /*Output
        Welcome Gautam
    */