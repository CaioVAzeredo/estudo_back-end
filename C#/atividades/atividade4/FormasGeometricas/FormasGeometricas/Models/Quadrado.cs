namespace FormasGeometricas.FormaGenerica;

internal class Quadrado : FormaGenerica
{
    public float Altura { get; set; }
    public float Base { get; set; }

    public Quadrado(string nome, float altura, float base1) : base(nome)
    {
        Altura = altura;
        Base = base1;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        CalculoArea();
    }

    public void CalculoArea()
    {
       Console.WriteLine($"Área do {Nome}: {Altura * Base}");
    }
}