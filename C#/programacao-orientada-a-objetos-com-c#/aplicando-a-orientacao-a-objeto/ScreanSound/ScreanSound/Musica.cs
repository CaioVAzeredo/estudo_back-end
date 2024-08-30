class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}"; //é a mesma coisa que o {get{return}}

    public void ExibirFichaTecnica()
    {

        Console.WriteLine($"\nNome musica: {Nome}\nArtista: {Artista}\nDuração: {Duracao}");
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
