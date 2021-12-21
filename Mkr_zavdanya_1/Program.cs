using System;

namespace Mkr_zavdanya_1
{
    class Figure
    {
        static void Main(string[] args)
        {
            var po = new Point(1);
            Console.WriteLine(po.ToString());
            var re = new Rectangle(3.2, 9.1);
            Console.WriteLine(re.ToString());
            var tri = new Triangle(55.0, 61.0);
            Console.WriteLine(tri.ToString());
        }
    }
    abstract class FlatGeometricFigure
    {
        public string Type { get; }
        public double Square { get; } = 0.0;
        protected FlatGeometricFigure(string type, double square, double volume)
           => (Type, Square, Volume) = (type, square, volume);

        public override string ToString() => string.Format($"Об'єкт: {Type}, Площа = {Square:0.00}");
    }
    class Point : FlatGeometricFigure
    {
        public Point(double a)
            : base("Точка", a)
        {
        }
    }
    class Rectangle : FlatGeometricFigure
    {
        public Rectangle(double a, double b)
        : base("Прямокутник", a * b)
        {
        }
    }

    class Triangle : FlatGeometricFigure
    {
        public Triangle(double a, double b)
            : base("Трикутник", 0.5 * a * b)
        {
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Квадрат");
                Console.WriteLine("Трикутник");
                Console.WriteLine("Точка") ;
                Console.WriteLine("Часу мало(");
            }
        }
    
}

