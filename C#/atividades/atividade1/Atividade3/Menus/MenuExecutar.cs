using Atividade3.Menus;
using Atividade3.Modelos;

internal class MenuExecutar : Menu
{
    public override void Executar(Dictionary<string, Perguntas> questoes)
    {
        foreach (KeyValuePair<string, Perguntas> questao in questoes)
        {
            ExibirTituloDaPergunta(questao.Key);
            Console.WriteLine("\nQual a sua resposta?");
            Escolha(questao.Value.Resposta);
        }
    }
}