namespace atividade3.Modelos;

internal class Filmes
{
    private List<Elenco> pessoas = new List<Elenco>();


    public string Titulo { get; set; }
    public float Duracao { get; set; }

    public Filmes(float duracao, string titulo)
    {
        Duracao = duracao;
        Titulo = titulo;
    }

    public void AdicionaElenco(Elenco nome)
    {
        pessoas.Add(nome);
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Nome do filme: {Titulo}, Duração: {Duracao}");
        Console.WriteLine("Elenco: ");
        foreach (Elenco pessoa in pessoas)
        {
            Console.WriteLine(pessoa.Nome);
        }
    }
}
