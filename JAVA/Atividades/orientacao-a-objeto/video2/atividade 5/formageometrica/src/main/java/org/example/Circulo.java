package org.example;

public class Circulo implements IForma {
    private Double pi = 3.14;
    private double raio;

    public Circulo(double raio) {
        this.raio = raio;
    }

    public Double getPi() {
        return pi;
    }

    public void setPi(Double pi) {
        this.pi = pi;
    }

    public double getRaio() {
        return raio;
    }

    public void setRaio(double raio) {
        this.raio = raio;
    }

    @Override
    public void calculaArea() {
        double area = pi * (raio * raio);
        System.out.println("O valor da Area = " + area + "cm");
    }

    @Override
    public void calculaPerimetro() {
        double perimetro = 2 * pi * raio;
        System.out.println("O valor da Area = " + perimetro + "cm");
    }
}
