using FormasGeometricas.FormaGenerica;
using FormasGeometricas.Models;

Quadrado quadrado = new("Quadrado", 10, 5);
quadrado.ExibirInfo();
System.Console.WriteLine("\n");
Triangulo triangulo = new("Triangulo", 15, 5);
triangulo.ExibirInfo();
System.Console.WriteLine("\n");
Circulo circulo = new("Circulo", 5);
circulo.ExibirInfo();
/*------------------------------------------------*/

Veiculo carro = new("Fiat", "Uno", 2012);
carro.Voar(false);
