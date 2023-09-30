using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Vector
    {
        private double x;
        private double y;
        private double z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void CalculateDirectionCosines(out double cosAlpha, out double cosBeta, out double cosGamma)
        {
            double magnitude = Magnitude();

            cosAlpha = x / magnitude;
            cosBeta = y / magnitude;
            cosGamma = z / magnitude;
        }
        public void PrintVector()
        {
            Console.WriteLine($"Координаты вектора: ({x}, {y}, {z})");
            double magnitude = Magnitude();
            Console.WriteLine($"Модуль вектора: {magnitude:F2}");
            double cosAlpha, cosBeta, cosGamma;
            CalculateDirectionCosines(out cosAlpha, out cosBeta, out cosGamma);
            Console.WriteLine($"Направляющие косинусы: alpha = {cosAlpha:F2}, beta = {cosBeta:F2}, gamma = {cosGamma:F2}");
        }
        public double Magnitude()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            double newX = vector1.x + vector2.x;
            double newY = vector1.y + vector2.y;
            double newZ = vector1.z + vector2.z;
            return new Vector(newX, newY, newZ);
        }
        public static double operator %(Vector vector1, Vector vector2)
        {
            return (vector1.x * vector2.x) + (vector1.y * vector2.y) + (vector1.z * vector2.z);
        }
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            double newX = (vector1.y * vector2.z) - (vector1.z * vector2.y);
            double newY = (vector1.z * vector2.x) - (vector1.x * vector2.z);
            double newZ = (vector1.x * vector2.y) - (vector1.y * vector2.x);
            return new Vector(newX, newY, newZ);
        }
    }

    class Program
    {
        static void Main()
        {
            Vector a = new Vector(1.0, 2.0, 3.0);
            Vector b = new Vector(4.0, 5.0, 6.0);
            Vector c = (a + b) * b; 
            double f = a % c; 
            Console.WriteLine("Результаты операций:");
            Console.WriteLine("c = (a + b) * b");
            c.PrintVector();
            Console.WriteLine($"f = a % c = {f:F2}");
            Console.ReadLine();
        }
    }


}

