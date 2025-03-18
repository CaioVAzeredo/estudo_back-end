public class Triangulo extends FormaGeometrica implements ICalculavel {
    private double Altura;
    private double Base;
    private double Lado;

    public Triangulo(String cor, String nome, double altura, double base, double lado) {
        super(cor, nome);

        this.Altura = altura;
        this.Base = base;
        this.Lado = lado;
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

    public double getLado() {
        return Lado;
    }

    public void setLado(double lado) {
        Lado = lado;
    }


    @Override
    public void calcularArea() {
        System.out.println("Área do triangulo: " + (this.Base * this.Altura) / 2);
    }

    @Override
    public void calcularPerimetro() {
        System.out.println("Área do triangulo: " + (this.Base + (Lado * Lado)));
    }
}
