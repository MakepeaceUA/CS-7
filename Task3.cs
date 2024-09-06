using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task3
    {
        abstract class Figura
        {
            public abstract double CalculateArea();
        }
        class Rectangle : Figura
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double CalculateArea()
            {
                return Width * Height;
            }
            public override int GetHashCode()
            {
                return Width.GetHashCode() ^ Height.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Rectangle r = (Rectangle)obj;
                return base.Equals(obj) && Width == r.Width && Height == r.Height;
            }
            public override string ToString()
            {
                return $"Width: {Width}, Height: {Height}";
            }
        }

        class Circle : Figura
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
            public override int GetHashCode()
            {
                return Radius.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Circle c = (Circle)obj;
                return base.Equals(obj) && Radius == c.Radius;
            }
            public override string ToString()
            {
                return $"Radius: {Radius}";
            }

        }

        class RightTriangle : Figura
        {
            public double Side { get; set; }
            public double Height { get; set; }

            public RightTriangle(double b, double height)
            {
                Side = b;
                Height = height;
            }

            public override double CalculateArea()
            {
                return 0.5 * Side * Height;
            }
            public override int GetHashCode()
            {
                return Side.GetHashCode() ^ Height.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                RightTriangle rt = (RightTriangle)obj;
                return base.Equals(obj) && Side == rt.Side && Height == rt.Height;
            }
            public override string ToString()
            {
                return $"Side: {Side}, Height: {Height}";
            }

        }
        class Trapezoid : Figura
        {
            public double Side1 { get; set; }
            public double Side2 { get; set; }
            public double Height { get; set; }

            public Trapezoid(double side1, double side2, double height)
            {
                Side1 = side1;
                Side2 = side2;
                Height = height;
            }

            public override double CalculateArea()
            {
                return 0.5 * (Side1 + Side2) * Height;
            }
            public override int GetHashCode()
            {
                return Side1.GetHashCode() ^ Side2.GetHashCode() ^ Height.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Trapezoid t = (Trapezoid)obj;
                return base.Equals(obj) && Side1 == t.Side1 && Side2 == t.Side2 && Height == t.Height;
            }
            public override string ToString()
            {
                return $"Firts side: {Side1},Second side {Side2}, Height: {Height}";
            }

        }
    }
}
