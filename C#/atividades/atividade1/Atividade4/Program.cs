using Atividade4.Models;
using Atividade4.Menus;

Autenticacao us1 = new Autenticacao();
us1.DefinirLogin("Caio");
us1.DefinirSenha("12345");

Dictionary<string, Autenticacao> usuarios = new();
usuarios.Add(us1.MostraLogin(), us1);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuLogin());
opcoes.Add(2, new MenuCadastro());


void ExibirOpcoes()
{
    System.Console.WriteLine("O que deseja fazer?");
    System.Console.WriteLine("Digite 1 para fazer Login ");
    System.Console.WriteLine("Digite 2 para cadastrar um novo Login");
    System.Console.WriteLine("*************************************");
    System.Console.WriteLine("Digite a sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(usuarios);
    }
}

ExibirOpcoes();