using Atividade3.Modelos;

namespace Atividade3.Menus;

internal class Menu
{
    public void ExibirTituloDaPergunta(string titulo)
    {
        System.Console.WriteLine(titulo);
    }
    public void Escolha(int resposta)
    {
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
        if (opcaoEscolhidaNumerica == 1 || opcaoEscolhidaNumerica == 2 || opcaoEscolhidaNumerica == 3 || opcaoEscolhidaNumerica == 4)
        {
            if (opcaoEscolhidaNumerica == resposta)
            {
                Console.WriteLine("Resposta correta!!");
            }
            else
            {
                Console.WriteLine($"resposta incorreta, a resposta correta é a {resposta}");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Insira um valor valido");
        }
        Thread.Sleep(2000);
    }
    public virtual void Executar(Dictionary<string, Perguntas> questoes)
    {
        Console.Clear();
    }
}