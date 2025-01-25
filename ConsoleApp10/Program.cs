using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public abstract class Figure
    {
        public abstract double CalculateArea();
    }
    public class Rectangle : Figure
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
    }
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    public class RightTriangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
    public class Trapezoid : Figure
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
            {
            new Rectangle(5, 3),
            new Circle(4),
            new RightTriangle(6, 4),
            new Trapezoid(5, 7, 3)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Area: {figure.CalculateArea()}");
            }
        }
    }
}