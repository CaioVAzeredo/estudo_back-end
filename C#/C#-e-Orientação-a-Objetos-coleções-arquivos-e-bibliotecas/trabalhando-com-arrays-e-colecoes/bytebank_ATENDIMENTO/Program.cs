void TesteArreyInt()
{
int[] idades = new int[4];
idades[0] = 30;
idades[1] = 40;
idades[2] = 17;
idades[3] = 21;

    Console.WriteLine($"Tamanho do array: {idades.Length}");

    float acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        acumulador += idade;
        Console.WriteLine($"a idade do indice [{i}] - tem a idade: {idade}. \r\n ");
    }
    Console.WriteLine($"A média das idades é: {acumulador/idades.Length}");
}
//TesteArreyInt(); 

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for(int i = 0; i< arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i+1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach(string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca)){
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }

    }
}
//TestaBuscarPalavra();

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//CalcularMediana(amostra);
void CalcularMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para calculo da media está vazio ou nulo.");
    }
    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;

    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"a mediana é: {mediana}");
}

