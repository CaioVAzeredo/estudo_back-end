using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.NovaPasta;

internal class ByteBankAtendimento
{
    private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>() {
    new ContaCorrente(95, "123456-A"){Saldo = 100, Titular = new Cliente{Cpf="11111",Nome ="Henrique"}},
    new ContaCorrente(95, "123456-B"){Saldo = 200, Titular = new Cliente{Cpf="22222",Nome ="Pedro"}},
    new ContaCorrente(94, "123456-C"){Saldo = 60, Titular = new Cliente{Cpf="33333",Nome ="Marisa"}}
};

    public void AtendimentoCliente()
    {
        try
        {
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
                try
                {
                    opcao = Console.ReadLine()[0];
                }
                catch (Exception ex)
                {

                    throw new ByteBankException(ex.Message);
                }
                switch (opcao)
                {
                    case '1':
                        CadastrarConta();
                        break;
                    case '2':
                        ListarContas();
                        break;
                    case '3':
                        RemoverContas();
                        break;
                    case '4':
                        OrdenarContas();
                        break;
                    case '5':
                        PesquisarContas();
                        break;
                    case '6':
                        EncerrarAplicacao();
                        break;
                    default:
                        Console.WriteLine("Opcao não implementada.");
                        break;
                }
            }
        }
        catch (ByteBankException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }

    private void EncerrarAplicacao()
    {
        Console.WriteLine("... Encerrando a aplicação ...");
        Console.ReadKey();
    }

    private void PesquisarContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===     REMOVER CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("Deseja pesquisar por (1) número da coanta, (2) CPF titular ou (3) Número da agência: ");
        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                {
                    Console.Write("Informe o número da Conta: ");
                    string _numeroConta = Console.ReadLine();
                    ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                    Console.WriteLine(consultaConta.ToString());
                    Console.ReadKey();
                    break;
                }
            case 2:
                {
                    Console.Write("Informe o CPF do Titular: ");
                    string _cpf = Console.ReadLine();
                    ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                    Console.WriteLine(consultaCpf.ToString());

                    Console.ReadKey();
                    break;
                }
            case 3:
                {
                    Console.Write("Informe o Número da agência: ");
                    int _numeroDaAgencia = int.Parse(Console.ReadLine());
                    var ContasPorAgencia = ConsultaPorAgencia(_numeroDaAgencia);
                    ExibirListaDeContas(ContasPorAgencia);
                    Console.ReadKey();
                    break;
                }
            default:
                Console.WriteLine("Opção não implementada.");
                break;
        }

    }

    private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
    {
        if (contasPorAgencia == null)
        {
            Console.WriteLine(" ... A consulta não retornou dados ...");
        }
        else
        {
            foreach (var item in contasPorAgencia)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
    {
        var consulta = (
                             from conta in _listaDeContas
                             where conta.Numero_agencia == numeroAgencia
                             select conta).ToList();
        return consulta;
    }

    private ContaCorrente ConsultaPorCPFTitular(string? cpf)
    {
        return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
    }

    private ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
    {
        return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
    }

    private void OrdenarContas()
    {
        _listaDeContas.Sort();
        Console.WriteLine("... Lista de contas ordenadas ...");
        Console.ReadKey();
    }

    private void RemoverContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===     REMOVER CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("INFORME O NÚMERO DA CONTA: ");
        string numeroConta = Console.ReadLine();
        ContaCorrente conta = null;
        foreach (var item in _listaDeContas)
        {
            if (item.Conta.Equals(numeroConta))
            {
                conta = item;
            }
        }
        if (conta != null)
        {
            _listaDeContas.Remove(conta);
            Console.WriteLine("... COnta removida da lista!! ...");
        }
        else
        {
            Console.WriteLine("... Conta para remoção não encontrada");
        }
        Console.ReadKey();
    }

    private void ListarContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===     LISTA DE CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        if (_listaDeContas.Count <= 0)
        {
            Console.WriteLine("... Não há contas cadastradas! ...");
            Console.ReadKey();
            return;
        }
        foreach (ContaCorrente item in _listaDeContas)
        {
            Console.WriteLine(item.ToString());
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.ReadKey();
        }

    }

    private void CadastrarConta()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===   CADASTRO DE CONTAS    ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("=== Informe dados da conta ===");
        Console.Write("Número da conta: ");
        string numeroConta = Console.ReadLine();

        Console.Write("Número da Agência: ");
        int numeroAgencia = int.Parse(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);
        Console.WriteLine($"Número da conta [NOVA]: {conta.Conta}");
        Console.Write("Informe o saldo inicial: ");
        conta.Saldo = double.Parse(Console.ReadLine());

        Console.Write("Infome nome do Titular: ");
        conta.Titular.Nome = Console.ReadLine();

        Console.Write("Infome CPF do Titular: ");
        conta.Titular.Cpf = Console.ReadLine();

        Console.Write("Infome Profissão do Titular: ");
        conta.Titular.Profissao = Console.ReadLine();

        _listaDeContas.Add(conta);
        Console.WriteLine("... Conta cadastrada com sucesso! ...");
        Console.ReadKey();
    }
}
