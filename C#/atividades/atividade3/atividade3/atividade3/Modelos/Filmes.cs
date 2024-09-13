namespace atividade3.Filmes;

internal class Filmes
{
    private List<Artistas> pessoas = new();


    public string Titulo { get; set; }
    public float Duracao { get; set; }

    public Filmes(float duracao, string titulo)
    {
        Duracao = duracao;
        Titulo = titulo;
    }

    public void AdicionaElenco(Artistas nome)
    {
        pessoas.Add(nome);
    }

    public void adicionarParticipacao()
    {

    }
    

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Filme: {Titulo}, Duração: {Duracao}");
        Console.WriteLine("Elenco: ");
        foreach (Artistas pessoa in pessoas)
        {
            Console.WriteLine(pessoa.Nome);
        }
    }
}
