using FigureSquare.Model.Enum;

namespace FigureSquare.Model.Interface
{
    /// <summary>
    /// Интерфеис для геометрических фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Тип геометрической фигуры
        /// </summary>
        public FigureType Type { get; set; }
        /// <summary>
        /// Высота геометрической фигуры
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Ширина геометрической фигуры
        /// </summary>
        public double Width { get; set; }
    }
}
