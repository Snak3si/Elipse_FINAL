// code .\test\Application.UnitTest\UnitTestCuadrado.cs
using System;
using Xunit;
using Application;

namespace Application.Tests
{
    public class UnitTestElipse
    {
        [Theory]
        [InlineData(1, 2, Math.PI * 3)]
        [InlineData(2, 3, Math.PI * 5)]
        [InlineData(3, 4, Math.PI * 7)]
        [InlineData(7, 2, Math.PI * 9)]
        [InlineData(3, 9, Math.PI * 12)]
        
        public void TestPerimetro(double a, double b, double perimetro)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Elipse.Perimetro(a, b);

            // Assert – Verify
            Assert.Equal(resultado, perimetro);  
        }
        [Theory]
        [InlineData(1, 2, Math.PI * 2)]
        [InlineData(2, 3, Math.PI * 6)]
        [InlineData(3, 4, Math.PI * 12)]
        [InlineData(4, 6, Math.PI * 24)]
        [InlineData(5, 5, Math.PI * 25)]
        public void TestArea(double a, double b, double area)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Elipse.Area(a, b);

            // Assert – Verify
            Assert.Equal(resultado, area );  
        }

    }
}
