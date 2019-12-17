using FigureSquare.Model.Enum;
using FigureSquare.Model.Interface;

namespace FigureArea.Model
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Высота треугольника
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Основание треугольника
        /// </summary>
        public double Width { get; set; }
        public FigureType Type { get; set; }

        public Triangle(double height, double baseWidth)
        {
            Height = height;
            Width = baseWidth;
            Type = FigureType.Triangle;
        }
    }
}
