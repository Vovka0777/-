using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp929100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x1 = 0;
                double x2 = 0;
                //Введение коэфицентов
                Console.Write("Введите коэфицент a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите коэфицент b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите коэфицент c = ");
                double c = double.Parse(Console.ReadLine());
                //Вычисление дискриминанта
                double d = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine($"D = {b}^2 - 4 * {a} * {c}");
                if (d > 0)
                {
                    //Вычисление корней
                    Console.WriteLine("Дискриминант имеет 2 корня");
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine($"x1 = {x1:f1}");
                    Console.WriteLine($"x2 = {x2:f1}");
                }
                else if (d < 0)
                {
                    Console.WriteLine("Корней нет");
                }
                else
                {
                    Console.WriteLine("Дискриминант имеет 1 корень");
                    x1 = -b / 2 * a;
                    Console.WriteLine($"x1 = {x1}");
                }
            }
            //Вывод ошибки, при вводе неправильных данных
            catch
            {
                Console.Write("Произошла ошибка!");
            }
            Console.Read();
        }
    }
}
