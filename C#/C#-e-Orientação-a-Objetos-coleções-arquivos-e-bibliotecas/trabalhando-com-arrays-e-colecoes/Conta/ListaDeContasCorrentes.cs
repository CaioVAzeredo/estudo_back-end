namespace trabalhando.Conta;

public class listaDeContasCorrentes
{
    private ContaCorrente[] _itens = null!;
    private int _proximaPosicao = 0;
    public listaDeContasCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente item)
    {
        System.Console.WriteLine($"Item na posição {_proximaPosicao}");
        VerificarCapacidade(_proximaPosicao + 1);
        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }

    private void VerificarCapacidade(int tamanhoNecessario)
    {
        if (_itens.Length >= tamanhoNecessario)
        {
            return;
        }
        else
        {
            System.Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens = novoArray;
        }

    }

    public void FiltraMaiorSaldo()
    {
        double ultimoValor = 0;
        foreach (var item in _itens)
        {
            if (item.Saldo > ultimoValor)
            {
                ultimoValor = item.Saldo;
            }
        }
        Console.WriteLine(ultimoValor);
    }
}