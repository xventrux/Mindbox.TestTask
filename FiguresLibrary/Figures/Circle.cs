using FiguresLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if(radius < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше нуля");
            }
            Radius = radius;
        }

        public double getArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
