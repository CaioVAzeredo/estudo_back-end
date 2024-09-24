try
{
    Console.WriteLine("Insira um numero: ");
    string num1 = Console.ReadLine()!;
    double.TryParse(num1!, out double numero1);

    Console.WriteLine("Insira outro numero: ");
    string num2 = Console.ReadLine()!;
    double.TryParse(num2!, out double numero2);

    double divisao = numero1 / numero2;

    Console.WriteLine($"A divisao dos numeros {numero1} e {numero2} é: {divisao}");
}
catch (Exception ex)
{
    Console.WriteLine($"erro {ex.Message}");
}