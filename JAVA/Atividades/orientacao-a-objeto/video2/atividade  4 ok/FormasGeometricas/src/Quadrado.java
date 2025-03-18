public class Quadrado extends FormaGeometrica implements ICalculavel {
    private double Altura;
    private double Base;

    public Quadrado(String cor, String nome, double altura, double base) {
        super(cor, nome);

        this.Altura = altura;
        this.Base = base;
    }

    public double getAltura() {
        return Altura;
    }

    public void setAltura(double altura) {
        Altura = altura;
    }

    public double getBase() {
        return Base;
    }

    public void setBase(double base) {
        Base = base;
    }


    @Override
    public void calcularArea() {
        System.out.println("Área do quadrado: " + this.Altura * this.Altura);
    }

    @Override
    public void calcularPerimetro() {
        System.out.println("Perímetro do quadrado: " + this.Altura * 4);
    }
}
