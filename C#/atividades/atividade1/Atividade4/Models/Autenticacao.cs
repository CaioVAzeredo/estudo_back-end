namespace Atividade4.Models;

internal class Autenticacao
{
    public string Login { get; }
    public string Senha { get; }

    public Autenticacao(string login, string senha)
    {
        Login = login;
        Senha = senha;
    }


}