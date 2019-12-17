using AutoFixture;
using FigureArea.Handler;
using FigureArea.Service;
using FigureSquare.Handler.Interface;
using FigureSquare.Model.Interface;
using Moq;
using Xunit;

namespace FigureUnitTest.Test.Service
{
    public class AreaServiceTest
    {
        private readonly AreaService _areaService;
        private readonly Mock<IAreaHandler> _areaHandler;
        public AreaServiceTest()
        {
            _areaHandler = new Mock<IAreaHandler>();
            _areaService = new AreaService(_areaHandler.Object);
        }
        [Fact]
        public void CalculateCircleArea_OkResult()
        {
            double exceptedVal = new Fixture().Create<double>();
            _areaHandler.Setup(s => s.CalculateArea(It.IsAny<IFigure>())).Returns(AreaHandlerResult.FromSuccess(exceptedVal));

            var result = _areaService.CalculateCircleArea(1);
            Assert.Null(result.Error);
            Assert.Equal(exceptedVal, result.Value);
        }
        [Fact]
        public void CalculateCircleArea_ErrorResult()
        {
            _areaHandler.Setup(s => s.CalculateArea(It.IsAny<IFigure>())).Returns(AreaHandlerResult.FromError("error"));

            var result = _areaService.CalculateCircleArea(1);
            Assert.Equal(0, result.Value);
            Assert.Equal("error", result.Error);
        }
        [Fact]
        public void CalculateSquareArea_OkResult()
        {
            double exceptedVal = new Fixture().Create<double>();
            _areaHandler.Setup(s => s.CalculateArea(It.IsAny<IFigure>())).Returns(AreaHandlerResult.FromSuccess(exceptedVal));

            var result = _areaService.CalculateSquareArea(1);
            Assert.Null(result.Error);
            Assert.Equal(exceptedVal, result.Value);
        }
        [Fact]
        public void CalculateSquareArea_ErrorResult()
        {
            _areaHandler.Setup(s => s.CalculateArea(It.IsAny<IFigure>())).Returns(AreaHandlerResult.FromError("error"));

            var result = _areaService.CalculateSquareArea(1);
            Assert.Equal(0, result.Value);
            Assert.Equal("error", result.Error);
        }
        [Fact]
        public void CalculateTriangleArea_OkResult()
        {
            double exceptedVal = new Fixture().Create<double>();
            _areaHandler.Setup(s => s.CalculateArea(It.IsAny<IFigure>())).Returns(AreaHandlerResult.FromSuccess(exceptedVal));

            var result = _areaService.CalculateTriangleArea(1,1);
            Assert.Null(result.Error);
            Assert.Equal(exceptedVal, result.Value);
        }
        [Fact]
        public void CalculateTriangleArea_ErrorResult()
        {
            _areaHandler.Setup(s => s.CalculateArea(It.IsAny<IFigure>())).Returns(AreaHandlerResult.FromError("error"));

            var result = _areaService.CalculateTriangleArea(1,1);
            Assert.Equal(0, result.Value);
            Assert.Equal("error", result.Error);
        }
    }
    
}
