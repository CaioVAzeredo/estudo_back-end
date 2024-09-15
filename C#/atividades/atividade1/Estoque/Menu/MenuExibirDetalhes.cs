using Atividade2.Modelos;
namespace Atividade2.Menu;


internal class MenuExibirDetales : Menu
{
    public override void Executar(Dictionary<int, Produto> produtosRegistrados)
    {
        base.Executar(produtosRegistrados);

        ExibirTituloDaOpcao("Detalhes dos Produtos");

        foreach (KeyValuePair<int, Produto> entry in produtosRegistrados)
        {
            Produto produto = entry.Value;
            Console.WriteLine($"{produto.Nome} -> {produto.Quantidade}");
        }


    }

}