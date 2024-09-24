List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

try
{
    Console.WriteLine(numeros[10]);

}
catch (Exception e)
{
    Console.WriteLine($"O erro é =====> {e.Message}");
}