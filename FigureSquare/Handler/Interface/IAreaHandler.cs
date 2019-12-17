using FigureArea.Handler;
using FigureSquare.Model.Interface;

namespace FigureSquare.Handler.Interface
{
    public interface IAreaHandler
    {
        public AreaHandlerResult CalculateArea(IFigure figure);
    }
}
