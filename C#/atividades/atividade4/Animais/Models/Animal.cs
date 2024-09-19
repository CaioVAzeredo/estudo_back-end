namespace Animais.Models;

internal class Animal
{
    public string Nome { get; set; }

    public int Idade { get; set; }
    public float Peso { get; set; }


    public Animal(string nome, int idade, float peso)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som do animal");
    }
    public virtual void Mover()
    {
        Console.WriteLine("O animal está se movendo");
    }
    public virtual void Comer()
    {
        Console.WriteLine("O animal está comendo");
    }

}