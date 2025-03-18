using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
<<<<<<< HEAD

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
=======
        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
>>>>>>> 0b2a89b9462178d483acae7b5c9504a2fd22fcc1
        {
            var contaComoString = "456,78945,4785.40,Gustavo Santos";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaComoString);

<<<<<<< HEAD


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
=======
            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        }
    }
>>>>>>> 0b2a89b9462178d483acae7b5c9504a2fd22fcc1

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            for (var i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); // Despeja o buffer para o Stream!
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                Console.ReadLine();
            }
        }
    }
}