public class Main {
    public static void main(String[] args) {
        Circulo circulo = new Circulo("Azul", "Circulo", 5);
        circulo.calcularPerimetro();
        circulo.calcularArea();

        Quadrado quadrado = new Quadrado("Amarelo", "Quadrado", 9, 10);
        quadrado.calcularArea();
        quadrado.calcularPerimetro();

        Triangulo triangulo = new Triangulo("Azul", "Triangulo", 5, 25, 10);
        triangulo.calcularArea();
        triangulo.calcularPerimetro();
    }
}