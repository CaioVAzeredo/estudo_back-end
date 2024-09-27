using System.Text.Json;
using NumerosPares.Filtros;

using (HttpClient client = new HttpClient())
{
    List<double> numeros1 = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
    string json = JsonSerializer.Serialize(numeros1);
    var numeros = JsonSerializer.Deserialize<List<double>>(json);
    LinqPares.FiltrarPares(numeros!);

}

