namespace Armazenar.Models;

internal class BancoDeDados : IArmazenavel
{
    public void Salvar()
    {
        Console.WriteLine("Arquivo salvo com sucesso!!");
    }
    public void Recuperar()
    {
        Console.WriteLine("Arquivo recuperado com sucesso");
    }
}