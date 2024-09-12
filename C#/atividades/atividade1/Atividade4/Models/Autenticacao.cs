namespace Atividade4.Models;

internal class Autenticacao
{
    private string Login { get; set; }
    private string Senha { get; set; }

    /*public Autenticacao(string login, string senha)
    {
        Login = login;
        Senha = senha;
    }*/
    public void DefinirLogin(string login)
    {
        Login = login;
    }
    public void DefinirSenha(string senha)
    {
        Senha = senha;
    }
  public string MostraLogin()
    {
        return Login;
    }

    public string MostrarSenha()
    {
        return Senha;
    }
}