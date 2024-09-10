namespace ScreenSound.Modelos;

internal class Avaliacao 
{

    public int Nota { get; }
    
    public Avaliacao(int nota) {
        Nota = nota;

    }

    public  static Avaliacao Parse(string texto) {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}

