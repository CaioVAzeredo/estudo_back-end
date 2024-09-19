namespace Animais.Models;


internal class Ave : Animal
{
    public string CorDasPenas { get; set; }
    public float TamanhoDasAsas { get; set; }

    public Ave(string nome, int idade, float peso, string corDasPenas, float tamanhoDasAsas) : base(nome, idade, peso)
    {
        CorDasPenas = corDasPenas;
        TamanhoDasAsas = tamanhoDasAsas;
    }

public void Voar(){
    Console.WriteLine("Ave está voando");
}
    public override void EmitirSom()
    {
        Console.WriteLine("Ave está emitindo som");
    }
    public override void Mover()
    {
        Console.WriteLine("Ave está se movendo");
    }
}