using System;

namespace ConsoleApp2
{
    interface Printable
    {
        void print();
    }
    interface Showable : Printable
    {  
	    void show();
    }
    class InterfaceDemo : Showable
    {

        public void print(){ Console.WriteLine("Printing Data..."); }
        public void show(){ Console.WriteLine("Showing Data..."); }

        static void Main(String[] args){
            InterfaceDemo obj = new InterfaceDemo();
            obj.print();
            obj.show();
            Console.ReadKey();
        }
    }
    /*Output
        Printing Data...
        Showing Data...
    */
}