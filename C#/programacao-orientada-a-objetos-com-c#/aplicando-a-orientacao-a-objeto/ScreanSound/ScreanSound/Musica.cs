class Musica{
   public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;


    public void ExibirFichaTecnica()
    {

        Console.WriteLine($"\nNome musica: {this.nome}\nArtista: {this.artista}\nDuração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível");
        }
        else
        {
            Console.WriteLine("Adquira o plano");
        }
    }
}
