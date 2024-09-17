namespace FormasGeometricas.FormaGenerica;

internal class FormaGenerica
{
    public string Nome { get; }

    public FormaGenerica(string nome)
    {
        Nome = nome;
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Forma: {Nome}");
    }

}