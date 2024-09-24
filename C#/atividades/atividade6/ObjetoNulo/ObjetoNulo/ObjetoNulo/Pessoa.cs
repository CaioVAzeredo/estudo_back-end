namespace ObjetoNulo;

internal class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Andar(string movimento)
    {
        Console.WriteLine(movimento);
    }
}
