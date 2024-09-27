namespace NumerosPares.Filtros;

internal class LinqPares
{
    public static void FiltrarPares(List<double> numeros)
    {
        var numerosPares = numeros.Where(n => n % 2 == 0);
        Console.WriteLine($"Números pares: {string.Join(", ", numerosPares)}");
    }
}
