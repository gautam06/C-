using System;

namespace ConsoleApplication1
{


    //Calculate Area of Rectangle

    class Rectangle
    {
        private float length;
        private float width;

        public Rectangle(){}

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        public void calculateArea()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area Of Rectangle: "+(length*width));
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Rectangle r1 = new Rectangle(5.6f,8.4f);
            r1.calculateArea();
            Console.ReadKey();
        }
    }
}
