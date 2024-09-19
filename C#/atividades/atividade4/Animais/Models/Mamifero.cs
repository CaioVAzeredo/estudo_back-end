namespace Animais.Models;

internal  class Mamifero : Animal{

    public string CorDopelo { get; set; }
    public bool TemPelo { get; set; }

    public Mamifero(string nome, int idade, float peso, string corDopelo, bool temPelo) : base(nome, idade, peso)
    {
        CorDopelo = corDopelo;
        TemPelo = temPelo;
    }

    public void Amamentar(){
        Console.WriteLine("A mamãe está amamentando o filhote");
    }
    public override void EmitirSom()
    {
        Console.WriteLine("O mamífero está emitindo um som de mamífero");
    }
    public override void Mover()
    {
        Console.WriteLine("O mamífero está se movendo");
    }
}
