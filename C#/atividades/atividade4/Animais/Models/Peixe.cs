namespace Animais.Models;

internal class Peixe : Animal
{
    public string TipoDeAgua { get; set; }
    public bool TemEscama { get; set; }

    public Peixe(string nome, int idade, float peso, string tipoDeAgua, bool temEscama) : base(nome, idade, peso)
    {
        TipoDeAgua = tipoDeAgua;
        TemEscama = temEscama;
    }

    public void Nadar()
    {
        Console.WriteLine("Peixe está nadando");
    }
    public override void EmitirSom()
    {
        Console.WriteLine("Peixe está emitindo som");
    }
    public override void Mover()
    {
        Console.WriteLine("Peixe está se movendo");
    }
}