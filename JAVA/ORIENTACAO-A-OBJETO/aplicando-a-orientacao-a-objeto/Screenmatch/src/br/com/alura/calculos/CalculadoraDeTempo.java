package br.com.alura.calculos;

import br.com.alura.sreenmatch.modelos.Filme;
import br.com.alura.sreenmatch.modelos.Serie;
import br.com.alura.sreenmatch.modelos.Titulo;

public class CalculadoraDeTempo {
    private int tempoTotal;

    public int getTempoTotal() {
        return tempoTotal;
    }


    public void inclui(Titulo titulo) {
        this.tempoTotal += titulo.getDuracaoMinuto();
    }
}
