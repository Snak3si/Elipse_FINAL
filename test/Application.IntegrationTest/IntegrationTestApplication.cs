using System;
using Xunit;
using Application;

namespace Application.IntegrationTest;

    public class IntegrationTestApplication
    {
        [Theory]
        [InlineData(4, 4, 201.062)]
        [InlineData(5, 6, 471.239)]
        [InlineData(2, 4, 50.265)]
        [InlineData(3, 3, 84.823)]
        [InlineData(7, 8, 1231.504)]
     
        public void TestVolumen(double a, double altura, double volumenEsp)
        {
            // Arrange – Set up
            double b = a; 
            double area = Elipse.Area(a, b);

            // Act – Perform
            double resultado = PrismaElipse.Volumen(area, altura);

            // Assert – Verify
            Assert.Equal(volumenEsp, resultado, 3);
        }
    }

