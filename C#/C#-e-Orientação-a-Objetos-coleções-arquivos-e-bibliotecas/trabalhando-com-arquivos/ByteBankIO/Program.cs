using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        CriarArquivo();
        Console.ReadLine();
        //    var enderecoDoArquivo = "contas.txt";

        //    using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        //    {
        //        var leitor = new StreamReader(fluxoDeArquivo);

        //        //var linha = leitor.ReadLine(); //ler a primeira linha
        //        //var text = leitor.ReadToEnd(); //leitura total 

        //        //int num = leitor.Read(); // retorna o primeiro exadecimal 

        //        while (!leitor.EndOfStream)
        //        {
        //            var linha = leitor.ReadLine();
        //            Console.WriteLine(linha);

        //            var contaCorrente = ConverterStringParaContaCorrente(linha);

        //            var msg = $"Conta número: {contaCorrente.Numero}, ag: {contaCorrente.Agencia}, saldo:{contaCorrente.Saldo}";
        //            Console.WriteLine(msg);
        //        }
        //    }

        //    Console.ReadLine();
        //}

        //static ContaCorrente ConverterStringParaContaCorrente(string? linha)
        //{

        //    var campos = linha.Split(',');

        //    var agencia = campos[0];
        //    var numero = campos[1];
        //    var saldo = campos[2].Replace('.', ','); // Replace serve para mudar uma coisa por outra
        //    var nomeTitular = campos[3];

        //    var agenciaComInt = int.Parse(agencia);
        //    var numeroComInt = int.Parse(numero);
        //    var saldoComDouble = double.Parse(saldo);

        //    var titular = new Cliente();
        //    titular.Nome = nomeTitular;

        //    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        //    resultado.Depositar(saldoComDouble);
        //    resultado.Titular = titular;

        //    return resultado;

    }

}