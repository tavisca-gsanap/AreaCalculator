using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Circle : IShapes
    {
        double radius = 0;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
    public class Rectangle : IShapes
    {
        double length = 0;
        double breadth = 0;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea()
        {
            double area = length * breadth;
            return area;
        }
    }
    public class Square : IShapes
    {
        double side = 0;
        public Square(double side)
        {
            this.side = side;
        }
        public double CalculateArea()
        {
            double area = side * side;
            return area;
        }
    }
    public class Triangle : IShapes
    {
        double height = 0;
        double @base = 0;
        public Triangle(double height, double @base)
        {
            this.height = height;
            this.@base = @base;
        }
        public double CalculateArea()
        {
            double area = 0.5 * height * @base;
            return area;
        }
    }
}
