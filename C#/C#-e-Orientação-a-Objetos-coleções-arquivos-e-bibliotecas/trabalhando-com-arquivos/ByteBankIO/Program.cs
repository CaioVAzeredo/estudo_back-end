using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
      
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456, 789, 1011.12, Caio Viana");
            }
        
        Console.ReadLine();


        //    var enderecoDoArquivo = "contas.txt";
=======
        //Console.WriteLine("Digite o seu nome:");
        //string nome = Console.ReadLine();
>>>>>>> 0b2a89b9462178d483acae7b5c9504a2fd22fcc1

        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);

        //foreach (var linha in linhas)
        //{
        //    Console.WriteLine(linha);
        //}

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

        Console.WriteLine("Aplicação Finalizada ...");
        Console.ReadLine();
    }
}