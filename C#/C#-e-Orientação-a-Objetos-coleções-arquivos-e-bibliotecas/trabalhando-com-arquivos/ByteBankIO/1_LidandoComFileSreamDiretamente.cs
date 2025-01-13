using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numerosDeBytesLidos = -1;
            var buffer = new byte[1024]; //1KB

            while (numerosDeBytesLidos != 0)
            {
                numerosDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); //public override int Read(byte[] array, int offset, int count);

                Console.WriteLine($"Bytes lidos: {numerosDeBytesLidos}");
                EscreverBuffer(buffer, numerosDeBytesLidos);

            }

            fluxoDoArquivo.Close(); //Conseguir alterar mudanças com o arquivo em uso
            Console.ReadLine();
        }


    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos); //public virtual string GetString(bytes[] bytes, int index, int count);

        Console.Write(texto);
        /*
        foreach (var meuByte in buffer)
        {
            Console.WriteLine(meuByte);
            Console.WriteLine(" ");
        }
        */
    }
}