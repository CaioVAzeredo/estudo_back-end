using Atividade4.Models;
namespace Atividade4.Menus;

internal class MenuLogin : Menu
{
    public override void Executar(Dictionary<string, Autenticacao> usuarios)
    {
        base.Executar(usuarios);
        Console.WriteLine("----------------------Login de usuário----------------------");
        Console.WriteLine("Qual o login?");
        string login = Console.ReadLine()!;

        foreach (KeyValuePair<string, Autenticacao> usuario in usuarios)
        {
            if (login == usuario.Value.MostraLogin())
            {
                Console.WriteLine("Qual a senha?");
                string senha = Console.ReadLine()!;
                if (usuario.Value.VerificaSenha(senha))
                {
                    Console.WriteLine("Acesso autorizado!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha errada!!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
            else
            {
                Console.WriteLine("Login não encontrado!!");
                Thread.Sleep(2000);
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }
}