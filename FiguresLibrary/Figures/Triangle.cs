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

            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }

        public bool isRectangular()
        {
            bool isRec1 = isRectangular(A, B);
            bool isRec2 = isRectangular(B, C);
            bool isRec3 = isRectangular(C, A);

            if(isRec1 || isRec2 || isRec3)
            {
                return true;
            }
            return false;
        }

        bool isRectangular(double a, double b)
        {
            double s = Math.Round((a * b) / 2.0, 2);
            if (getArea() == s)
            {
                return true;
            }
            return false;
        }
    }
}
