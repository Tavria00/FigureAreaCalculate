namespace FigureArea.Service.Interface
{
    interface IFigureService
    {
        public (double Value, string Error) CalculateCircleArea(double radius);
        public (double Value, string Error) CalculateTriangleArea(double aSide, double bSide, double cSide);
        public (double Value, string Error) CalculateSquareArea(double diameter);
        public (bool Value, string Error) IsTriangleSquareAngle(double aSide, double bSide, double cSide);
    }
}
