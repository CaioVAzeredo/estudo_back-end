namespace Armazenar.Models;

internal class Arquivo : IArmazenavel
{
    public string Nome { get; set; }
    public Arquivo(string nome)
    {
        Nome = nome;
    }

    public void Salvar()
    {
        Console.WriteLine("Arquivo salvo com sucesso!!");
    }
    public void Recuperar()
    {
        Console.WriteLine("Arquivo recuperado com sucesso");
    }
}
