package org.example;

public class Veiculo implements IPilotavel, IVoavel{
    private String modelo;
    private String fabricante;
    private int ano;

    public Veiculo(String modelo, int ano, String fabricante) {
        this.modelo = modelo;
        this.ano = ano;
        this.fabricante = fabricante;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    public String getFabricante() {
        return fabricante;
    }

    public void setFabricante(String fabricante) {
        this.fabricante = fabricante;
    }

    @Override
    public void isPilotavel() {
        System.out.println("É pilotável");
    }

    @Override
    public void isVoavel() {
        System.out.println("Não é voavel");
    }
}