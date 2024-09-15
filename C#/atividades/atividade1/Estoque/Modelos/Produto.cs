namespace Atividade2.Modelos;
internal class Produto
{
    public string Nome { get; }
    public int Quantidade { get; }

    public Produto(string nome, int quantidade)
    {
        Nome = nome;
        Quantidade = quantidade;
    }
}