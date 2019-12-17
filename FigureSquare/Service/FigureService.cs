using FigureArea.Model;
using FigureArea.Service.Interface;

namespace FigureArea.Service
{
    /// <summary>
    /// Сервис для работы площади с геометрическими фигурами
    /// </summary>
    public class FigureService : IFigureService
    {
        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>(Value, Error)</returns>
        public (double Value,string Error) CalculateCircleArea(double radius)
        {
            Circle circle = new Circle(radius);

            if (!circle.IsValid)
                return (0, "Радиус круга должен быть больше нуля");

            return (circle.Area,null);
            
        }
        /// <summary>
        /// Расчет площади квадрата
        /// </summary>
        /// <param name="height">Сторона квадрата</param>
        /// <returns>(Value, Error)</returns>
        public (double Value, string Error) CalculateSquareArea(double height)
        {
            Square square = new Square(height);
            if (!square.IsValid)
                return (0, "Сторона квадрата должна быть больше нуля");

            return (square.Area, null);
        }

        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <param name="aSide">1 сторона</param>
        /// <param name="bSide">2 сторона</param>
        /// <param name="cSide">3 сторона</param>
        /// <returns></returns>
        public (double Value, string Error) CalculateTriangleArea(double aSide, double bSide, double cSide)
        {
            Triangle triangle = new Triangle(aSide, bSide, cSide);
            if (!triangle.IsValid)
                return (0, "Стороны треугольника должны быть больше нуля");

            return (triangle.Area, null);
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        /// <param name="aSide"></param>
        /// <param name="bSide"></param>
        /// <param name="cSide"></param>
        /// <returns></returns>
        public (bool Value, string Error) IsTriangleSquareAngle(double aSide, double bSide, double cSide)
        {
            Triangle triangle = new Triangle(aSide, bSide, cSide);
            if (!triangle.IsValid)
                return (false, "Стороны треугольника должны быть больше нуля");

            return (triangle.isSquare(), null);
        }
    }
}
