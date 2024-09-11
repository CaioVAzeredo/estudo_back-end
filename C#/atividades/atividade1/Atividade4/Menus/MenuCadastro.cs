using Atividade4.Models;
namespace Atividade4.Menus;

internal class MenuCadastro : Menu
{

    public override void Executar(Dictionary<string, Autenticacao> usuarios)
    {
        base.Executar(usuarios);
        System.Console.WriteLine("----------------------Cadastro de usuário----------------------");
        
    }
}