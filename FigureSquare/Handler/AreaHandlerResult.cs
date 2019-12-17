namespace FigureArea.Handler
{
    /// <summary>
    /// Возвращаемый объект AreaHandler
    /// </summary>
    public class AreaHandlerResult
    {
        public string Error { get; private set; } = null;
        public double Value { get; private set; }
        public bool Success { get; private set; }
        private AreaHandlerResult() { }
        public static AreaHandlerResult UnexpectedType() => FromError("Указан не верный тип фигуры");
        public static AreaHandlerResult ToSmallSize() => FromError("Ширина или высота фигуры меньше или равны нулю");
        public static AreaHandlerResult FromSuccess(double value) => new AreaHandlerResult { Success = true, Value = value };
        public static AreaHandlerResult FromError(string error) => new AreaHandlerResult { Success = false, Value = default, Error = error };
    }
}
