using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /// <summary>
    /// Задание 8
    /// Класс : Вектор 
    /// Член класса : 3 прямоугольные декартовые координаты 
    /// Методы:Конструктор,методы определения направляющих косинусов вектора,метод вывода характеристик вектора 
    /// Операторы перегрузки:Сложение(+),скалярное(%),и векторное(*) произведения векторов 
    /// Исходные данные:а={ax,ay,az} b={bx,by,bz} 
    /// Результаты:с=(a+b)*b f=ac
    /// </summary>
  
    class Program
    {
        static void Main()
        {
            Vector a = new Vector(1.0, 2.0, 3.0);
            Vector b = new Vector(4.0, 5.0, 6.0);
            Vector c = (a + b) * b; 
            double f = a % c; 
            Console.WriteLine("Результаты операций:");  
            Console.WriteLine($"f = a % c = {f:F2}");
            Console.WriteLine(c.PrintVector());
            Console.ReadLine();
        }
    }
}

