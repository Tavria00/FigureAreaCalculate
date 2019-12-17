using FigureArea.Model.Interface;
using System;

namespace FigureArea.Model
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IAreaCalculable, IValidable
    {
        private double HalfPerimeter => (ASide + BSide + CSide) / 2;
        private double Biggest => Math.Max(ASide, Math.Max(BSide, CSide));
        /// <summary>
        /// 1 Сторона треугольника
        /// </summary>
        public double ASide { get; set; }
        /// <summary>
        /// 2 Сторона треугольника
        /// </summary>
        public double BSide { get; set; }
        /// <summary>
        /// 3 Сторона треугольника
        /// </summary>
        public double CSide { get; set; }
        /// <summary>
        /// Площадь
        /// </summary>
        public double Area => Math.Pow(HalfPerimeter * (HalfPerimeter - ASide) * (HalfPerimeter - BSide) * (HalfPerimeter - CSide), 0.5);
        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool isSquare()
        {
            if (ASide == BSide && BSide == CSide)
                return false;
            if (Biggest == ASide)
            {
                return Math.Pow(ASide, 2) == Math.Pow(BSide, 2) + Math.Pow(CSide, 2);
            } 
            else if(Biggest == BSide)
            {
                return Math.Pow(BSide, 2) == Math.Pow(ASide, 2) + Math.Pow(CSide, 2);
            }
            else if (Biggest == CSide)
            {
                return Math.Pow(CSide, 2) == Math.Pow(ASide, 2) + Math.Pow(BSide, 2);
            }
            return false;
        }

        /// <summary>
        /// Условие валидности
        /// </summary>
        public bool IsValid => ASide > 0 && BSide > 0 && CSide > 0;

        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }
    }
}
