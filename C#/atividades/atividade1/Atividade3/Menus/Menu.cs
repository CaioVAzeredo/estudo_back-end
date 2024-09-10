using Atividade3.Modelos;

namespace Atividade3.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo) {
         int quantidadeDeLetras = titulo.Length;
         string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
         System.Console.WriteLine(asterisco);
         System.Console.WriteLine(titulo);
         System.Console.WriteLine(asterisco);
          }

    public virtual void Executar(){
        Console.Clear();
    }
}