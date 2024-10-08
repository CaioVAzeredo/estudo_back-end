﻿#region Exemplo em C#
//ArrayInt();
//TestaBuscaPalavra();
// void ArrayInt()
//  {
//     int[] idades = new int[5];
//     idades[0] = 30;
//     idades[1] = 40;
//     idades[2] = 17;
//     idades[3] = 21;
//     idades[4] = 18;

//     Console.WriteLine($"Tamanho do Array {idades.Length}");

//     int acumulador = 0;
//     for (int i = 0; i < idades.Length; i++)
//     {
//         int idade = idades[i];
//         System.Console.WriteLine($"Ídades[{i}] = {idade}");
//         acumulador += idade;
//     }
//     int media = acumulador / idades.Length;
//     System.Console.WriteLine($"A média é: {media}");
// }
// void TestaBuscaPalavra()
// {
//     string[] arrayDePalavras = new string[5];

//     for (int i = 0; i < arrayDePalavras.Length; i++)
//     {
//         Console.WriteLine($"Digite {i + 1}° Palavra:   ");
//         arrayDePalavras[i] = Console.ReadLine()!;

//     }
//     Console.WriteLine("Digite palavra a se encontrada: ");
//     var busca = Console.ReadLine();

//     foreach (string palavra in arrayDePalavras)
//     {
//         if (palavra.Equals(busca))
//         {
//             Console.WriteLine($"Palavra encontrada = {busca}");
//             break;
//         }
//     }
// }

// Array amostra = new double[5];/* Array.CreateInstance(typeof(double), 5); */
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

//TestaMediana(amostra);
/* void TestaMediana(Array array)
{
    if (array == null || array.Length == 0)
    {
        System.Console.WriteLine("Array para calculo mediana está vazio ou nulo");
    }

    double[] numerosOrdenados = (double[])array!.Clone(); //(double[])array = convertendo o objeto array para um array de double[]. Clone() = clona o objeto
    Array.Sort(numerosOrdenados); // Ordena em ordem decrescente

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;

    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    System.Console.WriteLine($"A mediana é de: {mediana}");


} */

using System.Formats.Asn1;
using trabalhando.Conta;

void TestaArrayDeContaCorrentes()
{
    listaDeContasCorrentes listaDeContas = new listaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(1, "1000.0-C", 1000));
    listaDeContas.Adicionar(new ContaCorrente(1, "500.0-B", 500));
    listaDeContas.Adicionar(new ContaCorrente(1, "2000.0-A", 10000));
    listaDeContas.Adicionar(new ContaCorrente(1, "2000.0-A", 15023));
    listaDeContas.Adicionar(new ContaCorrente(1, "2000.0-A", 1.3));
    listaDeContas.Adicionar(new ContaCorrente(1, "2000.0-A", 400000));
    listaDeContas.Adicionar(new ContaCorrente(1, "2000.0-A", 3.99));
    listaDeContas.Adicionar(new ContaCorrente(1, "2000.0-A", 0));
    listaDeContas.Adicionar(new ContaCorrente(1, "2000.0-A", 50));
    //listaDeContas.FiltraMaiorSaldo();

    var ContaCaio = new ContaCorrente(1, "123456-X", 0);
    listaDeContas.Adicionar(ContaCaio);
    // listaDeContas.ExibirLista();
    // System.Console.WriteLine("==================");
    // listaDeContas.Remover(ContaCaio);
    // listaDeContas.ExibirLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i]; //indexador é para facilitar o acesso de um elemento de um array ou lista

        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Agencia}");
    }

}

//TestaArrayDeContaCorrentes();
#endregion

void AtendimentoCliente()
{
    Console.WriteLine("Bem vindo ao atendimento do banco");
    char opcao = '0';
    while (opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===       Atendimento       ===");
        Console.WriteLine("===1 - Cadastrar Conta      ===");
        Console.WriteLine("===2 - Listar Contas        ===");
        Console.WriteLine("===3 - Remover Conta        ===");
        Console.WriteLine("===4 - Ordenar Contas       ===");
        Console.WriteLine("===5 - Pesquisar Conta      ===");
        Console.WriteLine("===6 - Sair do Sistema      ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()![0];
        switch (opcao)
        {
            case '1': CadastrarConta();
                break;
                default: Console.WriteLine("Opcao nao implementada");
                break;
        }
    }

}

AtendimentoCliente();