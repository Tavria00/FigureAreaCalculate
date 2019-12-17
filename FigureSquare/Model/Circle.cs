using FigureSquare.Model.Enum;
using FigureSquare.Model.Interface;

namespace FigureArea.Model
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Высота круга равна диаметру
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Ширина круга равна диаметру
        /// </summary>
        public double Width { get; set; }
        public FigureType Type { get; set; }

        public Circle(double diameter)
        {
            Height = diameter;
            Width = diameter;
            Type = FigureType.Circle;
        }
    }
}
