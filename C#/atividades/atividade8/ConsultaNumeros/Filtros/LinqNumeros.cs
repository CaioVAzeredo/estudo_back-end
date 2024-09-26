namespace ConsultaNumeros.Filtros;

internal class LinqFilter
{
    public static void FiltrarElementosUnicos(List<double> numeros)
    {
        var elementosUnicos = numeros.Distinct().ToList();
        foreach (var numero in elementosUnicos)
        {
            System.Console.WriteLine(numero);
        }
    }
}