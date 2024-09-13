using Atividade4.Models;
namespace Atividade4.Menus;

internal class MenuCadastro : Menu
{
    public override void Executar(Dictionary<string, Autenticacao> usuarios)
    {
        base.Executar(usuarios);
        Console.WriteLine("----------------------Cadastro de usuário----------------------");
        System.Console.WriteLine("Digite o login para o novo usuário: ");
        string login = Console.ReadLine()!;

        if (usuarios.ContainsKey(login))
        {
            Console.WriteLine("Este login já está em uso. Tente novamente com outro login.");
            return;
        }
        else
        {
            Console.WriteLine("Digite a senha para o novo usuario:");
            string senha = Console.ReadLine()!;

            Autenticacao novoUsuario = new();
            novoUsuario.DefinirLogin(login);
            novoUsuario.DefinirSenha(senha);

            usuarios.Add(novoUsuario.MostraLogin(), novoUsuario);
            Console.WriteLine("Usuário cadastrado com sucesso!");
            Thread.Sleep(2000);
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }

    }
}