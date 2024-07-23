//Screan Sound
//Linguagem fortemente tipada

//Padrao Camel Case
string mensagemDeBoasVindas = "Boas vindas ao Screan Sound";

/* LISTA DE BANDA SEM NADA: List<string> ListaDasBandas = new List<string>(); */

// List<string> ListaDasBandas = new List<string> { "U2", "The Beatles", "Calipso" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); //Dictionary armazena coleções de pares chave(key)-valor(value). 
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

//Padrão Pascal Case
void ExibirLogo()
{
    Console.WriteLine("***************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("***************************");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para a média de uma  banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // a esclamação serve para evitar que esse valor seja nulo.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostaraBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            MediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Até mais!!");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    //limpar console
    void LimparConsole()
    {
        Console.Clear();
    }

    //Banda nao encontrada 
    void BandaNaoEncontrada(string NomeDaBanda)
    {
        LimparConsole();
        Console.WriteLine($"A banda {NomeDaBanda} não foi encontrada");
        Thread.Sleep(2000);
        LimparConsole();
        ExibirOpcoesDoMenu();
    }

    // exibir titulo da opção
    void ExibirTitiloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*'); //string.Empty representa uma string vazia. .PadLeft() é um método aplicado à string vazia para preencher à esquerda, o primeiro parâmetro é a quantidade e o segundo parâmetro é a string que vai preencher.

        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    //Registrar banda
    void RegistrarBanda()
    {
        LimparConsole();
        ExibirTitiloDaOpcao("Registro das bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");

        string nomeDaBanda = Console.ReadLine()!;

        bandasRegistradas.Add(nomeDaBanda, new List<int>()); //primeiro parâmetro = nome da banda, segundo parâmetro = nao precisa de nenhum valor nesse momento pois a função é apenas de registrar a banda e nao de atribuir um valor.

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(2000);

        LimparConsole();
        ExibirOpcoesDoMenu();

    }

    //mostrar bandas registradas
    void MostaraBandasRegistradas()
    {
        LimparConsole();
        ExibirTitiloDaOpcao("Exibindo todas as bandas registradas");

        /* for (int i = 0; i < ListaDasBandas.Count; i++)
        {
            Console.WriteLine($"Banda: {ListaDasBandas[i]}");
        } */

        foreach (string banda in bandasRegistradas.Keys) //.Keys é uma função para pegar somente as chaves, que seria o nome das bandas, do dicionário 
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nDigite uma tecla para coltar ao menu principal!\n");
        Console.ReadKey();
        LimparConsole();
        ExibirOpcoesDoMenu();
    }

    //avaliar uma banda
    void AvaliarUmaBanda()
    {
        LimparConsole();
        ExibirTitiloDaOpcao("Avaliar Banda");
        Console.Write("Digite o nome da banda que seja avaliar: ");
        string NomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(NomeDaBanda))
        {
            Console.Write($"Qaul a nota que a banda {NomeDaBanda} merece: ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[NomeDaBanda].Add(nota); //Adicionando valor em relação à banda selecionada
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso!");
            Thread.Sleep(2000);
            LimparConsole();
            ExibirOpcoesDoMenu();
        }
        else
        {
            BandaNaoEncontrada(NomeDaBanda);
        }
    }

    //media de cada banda
    void MediaDaBanda()
    {
        LimparConsole();
        ExibirTitiloDaOpcao("Exibir a média da banda");
        Console.WriteLine("Digite o nome da banda para ver a média da nota: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            List<int> notasDasBandas = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é: {notasDasBandas.Average()}"); //.Average() faz a média de algum valor
        }
        else
        {
            BandaNaoEncontrada(nomeDaBanda);
        }

        ExibirOpcoesDoMenu();

    }
}


ExibirLogo();
ExibirOpcoesDoMenu();