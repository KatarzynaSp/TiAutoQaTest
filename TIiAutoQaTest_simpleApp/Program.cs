using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter coordinate x and y of point A: ");
                double xA = Methods.WriteNumber();
                double yA = Methods.WriteNumber();
                Console.WriteLine("Enter coordinate x and y of point B: ");
                double xB = Methods.WriteNumber();
                double yB = Methods.WriteNumber();
                Console.WriteLine("Enter coordinate x and y of point C: ");
                double xC = Methods.WriteNumber();
                double yC = Methods.WriteNumber();

                Point A = new Point(xA, yA);
                Point B = new Point(xB, yB);
                Point C = new Point(xC, yC);

                double lengt_AB = Methods.length(A, B);
                double lengt_AC = Methods.length(A, C);
                double lengt_BC = Methods.length(B, C);


                Console.WriteLine("Length line AB is " + lengt_AB);
                Console.WriteLine("Length line AC is " + lengt_AC);
                Console.WriteLine("Length line BC is " + lengt_BC);

                Methods.IsEquilateralTriangle(lengt_AB, lengt_AC, lengt_BC);
                Methods.IsIsoscelesTriangle(lengt_AB, lengt_AC, lengt_BC);
                Methods.IsRightTriangle(lengt_AB, lengt_AC, lengt_BC);
                double perimeter = Methods.Perimeter(lengt_AB, lengt_AC, lengt_BC);
                Console.WriteLine("Perimeter of this triangle is " + perimeter);
                Methods.Even(perimeter);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " invalid data format");
            }
            Console.ReadKey();
        }

        public class Point
        {
            public double x;
            public double y;

            public Point()
            {
            }

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public class Methods
        {
            public static double length(Point A, Point B)
            {
                double l = Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2));
                double rounded = Math.Round(l, 2);
                return rounded;
            }
            public static double WriteNumber()
            {
                Console.WriteLine("Enter number: ");
                double input = Convert.ToDouble(Console.ReadLine());
                return input;
            }
            public static void IsEquilateralTriangle(double a, double b, double c)
            {
                if (a == b & a == c & b == c)
                    Console.WriteLine("This triangle is quilateral. ");
                else
                    Console.WriteLine("This triangle is not equilateral. ");
            }
            public static void IsIsoscelesTriangle(double a, double b, double c)
            {
                if (a == b || a == c || b == c)
                    Console.WriteLine("This triangle is isosceles. ");
                else
                    Console.WriteLine("This triangle is not isosceles. ");
            }
            public static void IsRightTriangle(double a, double b, double c)
            {
                double delta = Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2));
                if (delta <= 0.01)
                    Console.WriteLine("This triangle is right. ");
                else
                    Console.WriteLine("This triangle is not right. ");
            }
            public static double Perimeter(double a, double b, double c)
            {
                return a + b + c;
            }
            public static void Even(double perimeter)
            {
                for (int i = 0; i <= perimeter; i = i + 2)
                    Console.WriteLine(i);
            }
        }
    }
}