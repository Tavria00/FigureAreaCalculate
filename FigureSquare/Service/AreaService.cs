using FigureArea.Handler;
using FigureArea.Model;
using FigureSquare.Handler.Interface;
using FigureSquare.Service.Interface;

namespace FigureArea.Service
{
    /// <summary>
    /// Сервис для расчета площади геометрических фигур
    /// </summary>
    public class AreaService : IAreaService
    {
        private IAreaHandler _areaHandler;
        public AreaService(IAreaHandler areaHandler = null)
        {
            _areaHandler = areaHandler ?? new AreaHandler();
        }
        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <param name="diameter">Диаметр круга</param>
        /// <returns>(Value, Error)</returns>
        public (double Value,string Error) CalculateCircleArea(double diameter)
        {
            Circle circle = new Circle(diameter);
            var result = _areaHandler.CalculateArea(circle);
            if (!result.Success)
                return (0,result.Error);

            return (result.Value,null);
            
        }
        /// <summary>
        /// Расчет площади квадрата
        /// </summary>
        /// <param name="height">Сторона квадрата</param>
        /// <returns>(Value, Error)</returns>
        public (double Value, string Error) CalculateSquareArea(double height)
        {
            Square square = new Square(height);
            var result = _areaHandler.CalculateArea(square);
            if (!result.Success)
                return (0, result.Error);

            return (result.Value, null);
        }
        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <param name="height">Высота треугольника</param>
        /// <param name="baseWidth">Ширина основания треугольника</param>
        /// <returns>(Value, Error)</returns>
        public (double Value, string Error) CalculateTriangleArea(double height, double baseWidth)
        {
            Triangle triangle = new Triangle(height, baseWidth);
            var result = _areaHandler.CalculateArea(triangle);
            if (!result.Success)
                return (0, result.Error);

            return (result.Value, null);
        }
    }
}
