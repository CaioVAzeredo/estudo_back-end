double[] numeros = new double[10];
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
numeros[3] = 4;
numeros[4] = 5;
numeros[5] = 6;
numeros[6] = 7;
numeros[7] = 8;
numeros[8] = 9;
numeros[9] = 10;

void CalculoMedia(double[] numeros)
{
        double total = 0;
    for (int i = 0; i < numeros.Length; i++)
    {
        total += numeros[i];
    }
    double media = total/(numeros.Length);
    System.Console.WriteLine(media);

}

CalculoMedia(numeros);