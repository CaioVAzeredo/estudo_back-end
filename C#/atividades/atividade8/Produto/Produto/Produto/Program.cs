using Produto.Filtro;
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    Dictionary<string, double> produtos = new Dictionary<string, double>
        {
            { "Camiseta", 29.99 },
            { "Calça Jeans", 79.90 },
            { "Tênis", 199.90 },
            { "Boné", 39.90 }
        };

    string produtosString = JsonSerializer.Serialize(produtos);
    var produtosEmString = JsonSerializer.Deserialize<Dictionary<string, double>>(produtosString);

    LinqMedia.FiltrarMedia(produtosEmString);
}