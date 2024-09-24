namespace Notificacao.Models;

internal class Sms : INotificavel
{
    public void EnviarNotificacao()
    {
        Console.WriteLine("sms enviado com sucesso");
    }
}
