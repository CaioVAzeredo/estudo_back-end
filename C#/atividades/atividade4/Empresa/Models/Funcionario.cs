namespace Empresa.Models;

internal class Funcionario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public float Salario { get; set; }
    public string NivelDeExperiencia { get; set; }

    public Funcionario(string nome, string email, float salario, string nivelDeExperiencia)
    {
        Nome = nome;
        Email = email;
        Salario = salario;
        NivelDeExperiencia = nivelDeExperiencia;
    }

public virtual void desenvolverCompetencias(){
    Console.WriteLine("Desenvolvendo competências");
}



public virtual void ExibirInformacoes(){
    Console.WriteLine($"Nome: {Nome} - Email: {Email} - Salário: {Salario}");
}
}
