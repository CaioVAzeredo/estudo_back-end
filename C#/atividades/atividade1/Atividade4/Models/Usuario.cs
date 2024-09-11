namespace Atividade4.Models;

internal class Usuario{
    public string Login { get; }
    public string Senha { get; }

    public Usuario(string login, string senha)
    {
        Login = login;
        Senha = senha;
    }
}