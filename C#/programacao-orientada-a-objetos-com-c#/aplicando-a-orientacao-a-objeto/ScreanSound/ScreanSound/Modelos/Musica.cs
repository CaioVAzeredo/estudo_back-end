class Musica
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}"; //é a mesma coisa que o {get{return}}

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public void ExibirFichaTecnica()
    {

        Console.WriteLine($"\nNome musica: {Nome}\nArtista: {Artista.Nome}\nDuração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível");
        }
        else
        {
            Console.WriteLine("Adquira o plano");
        }
    }
}
