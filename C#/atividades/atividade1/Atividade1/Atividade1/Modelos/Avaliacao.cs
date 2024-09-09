namespace Atividade1.Modelos
{
    internal class Avaliacao
    {
        public Avaliacao(int nota)
        {
            Nota = nota;
        }
        public int Nota { get; }

        public static Avaliacao Perse(string texto)
        {
            int nota = int.Parse(texto);
            return new Avaliacao(nota);
        }
    }
}