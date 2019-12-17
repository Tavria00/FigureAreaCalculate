using FigureSquare.Handler.Interface;
using FigureSquare.Model.Enum;
using FigureSquare.Model.Interface;
using System;

namespace FigureArea.Handler
{
    public class AreaHandler : IAreaHandler
    {
        /// <summary>
        /// Расчет площади фигуры
        /// </summary>
        /// <param name="figure">Геометрическая фигура</param>
        /// <returns>(Success,Value,Error)</returns>
        public AreaHandlerResult CalculateArea(IFigure figure)
        {
            if(figure.Height <=0 || figure.Width<=0)
                return AreaHandlerResult.ToSmallSize();

            double result;
            switch (figure.Type)
            {
                case FigureType.Square:
                    result = Math.Pow(figure.Height,2);
                    break;
                case FigureType.Triangle:
                    result = figure.Height*figure.Width/2;
                    break;
                case FigureType.Circle:
                    result = Math.PI * Math.Pow(figure.Height / 2, 2);
                    break;
                default:
                    return AreaHandlerResult.UnexpectedType();
            }
            return AreaHandlerResult.FromSuccess(result);
        }

    }
}
