namespace FormasGeometricas.FormaGenerica;


internal class Triangulo : FormaGenerica
{
    public float Altura { get; set; }
    public float Base { get; set; }
    public Triangulo(string nome, float altura, float base1) : base(nome)
    {
        Altura = altura;
        Base = base1;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Área do {Nome}: {Altura * Base}");
    }
}