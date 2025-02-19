public class Funcionario implements ICalculo {
    private String Nome;
    private double Salario;
    private String email;
    private String cpf;

    public Funcionario(String nome, double salario, String email, String cpf) {
        Nome = nome;
        Salario = salario;
        this.email = email;
        this.cpf = cpf;
    }

    public String getNome() {
        return Nome;
    }

    public void setNome(String nome) {
        Nome = nome;
    }

    public double getSalario() {
        return Salario;
    }

    public void setSalario(double salario) {
        Salario = salario;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }


    @Override
    public void calculoBonificacao() {

    }
}
