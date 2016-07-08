using System;
namespace RectangleApplication
{
    class Rectangle
    {
        // member variables
        private double length;
        private double width;

        public Rectangle()
        {
            length = 4.5;
            width = 3.5;
        }

        public double Length 
        { 
            get 
            {
                return length;
            } 
            set
            {
                length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Display();
            Console.ReadLine();
            r.Length = 9;
            r.Width = 7;
            r.Display();
            Console.ReadLine();
        }
    }
}