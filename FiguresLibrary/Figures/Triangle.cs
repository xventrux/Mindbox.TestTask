using FiguresLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Triangle : IFigure
    {
        #region стороны треугольника
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        #endregion

        public Triangle(double a, double b, double c)
        {
            if(a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными");
            }
            if(!(a + b > c && a + c > b && b + c > a))
            {
                throw new ArgumentException("Треугольника не существует");
            }
            A = a;
            B = b;
            C = c;
        }

        public double getArea()
        {
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
