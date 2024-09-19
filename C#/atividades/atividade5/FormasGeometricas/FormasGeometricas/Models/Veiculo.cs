namespace FormasGeometricas.Models;

internal class Veiculo : IPilotavel, IVoavel
{

    public string Marca { get; set; }
    public string Nome { get; set; }
    public int Ano { get; set; }


    public Veiculo(string marca, string nome, int ano)
    {
        Marca = marca;
        Nome = nome;
        Ano = ano;
    }

    public void Movimentar()
    {
        Console.WriteLine("O Veiculo está se movimentando ");
    }
    public bool Voar(bool resposta)
    {
        if (resposta)
        {
            Console.WriteLine("O veiculo voa");
            return true;
        }
        else
        {
            Console.WriteLine("O veiculo não voa");
            return false;

        }
    }

    public bool Pilotar(bool resposta)
    {
        if (resposta)
        {
            Console.WriteLine("O veiculo é pilotável");
            return true;
        }
        else
        {
            Console.WriteLine("O veiculo não pilotável");
            return false;

        }
    }
}
