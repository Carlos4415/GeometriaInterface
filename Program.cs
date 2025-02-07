//Este programa demonstra o uso de interfaces em C# por meio da criação de uma interface chamada IForma,
//que declara métodos para calcular a área e o perímetro de formas geométricas.
//Duas classes, Circulo e Retangulo, implementam a interface, fornecendo cálculos específicos
//para suas respectivas formas. O objetivo é explorar conceitos de polimorfismo e reutilização de código
//no contexto de programação orientada a objetos.

using GeometriaInterface;

Circulo circulo = new();
circulo.Raio = 5;

Console.WriteLine("Círculo:");
Console.WriteLine($"Área: {circulo.CalcularArea()}");
Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");

Retangulo retangulo = new();
retangulo.Comprimento = 10;
retangulo.Largura = 5;

Console.WriteLine("\nRetângulo:");
Console.WriteLine($"Área: {retangulo.CalcularArea()}");
Console.WriteLine($"Perímetro: {retangulo.CalcularPerimetro()}");