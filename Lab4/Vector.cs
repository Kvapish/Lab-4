using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /// <summary>
    /// Цей конструктор ініціалізує об'єкт типу Vector з трьома координатами (X, Y, Z).
    /// </summary>
    internal class Vector
    {
        private double _x;
        private double _y;
        private double _z;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Z { get => _z; set => _z = value; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        /// <summary>
        /// Цей метод обчислює напрямні косинуси для вектора та записує їх у вказані параметри cosAlpha, cosBeta, cosGamma.
        /// </summary>
        /// <returns></returns>
        private void CalculateDirectionCosines(out double cosAlpha, out double cosBeta, out double cosGamma)
        {
            double magnitude = Magnitude();
            cosAlpha = X / magnitude;
            cosBeta = Y / magnitude;
            cosGamma = Z / magnitude;
        }
        /// <summary>
        /// Цей метод генерує рядок, що містить інформацію про вектор. 
        /// </summary>
        /// <returns></returns>
        public string PrintVector()
        {
            double magnitude = Magnitude();
            double cosAlpha, cosBeta, cosGamma;
            CalculateDirectionCosines(out cosAlpha, out cosBeta, out cosGamma);
            return $"Координаты вектора:({_x},{_y},{_z}),Модуль вектора: ({magnitude:F2}),Направляющие косинусы: (alpha = {cosAlpha:F2}, beta = {cosBeta:F2}, gamma = {cosGamma:F2})";
        }
        /// <summary>
        /// Цей метод обчислює модуль вектора за його координатами. 
        /// </summary>
        /// <returns></returns>
        private double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        /// <summary>
        /// Цей оператор дозволяє додавати два вектори разом.
        /// </summary>
        /// <returns></returns>
        public static Vector operator +(Vector left, Vector right)
        {
            double newX = left.X + right.X;
            double newY = left.Y + right.Y;
            double newZ = left.Z + right.Z;
            return new Vector(newX, newY, newZ);
        }
        /// <summary>
        /// Цей оператор обчислює скалярний добуток двох векторів.
        /// </summary>
        /// <returns></returns>
        public static double operator %(Vector left, Vector right)
        {
            return (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z);
        }
        /// <summary>
        /// Цей оператор обчислює векторний добуток двох векторів.
        /// </summary>
        /// <returns></returns>
        public static Vector operator *(Vector left, Vector right)
        {
            double newX = (left.Y * right.Z) - (left.Z * right.Y);
            double newY = (left.Z * right.X) - (left.X * right.Z);
            double newZ = (left.X * right.Y) - (left.Y * right.X);
            return new Vector(newX, newY, newZ);
        }
    }
}
