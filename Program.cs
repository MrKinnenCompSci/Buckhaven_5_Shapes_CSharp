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
            //Rectangle rect1 = new Rectangle();


            //rect1.SetSize();
            //rect1.OutputSize();

            //Circle circle1 = new Circle();

            //circle1.SetRadius();
            //circle1.OutputSize();

            Circle[] myCircles = new Circle[3];

            for (int i = 0;i<3;i++)
            {
                Console.WriteLine($"Circle {i + 1}.");
                myCircles[i] = new Circle();
                myCircles[i].SetRadius();
                myCircles[i].OutputSize();

            }

            myCircles[2].OutputSize();

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
            }
            public int RectLength
            {
                get { return _rectLength; }
            }

            public int RectArea
            {
                get { return _rectArea; }
            }

            public int RectPerimeter
            {
                get { return _rectPerimeter; }
            }

            public void SetSize()
            {
                Console.WriteLine("What is the width of the rectangle?");
                _rectWidth = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of the rectangle?");
                _rectLength = Int32.Parse(Console.ReadLine());
            }

            public void CalculateSize()
            {
                _rectArea = _rectWidth * _rectLength;
                _rectPerimeter = (2 * _rectWidth) + (2 * _rectLength);
            }

            public void OutputSize()
            {
                CalculateSize();
                Console.WriteLine($"The area of a rectangle width {_rectWidth} and length {_rectLength} is {_rectArea}.");
                Console.WriteLine($"The perimeter is {_rectPerimeter}.");
            }

        }

        public class Circle
        {
            private double _circleRadius;
            private double _circleDiameter;
            private double _circleArea;
            private double _circlePerimeter;

            public double CircleRadius
            {
                get { return _circleRadius; }
            }

            public double CircleDiameter
            {
                get { return _circleDiameter; }
            }

            public double CircleArea
            {
                get { return _circleArea; }
            }

            public double CirclePerimeter
            {
                get { return _circlePerimeter; }
            }

            public void SetRadius()
            {
                Console.WriteLine("What is the radius of the circle?");
                _circleRadius = double.Parse(Console.ReadLine());
            }

            public void CalculateSize()
            {
                _circleDiameter = _circleRadius * 2;
                _circleArea = Math.Pow(_circleRadius, 2) * Math.PI;
                _circlePerimeter = _circleDiameter * Math.PI;
            }

            public void OutputSize()
            {
                CalculateSize();
                Console.WriteLine($"The area of a circle with radius {_circleRadius} is {Math.Round(_circleArea, 2)}.");
                Console.WriteLine($"The diameter is {_circleDiameter} and the perimeter is {Math.Round(_circlePerimeter, 2)}.");
            }

        }
    }
}
