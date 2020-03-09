using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buckhaven_5_Shapes_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();

            Console.WriteLine($"What is the length of rectangle 1?");
            rect1.RectLength = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"What is the width of rectangle 1?");
            rect1.RectWidth = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            rect1.CalculateArea();
            rect1.CalculatePerimeter();

            Console.WriteLine($"The area of a rectangle width {rect1.RectWidth} and length {rect1.RectLength} is {rect1.RectArea}.");
            Console.WriteLine($"The perimeter is {rect1.RectPerimeter}.");
            Console.ReadLine();
        }

        public class Rectangle
        {
            private int _rectWidth;
            private int _rectLength;
            private int _rectArea;
            private int _rectPerimeter;

            public int RectWidth
            {
                get { return _rectWidth; }
                set { _rectWidth = value; }
            }
            public int RectLength
            {
                get { return _rectLength; }
                set { _rectLength = value; }
            }

            public int RectArea
            {
                get { return _rectArea; }
            }

            public int RectPerimeter
            {
                get { return _rectPerimeter; }
            }

            public void CalculateArea()
            {
                _rectArea = _rectWidth* _rectLength;
            }
            public void CalculatePerimeter()
            {
                _rectPerimeter = (2 * _rectWidth) + (2 * _rectLength);
            }

        }
    }
}
