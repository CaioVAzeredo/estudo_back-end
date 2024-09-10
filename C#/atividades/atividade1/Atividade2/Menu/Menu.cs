using Atividade2.Modelos;

namespace Atividade2.Menu;

internal class Menu{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + '\n');
    }
    public virtual void Executar(Dictionary<int, Produto> produtosRegistrados) {
        Console.Clear();
    }
}
