using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine(); //ler a primeira linha
            //var text = leitor.ReadToEnd(); //leitura total 

            //int num = leitor.Read(); // retorna o primeiro exadecimal 

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }

        Console.ReadLine();
    }

}