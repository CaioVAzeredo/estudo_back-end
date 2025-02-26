public class Gerente extends Funcionario {
    private double OrcamentoAnual;
    private String SetorGerenciado;

    public Gerente(String nome, double salario, String email, String cpf, double orcamentoAnual, String setorGerenciado) {
        super(nome, salario, email, cpf);
        OrcamentoAnual = orcamentoAnual;
        SetorGerenciado = setorGerenciado;
    }

    public double getOrcamentoAnual() {
        return OrcamentoAnual;
    }

    public void setOrcamentoAnual(double orcamentoAnual) {
        OrcamentoAnual = orcamentoAnual;
    }

    public String getSetorGerenciado() {
        return SetorGerenciado;
    }

    public void setSetorGerenciado(String setorGerenciado) {
        SetorGerenciado = setorGerenciado;
    }
}
