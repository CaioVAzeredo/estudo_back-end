
namespace atividade3.Filmes;

internal class Artistas
{
    private List<ParticipacaoEmFilmes> ParticipacaoEmFilmes = new();
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Artistas(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}
