using Atividade3.Menus;
using Atividade3.Modelos;

Perguntas pergunta1 = new("Pergunta: Qual é o maior planeta do sistema solar?\n1) Terra\n2) Júpiter\n3) Marte\n4) Saturno\n", 2);


void OpcoesDoMenu()
{
    Console.WriteLine("\nPergunta: Qual é o maior planeta do sistema solar?\n1-Terra\n2- Júpiter\n3-Marte\n4- Saturno");
    Console.WriteLine("\nQual a sua resposta?");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcaoEscolhidaNumerica == 1 || opcaoEscolhidaNumerica == 2 || opcaoEscolhidaNumerica == 3 || opcaoEscolhidaNumerica == 4)
    {
        if (opcaoEscolhidaNumerica == 2)
        {
            Console.WriteLine("Resposta correta");
        }
        else
        {
            Console.WriteLine("resposta incorreta, a resposta correta é a 2");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Insira um valor valido");
    }
    /* ------------------------------------- */
    Console.WriteLine("\nQuem escreveu o livro 'Dom Quixote'?\n1- William Shakespeare\n2- GabrielGarcía Márquez\n3- Miguel de Cervantes\n4- Jorge Luis Borges");
    Console.WriteLine("\nQual a sua resposta?");
    string opcaoEscolhida2 = Console.ReadLine()!;
    int opcaoEscolhidaNumerica2 = int.Parse(opcaoEscolhida2);
    if (opcaoEscolhidaNumerica2 == 1 || opcaoEscolhidaNumerica2 == 2 || opcaoEscolhidaNumerica2 == 3 || opcaoEscolhidaNumerica2 == 4)
    {
        if (opcaoEscolhidaNumerica == 3)
        {
            Console.WriteLine("Resposta correta");
        }
        else
        {
            Console.WriteLine("resposta incorreta, a resposta correta é a 3");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Insira um valor valido");
    }
    /* ------------------------------------- */
    Console.WriteLine("\n Qual elemento químico tem o símbolo 'O' na tabela periódica?\n1- Ouro\n2- Oxigênio\n3- Ósmio\n4- Óxido");
    Console.WriteLine("\nQual a sua resposta?");
    string opcaoEscolhida3 = Console.ReadLine()!;
    int opcaoEscolhidaNumerica3 = int.Parse(opcaoEscolhida3);
    if (opcaoEscolhidaNumerica3 == 1 || opcaoEscolhidaNumerica3 == 2 || opcaoEscolhidaNumerica3 == 3 || opcaoEscolhidaNumerica3 == 4)
    {
        if (opcaoEscolhidaNumerica == 2)
        {
            Console.WriteLine("Resposta correta");
        }
        else
        {
            Console.WriteLine("resposta incorreta, a resposta correta é a 2");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Insira um valor valido");
    }
    /* ------------------------------------- */
    Console.WriteLine("\nPergunta: Qual é o valor de π (pi) aproximado com duas casas decimais?\n1- 3,12\n2- 3,14\n3- 3,16\n4- 3,18");
    Console.WriteLine("\nQual a sua resposta?");
    string opcaoEscolhida4 = Console.ReadLine()!;
    int opcaoEscolhidaNumerica4 = int.Parse(opcaoEscolhida4);
    if (opcaoEscolhidaNumerica4 == 1 || opcaoEscolhidaNumerica4 == 2 || opcaoEscolhidaNumerica4 == 3 || opcaoEscolhidaNumerica4 == 4)
    {
        if (opcaoEscolhidaNumerica4 == 2)
        {
            Console.WriteLine("Resposta correta");
        }
        else
        {
            Console.WriteLine("resposta incorreta, a resposta correta é a 2");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Insira um valor valido");
    }
    /* ------------------------------------- */
    Console.WriteLine("\nEm que ano o homem pisou na Lua pela primeira vez?\n1- 1965\n2- 1967\n3- 1969\n4- 1971");
    Console.WriteLine("\nQual a sua resposta?");
    string opcaoEscolhida5 = Console.ReadLine()!;
    int opcaoEscolhidaNumerica5 = int.Parse(opcaoEscolhida5);
    if (opcaoEscolhidaNumerica5 == 1 || opcaoEscolhidaNumerica5 == 2 || opcaoEscolhidaNumerica5 == 3 || opcaoEscolhidaNumerica5 == 4)
    {
        if (opcaoEscolhidaNumerica5 == 3)
        {
            Console.WriteLine("Resposta correta");
        }
        else
        {
            Console.WriteLine("resposta incorreta, a resposta correta é a 3");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Insira um valor valido");
    }
}

OpcoesDoMenu();
