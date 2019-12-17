using FigureArea.Model.Interface;
using System;

namespace FigureArea.Model 
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IAreaCalculable, IValidable
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }
        /// <summary>
        /// Площадь
        /// </summary>
        public double Area => Math.Pow(Radius, 2) * Math.PI;
        /// <summary>
        /// Условие валидности
        /// </summary>
        public bool IsValid => Radius > 0;
        public Circle(double radius)
        {
            Radius = radius;

        }
    }
}
