public class Programador extends Funcionario {
    private String LinguagensDominadas;
    private boolean TrabalhoRemoto;

    public Programador(String nome, double salario, String email, String cpf) {
        super(nome, salario, email, cpf);
    }

    public String getLinguagensDominadas() {
        return LinguagensDominadas;
    }

    public void setLinguagensDominadas(String linguagensDominadas) {
        LinguagensDominadas = linguagensDominadas;
    }

    public boolean isTrabalhoRemoto() {
        return TrabalhoRemoto;
    }

    public void setTrabalhoRemoto(boolean trabalhoRemoto) {
        TrabalhoRemoto = trabalhoRemoto;
    }

    @Override
    public void calculoBonificacao() {
        System.out.println("Bonificação por mês: " + getSalario() * 0.2 + "\nBonificação com com o salário: " + getSalario() * 1.2);
    }
}
