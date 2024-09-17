namespace Empresa.Models;

internal class Analista : Funcionario
{
    public string AreaEspecializacao { get; set; }
    public string RequisitosDocumentados { get; set; }
    public string ModelosProcessos { get; set; }


    public Analista(string nome, string email, float salario, string nivelDeExperiencia, string areaEspecializacao, string requisitosDocumentados, string modelosProcessos) : base(nome, email, salario, nivelDeExperiencia)
    {
        AreaEspecializacao = areaEspecializacao;
        RequisitosDocumentados = requisitosDocumentados;
        ModelosProcessos = modelosProcessos;
    }
    public override void desenvolverCompetencias()
    {
        base.desenvolverCompetencias();
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
    }

    public void analisarRequisitos()
    {
        Console.WriteLine("Requisitos analisados com sucesso!");
    }
    public void modelarProcessos()
    {
        System.Console.WriteLine("Analisando  modelos de processos");
    }

}