using System;

namespace ConsoleApplication1
{
    class SingleObject
    {

        //create an object of SingleObject (static)
        private static SingleObject instance = new SingleObject();

        //make the constructor private so that this class cannot be instantiated
        private SingleObject() { }

        //public static method provide access to static single instance 
        public static SingleObject getInstance()
        {
            return instance;
        }

        public void displayMessage()
        {
            Console.WriteLine("This method is called using singleton object...");
        }
    }

    class SingletonDemo
    {
        public static void Main(String[] args)
        {

            //SingleObject object = new SingleObject();
            //If you try to create new instance -> Compile Time Error: The constructor SingleObject() is not visible

            //Get the only object available
            SingleObject obj = SingleObject.getInstance();

            //show the message
            obj.displayMessage();

            Console.ReadKey();
        }
    }
    /*Output
        This method is called using singleton object...
    */
}