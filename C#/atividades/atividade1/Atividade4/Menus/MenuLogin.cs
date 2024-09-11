using Atividade4.Models;
namespace Atividade4.Menus;

internal class MenuLogin : Menu
{
    public override void Executar(Dictionary<string, Autenticacao> usuarios)
    {
        base.Executar(usuarios);
        System.Console.WriteLine("----------------------Login de usuário----------------------");
        System.Console.WriteLine("Qual o login?");
        string login = Console.ReadLine()!;

        foreach (KeyValuePair<string, Autenticacao> usuario in usuarios)
        {
            if (login == usuario.Value.Login)
            {
                System.Console.WriteLine("Qual a senha?");
                string senha = Console.ReadLine()!;
                if (senha == usuario.Value.Senha)
                {
                    System.Console.WriteLine("Acesso autorizado!!");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Senha errada!!");
                    break;
                }
            }
            else
            {
                System.Console.WriteLine("Login não encontrado!!");
                break;
            }
        }
    }
}