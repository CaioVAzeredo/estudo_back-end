namespace FormasGeometricas.FormaGenerica;


internal class Triangulo : FormaGenerica, ICalculoArea
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
        CalcularArea();
        CalcularPerimetro();   
    }

    public void CalcularArea()
    {
        Console.WriteLine($"Área do {Nome}: {Altura * Base}");
    }
    public void CalcularPerimetro()
    {
        Console.WriteLine($"Perimetro do {Nome}: {(Altura * 2) + (Base * 2)}");
    }
}