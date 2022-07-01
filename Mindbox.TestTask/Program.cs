using FiguresLibrary.Base;
using FiguresLibrary.Figures;
using System;

namespace Mindbox.TestTask
{
    internal class Program
    {

        static void Main(string[] args)
        {

            try
            {
                IFigure circle = new Circle(2);
                Console.WriteLine($"Площадь окружности с радиусом 2 = {circle.getArea()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IFigure triangle = new Triangle(3, 4, 5);
                Console.WriteLine($"Площадь треугольника со сторонами 3 4 5 = {triangle.getArea()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Triangle triangle = new Triangle(3, 5, 6);

                if(triangle.isRectangular())
                {
                    Console.WriteLine($"Треугольник со сторонами {triangle.A} {triangle.B} {triangle.C} прямоугольный");
                }
                else
                {
                    Console.WriteLine($"Треугольник со сторонами {triangle.A} {triangle.B} {triangle.C} непрямоугольный");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
