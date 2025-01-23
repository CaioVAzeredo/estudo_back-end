using System.Text;

partial class Program
{
    static void EscritaBinario()
    {

        using (var fs = new FileStream("contasExportadas.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);
            escritor.Write(45665);
            escritor.Write(4000.50);
            escritor.Write("Caio Viana");
        }

    }
        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contasExportadas.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
            }
        }
}
