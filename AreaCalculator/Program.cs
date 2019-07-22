using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            while (true)
            {
                Console.WriteLine("Select the type!");
                Console.WriteLine("1.Circle 2.Rectangle 3.Square 4.Triangle");
                string input = Console.ReadLine();
                //Area area = new Area();
                double ans;
                try
                {
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Please enter radius");
                            //ans = area.AreaOfCircle(double.Parse(Console.ReadLine()));
                            ans = new Circle(double.Parse(Console.ReadLine())).CalculateArea();
                            Console.WriteLine("Area is " + ans);
                            break;
                        case "2":
                            Console.WriteLine("Please enter length and breadth");
                            //ans = area.AreaOfRectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            ans = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())).CalculateArea();
                            Console.WriteLine("Area is " + ans);
                            break;
                        case "3":
                            Console.WriteLine("Please enter side");
                            //ans = area.AreaOfSquare(double.Parse(Console.ReadLine()));
                            ans = new Square(double.Parse(Console.ReadLine())).CalculateArea();
                            Console.WriteLine("Area is " + ans);
                            break;
                        case "4":
                            Console.WriteLine("Please enter height and base");
                            //ans = area.AreaOfTriangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            ans = new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())).CalculateArea();
                            Console.WriteLine("Area is " + ans);
                            break;
                        default:
                            Console.WriteLine("Please enter valid input");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter valid numbers.");
                }
            }
            */
        }
    }
}
