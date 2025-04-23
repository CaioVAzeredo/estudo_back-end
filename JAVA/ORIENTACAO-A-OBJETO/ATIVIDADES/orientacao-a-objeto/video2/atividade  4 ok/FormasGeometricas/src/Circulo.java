public class Circulo extends FormaGeometrica implements ICalculavel {
    private double Pi = 3.14;
    private double Raio;

    public Circulo(String cor, String nome, double raio) {
        super(cor, nome);

        this.Raio = raio;
    }


    @Override
    public void calcularArea() {
        System.out.println("Área do círculo: " + this.Pi * this.Raio * this.Raio);
    }

    @Override
    public void calcularPerimetro() {
        System.out.println("Perímetro do círculo: " + (2 * this.Pi + this.Raio));
    }

}
