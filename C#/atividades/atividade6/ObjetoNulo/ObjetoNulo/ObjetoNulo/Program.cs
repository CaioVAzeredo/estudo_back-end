using ObjetoNulo;

Pessoa caio = null;
try
{
caio.Andar("Andando...");

}
catch (Exception e)
{
    Console.WriteLine($"O erro ===> {e.Message}");
}