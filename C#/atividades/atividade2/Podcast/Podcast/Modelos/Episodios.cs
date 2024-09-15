namespace Podcast.Modelos;

internal class Episodios
{
    public float Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"O {Titulo} com {Duracao} desse Podcast";

    public Episodios(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

}
