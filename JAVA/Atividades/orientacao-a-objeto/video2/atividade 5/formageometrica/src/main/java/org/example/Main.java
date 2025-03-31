package org.example;

/*
 * Criar uma interface chamada
 * IForma que declare métodos
 * para calcular a área e o
 * perímetro de uma forma geométrica.
 * Implemente esta interface em duas
 * classes: Circulo e Retangulo.
 * */
public class Main {
    public static void main(String[] args) {
        Circulo circulo = new Circulo(5);
        circulo.calculaArea();
        circulo.calculaPerimetro();

        Retangulo retangulo = new Retangulo(10, 5);
        retangulo.calculaArea();
        retangulo.calculaPerimetro();
    }
}