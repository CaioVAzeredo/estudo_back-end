using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro {ex}");
    }

}