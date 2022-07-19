using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructors
{
    public class Rectangle
    {
        double _length;
        double _breadth;
        public Rectangle()
        {
            _length = 13.5;
            _breadth = 20.5;
        }
        public Rectangle(double len, double wide)
        {
            _length = len;
            _breadth = wide;
        }
        public double Area()
        {
            return _length * _breadth;
        }
        static void Main(string[] args)
        {
            Rectangle objRectl = new Rectangle();
            Console.WriteLine("Area of rectangle = " + objRectl.Area());
        
            Rectangle objRectl2 = new Rectangle(2.5,6.9);
            Console.WriteLine("Area of rectangle = " + objRectl2.Area());

            Console.ReadKey();
        
        }
    }
}