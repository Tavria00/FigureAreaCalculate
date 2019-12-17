using AutoFixture;
using FigureArea.Model;
using FigureArea.Service;
using Moq;
using System;
using Xunit;

namespace FigureUnitTest.Test.Service
{
    public class FigureServiceTest
    {
        private readonly FigureService _areaService;
        private readonly Random _random = new Random();
        public FigureServiceTest()
        {
            _areaService = new FigureService();
        }
        [Fact]
        public void CalculateCircleArea_OkResult()
        {
            var circle = new Fixture().Build<Circle>().With(w=>w.Radius, _random.Next()).Create();

            var result = _areaService.CalculateCircleArea(circle.Radius);
            Assert.Null(result.Error);
            Assert.Equal(circle.Area, result.Value);
        }
        [Fact]
        public void CalculateCircleArea_ErrorResult()
        {
            var circle = new Fixture().Build<Circle>().With(w => w.Radius, -_random.Next(1)).Create();

            var result = _areaService.CalculateCircleArea(circle.Radius);
            Assert.Equal(0, result.Value);
            Assert.Equal("Радиус круга должен быть больше нуля", result.Error);
        }
        [Fact]
        public void CalculateSquareArea_OkResult()
        {
            var square = new Fixture().Build<Square>().With(w => w.Side, _random.Next()).Create();

            var result = _areaService.CalculateSquareArea(square.Side);
            Assert.Null(result.Error);
            Assert.Equal(square.Area, result.Value);
        }
        [Fact]
        public void CalculateSquareArea_ErrorResult()
        {
            var square = new Fixture().Build<Square>().With(w => w.Side, -_random.Next()).Create();

            var result = _areaService.CalculateSquareArea(square.Side);
            Assert.Equal(0, result.Value);
            Assert.Equal("Сторона квадрата должна быть больше нуля", result.Error);
        }
        [Fact]
        public void CalculateTriangleArea_OkResult()
        {
            var triangle = new Fixture().Build<Triangle>().With(w => w.ASide, _random.Next()).With(w => w.BSide, _random.Next()).With(w => w.CSide, _random.Next()).Create();

            var result = _areaService.CalculateTriangleArea(triangle.ASide, triangle.BSide, triangle.CSide);
            Assert.Null(result.Error);
            Assert.Equal(triangle.Area, result.Value);
        }
        [Fact]
        public void CalculateTriangleArea_ErrorResult()
        {
            var triangle = new Fixture().Build<Triangle>()
                .With(w => w.ASide, _random.Next()*-1)
                .With(w => w.BSide, _random.Next())
                .With(w => w.CSide, _random.Next())
                .Create();

            var result = _areaService.CalculateTriangleArea(triangle.ASide, triangle.BSide, triangle.CSide);
            Assert.Equal(0, result.Value);
            Assert.Equal("Стороны треугольника должны быть больше нуля", result.Error);
        }
        [Fact]
        public void IsTriangleSquareAngle_OkResult()
        {
            var triangle = new Fixture().Build<Triangle>().With(w => w.ASide, _random.Next()).With(w => w.BSide, _random.Next()).With(w => w.CSide, _random.Next()).Create();

            var result = _areaService.IsTriangleSquareAngle(triangle.ASide, triangle.BSide, triangle.CSide);
            Assert.Null(result.Error);
            Assert.Equal(triangle.isSquare(), result.Value);
        }
        [Fact]
        public void IsTriangleSquareAngle_ErrorResult()
        {
            var triangle = new Fixture().Build<Triangle>()
                .With(w => w.ASide, -_random.Next())
                .With(w => w.BSide, _random.Next())
                .With(w => w.CSide, _random.Next())
                .Create();

            var result = _areaService.IsTriangleSquareAngle(triangle.ASide, triangle.BSide, triangle.CSide);
            Assert.False(result.Value);
            Assert.Equal("Стороны треугольника должны быть больше нуля", result.Error);
        }
        [Theory]
        [InlineData(2, 2, 3, false)]
        [InlineData(3, 4, 5, true)]
        public void IsTriangleSquareAngle_ReturnExpectedresult(double aSide, double bSide, double cSide, bool expected)
        {
            var triangle = new Fixture().Build<Triangle>()
                .With(w => w.ASide, aSide)
                .With(w => w.BSide, bSide)
                .With(w => w.CSide, cSide)
                .Create();

            var result = _areaService.IsTriangleSquareAngle(triangle.ASide, triangle.BSide, triangle.CSide);

            Assert.Null(result.Error);
            Assert.Equal(expected, result.Value);
        }
    }
    
}
