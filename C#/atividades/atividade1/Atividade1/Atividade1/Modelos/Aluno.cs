namespace Atividade1.Modelos;

internal class Aluno
{
    private List<Avaliacao> notas = new List<Avaliacao>();
    public string Nome { get; }
    public double Media
    {
        get
        {
            if(notas.Count == 0)
            {
                return 0;
            }
            else
            {
                return notas.Average(a => a.Nota);
            };
        }
    }

    public Aluno(string nome)
    {
        Nome = nome;
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirAluno()
    {
        Console.WriteLine($"Nome: {Nome}.\nMédia: {Media}");
    }
}
