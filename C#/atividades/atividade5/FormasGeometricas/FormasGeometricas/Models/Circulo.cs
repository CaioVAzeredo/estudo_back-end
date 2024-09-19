namespace FormasGeometricas.FormaGenerica;

internal class Circulo : FormaGenerica, ICalculoArea
{
    public float Raio { get; set; }

    public Circulo(string nome, float raio) : base(nome)
    {
        Raio = raio;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        CalcularArea();
        CalcularPerimetro();
    }

    public void CalcularArea()
    {
        Console.WriteLine($"Área do {Nome}: {3.14 * (Raio * Raio)}");
    }
    public void CalcularPerimetro()
    {
        Console.WriteLine($"Perimetro do {Nome}: {2 * 3.14 * Raio}");
    }
}