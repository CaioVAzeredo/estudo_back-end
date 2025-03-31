package org.example;

public class Retangulo implements IForma {
    private double altura;
    private double base;

    public Retangulo(double altura, double base) {
        this.altura = altura;
        this.base = base;
    }

    @Override
    public void calculaArea() {
        double Area = base * altura;
        System.out.println("A área do retangulo é de: " + Area + "cm");
    }

    @Override
    public void calculaPerimetro() {
        double Area = base + base + altura + altura;
        System.out.println("A área do retangulo é de: " + Area + "cm");
    }
}
