using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785,40, Caio Viana";

            var bytes = Encoding.UTF8.GetBytes(contaComoString);
            fluxoDeArquivo.Write(bytes, 0, bytes.Length);

        }
    }
}

