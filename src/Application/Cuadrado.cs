// code .\src\Application\Cuadrado.cs
namespace Application;
public class Elipse
{
public static double Perimetro(double a , double b)
{
double perimetro =  Math.PI * (a + b);
return perimetro;
}
public static double Area(double a, double b)
{
double area = Math.PI * a * b;
return area;
}

}