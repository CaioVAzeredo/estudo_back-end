namespace FormasGeometricas.FormaGenerica;

internal class Circulo : FormaGenerica
{
    public float Raio { get; set; }

    public Circulo(string nome, float raio) : base(nome)
    {
        Raio = raio;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        CalculoArea();
    }

    public void CalculoArea()
    {
        Console.WriteLine($"Área do {Nome}: {3.14 * (Raio * Raio)}");
    }
}