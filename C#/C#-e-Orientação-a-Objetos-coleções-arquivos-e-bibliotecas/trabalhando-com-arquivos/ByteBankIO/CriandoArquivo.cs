using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785,40, Caio Viana";

            var bytes = Encoding.UTF8.GetBytes(contaComoString);
            fluxoDeArquivo.Write(bytes, 0, bytes.Length);



        }
    }
    static void CopiarArquivo()
    {
        var arquivoOriginal = new FileStream("c:/temp/teste.txt", FileMode.Open);
        var arquivoNovo = new FileStream("c:/temp/teste_copia.txt", FileMode.Create);
        var buffer = new byte[1024];

        using (arquivoOriginal)
        using (arquivoNovo)
        {
            var bytesLidos = -1;
            while (bytesLidos != 0)
            {
                bytesLidos = arquivoOriginal.Read(buffer, 0, 1024);
                arquivoNovo.Write(buffer, 0, bytesLidos);
            }
        }

    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456, 789, 1011.12, Caio Viana");
        }
    }

    static void TestarEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 10000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); // Despeja o buffer para o stram, em outras palavras, grava de uma vez no arquivo salvo no ssd
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                Console.ReadLine();
            }
        }
    }


}

