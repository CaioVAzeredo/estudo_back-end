//using OpenAI_API;
using ScreenSound.Modelos;
namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {
        public  override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);

            /*---------------------------------API IA--------------------------------------------*/
            //var client = new OpenAIAPI("org-yFogRtYWDeNVoq55yCvMPUBE");
            //var chat = client.Chat.CreateConversation();
            //chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em um paragrafo. Adote um estilo informal");
            //string resposta =  chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();//alternativa para async await
            //banda.Resumo = resposta;
            /*-----------------------------------------------------------------------------------*/


            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
