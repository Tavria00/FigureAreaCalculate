using FigureArea.Model.Interface;

namespace FigureArea.Model
{
    /// <summary>
    /// Квадрат
    /// </summary>
    public class Square : IAreaCalculable, IValidable
    {
        /// <summary>
        /// Сторона квадрата
        /// </summary>
        public double Side { get; set; }

        public double Area => Side * Side;
        /// <summary>
        /// Условие валидности
        /// </summary>
        public bool IsValid => Side > 0;

        public Square(double side)
        {
            Side = side;
        }
    }
}
