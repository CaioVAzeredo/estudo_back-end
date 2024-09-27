using System.Text.Json;
using ConsultaNumeros.Filtros;

using (HttpClient client = new HttpClient())
{
    List<double> numeros1 = new List<double> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };
    string json = JsonSerializer.Serialize(numeros1);
    var numeros = JsonSerializer.Deserialize<List<double>>(json);
    LinqFilter.FiltrarElementosUnicos(numeros!);

}

