using System;

namespace ConsoleApplication1
{
	// Polymorphism

    public abstract class Bank
    {
        public abstract int GetRateOfInterest();
    }

    public class SBI : Bank
    {
        public override int GetRateOfInterest()
        {
            return 8;
        }
    }

    public class ICICI : Bank
    {  
	    public override int GetRateOfInterest(){ return 7; }
    }

    public class AXIS : Bank
    {  
	    public override int GetRateOfInterest(){ return 9; }
    }

    public class PolymorphismDemo
    {
        public static void Main(String[] args)
        {
            Bank b1 = new SBI();
            Bank b2 = new ICICI();
            Bank b3 = new AXIS();

            Console.WriteLine("SBI Rate of Interest: " + b1.GetRateOfInterest());
            Console.WriteLine("ICICI Rate of Interest: " + b2.GetRateOfInterest());
            Console.WriteLine("AXIS Rate of Interest: " + b3.GetRateOfInterest());
            Console.ReadKey();
        }
    }

    /*Output
        SBI Rate of Interest: 8
        ICICI Rate of Interest: 7
        AXIS Rate of Interest: 9
    */
}