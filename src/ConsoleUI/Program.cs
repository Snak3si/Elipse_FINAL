double perimetro;
double area;
double volumen;

Console.WriteLine("Calculadora de Perímetro, Área y Volumen de un Prisma con Base Elíptica");

Console.Write("Dame el eje mayor (a): ");
double ejeMayor = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame el eje menor (b): ");
double ejeMenor = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

perimetro = Application.Elipse.Perimetro(ejeMayor, ejeMenor);
area = Application.Elipse.Area(ejeMayor, ejeMenor);

volumen = Application.PrismaElipse.Volumen(area, altura);

Console.WriteLine();
Console.WriteLine($"Perímetro: {perimetro:F3} cm\nÁrea: {area:F3} cm²\nVolumen: {volumen:F3} cm³");
