namespace Notificacao.Models;

internal class Email : INotificavel
{
    public void EnviarNotificacao()
    {
        Console.WriteLine("E-mail enviado com sucesso");
    }
}
