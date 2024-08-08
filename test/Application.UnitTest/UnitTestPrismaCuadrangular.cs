 // .\test\Application.UnitTest\UnitTestPrismaCuadrangular.cs
using System;
using Xunit;
using Application;
namespace Application.UnitTest;

public class UnitTestPrismaElipse
{
    [Theory]
    [InlineData(16, 4, 64)]
    [InlineData(25, 6, 150)]
    [InlineData(11, 1, 11)]
    [InlineData(24, 3, 72)]
    [InlineData(15, 2, 30)]
    
    public void TestVolumen(double area, double altura, double volumen)
    {
        // Arrange – Set up
      
        // Act – Perform
        double resultado = PrismaElipse.Volumen(area, altura);
        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}