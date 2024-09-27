namespace Produto.Filtro;

internal class LinqMedia
{
    public static void FiltrarMedia(Dictionary<string, double> produtos)
    {
        Console.WriteLine($"Media dos produtos: R${produtos.Values.Average()}");
    }
}