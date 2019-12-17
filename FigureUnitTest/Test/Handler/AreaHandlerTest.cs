using AutoFixture;
using FigureArea.Handler;
using FigureArea.Model;
using FigureSquare.Model.Enum;
using FigureSquare.Model.Interface;
using System;
using System.Collections.Generic;
using Xunit;

namespace FigureUnitTest.Test.Handler
{
    public class AreaHandlerTest
    {
        private readonly AreaHandler _areaHandler;
        private readonly Fixture _fixture;
        public AreaHandlerTest()
        {
            _areaHandler = new AreaHandler();
            _fixture = new Fixture();
        }

        [Fact]
        public void CalculateArea_ZeroHeight_ReturnError()
        {
            var figure = _fixture.Build<Triangle>().With(w => w.Height, 0).Create();
            var result = _areaHandler.CalculateArea(figure);

            Assert.IsType<AreaHandlerResult>(result);
            Assert.False(result.Success);
            Assert.Equal(0, result.Value);
            Assert.Equal(AreaHandlerResult.ToSmallSize().Error, result.Error);
        }
        [Fact]
        public void CalculateArea_AnotherType_ReturnError()
        {
            var figure = _fixture.Build<Triangle>().With(w => w.Type, FigureType.Error).Create();
            var result = _areaHandler.CalculateArea(figure);

            Assert.IsType<AreaHandlerResult>(result);
            Assert.False(result.Success);
            Assert.Equal(0, result.Value);
            Assert.Equal(AreaHandlerResult.UnexpectedType().Error, result.Error);
        }

        public static List<object[]> FigureData = new List<object[]>()
        {
            new object[]{new Square(2), 4},
            new object[]{new Triangle(2, 4), 4},
            new object[]{new Circle(6), Math.PI*9}
        };
        [Theory]
        [MemberData(nameof(FigureData))]
        public void CalculateArea_ValidData_ReturnResult(IFigure figure, double expectedVal )
        {
            var result = _areaHandler.CalculateArea(figure);

            Assert.IsType<AreaHandlerResult>(result);
            Assert.True(result.Success);
            Assert.Equal(expectedVal, result.Value);
            Assert.Null(result.Error);
        }

    }
}
