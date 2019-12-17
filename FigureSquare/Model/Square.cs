using FigureSquare.Model.Enum;
using FigureSquare.Model.Interface;

namespace FigureArea.Model
{
    /// <summary>
    /// Квадрат
    /// </summary>
    public class Square : IFigure
    {
        /// <summary>
        /// Высота и ширина квадрата равны
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Высота и ширина квадрата равны
        /// </summary>
        public double Width { get; set; }
        public FigureType Type { get; set; }

        public Square(double height)
        {
            Height = height;
            Width = height;
            Type = FigureType.Square;
        }
    }
}
