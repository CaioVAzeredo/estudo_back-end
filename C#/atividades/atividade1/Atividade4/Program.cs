using Atividade4.Models;
using Atividade4.Menus;

Autenticacao us1 = new Autenticacao("Caio", "12345");
Autenticacao us2 = new Autenticacao("Felipe", "4321");
Autenticacao us3 = new Autenticacao("Augusto", "9876");
Autenticacao us4 = new Autenticacao("Fernando", "6789");

Dictionary<string, Autenticacao> usuarios = new();
usuarios.Add(us1.Login, us1);
usuarios.Add(us2.Login, us2);
usuarios.Add(us3.Login, us3);
usuarios.Add(us4.Login, us4);

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