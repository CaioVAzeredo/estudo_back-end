namespace Empresa.Models;

internal class Programador : Funcionario
{
    public string LinguagensProgramacao { get; set; }
    public string RepositorioGit { get; set; }  
    public string Certificacoes { get; set; }

    public Programador(string nome, string email, float salario, string nivelDeExperiencia, string linguagensProgramacao, string repositorioGit, string certificacoes) : base(nome, email, salario, nivelDeExperiencia)
    {
        LinguagensProgramacao = linguagensProgramacao;
        RepositorioGit = repositorioGit;
        Certificacoes = certificacoes;
    }

    public override void desenvolverCompetencias()
    {
        base.desenvolverCompetencias();
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
    }

    public void EscreverCodigo(){
    Console.WriteLine("Escrevendo código...");
}

public void ColaborarNoGit(){
    Console.WriteLine("Colaborando no Git...");
}


}