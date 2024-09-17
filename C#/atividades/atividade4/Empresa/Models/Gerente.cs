namespace Empresa.Models;

internal class Gerente : Funcionario
{

    public string Departamento { get; set; }
    public string Metas { get; set; }
    public string NivelHierarquico { get; set; }
    public Gerente(string nome, string email, float salario, string nivelDeExperiencia, string departamento, string metas, string nivelHierarquico) : base(nome, email, salario, nivelDeExperiencia)
    {
        Departamento = departamento;
        Metas = metas;
        NivelHierarquico = nivelHierarquico;
    }

    public override void desenvolverCompetencias()
    {
        base.desenvolverCompetencias();
    }
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
    }

    public void DefinirMetas()
    {
        Console.WriteLine("Metas definidas: " + Metas);
    }
}