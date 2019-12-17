namespace FigureSquare.Service.Interface
{
    interface IAreaService
    {
        public (double Value, string Error) CalculateTriangleArea(double height, double baseWidth);
        public (double Value, string Error) CalculateCircleArea(double diameter);
        public (double Value, string Error) CalculateSquareArea(double diameter);
    }
}
