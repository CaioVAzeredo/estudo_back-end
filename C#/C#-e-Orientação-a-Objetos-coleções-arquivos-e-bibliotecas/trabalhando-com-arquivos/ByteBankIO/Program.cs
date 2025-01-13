using ByteBankIO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numerosDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; //1KB

        while (numerosDeBytesLidos != 0)
        {
            numerosDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); //public override int Read(byte[] array, int offset, int count);
            EscreverBuffer(buffer);

        }
    }

    static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();
        
        var texto = utf8.GetString(buffer);
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