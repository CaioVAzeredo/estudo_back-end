public class Analista extends Funcionario {
    private String AreaAtuacao;
    private String Skills;

    public Analista(String nome, double salario, String email, String cpf, String areaAtuacao, String skills) {
        super(nome, salario, email, cpf);
        AreaAtuacao = areaAtuacao;
        Skills = skills;
    }

    public String getAreaAtuacao() {
        return AreaAtuacao;
    }

    public void setAreaAtuacao(String areaAtuacao) {
        AreaAtuacao = areaAtuacao;
    }

    public String getSkills() {
        return Skills;
    }

    public void setSkills(String skills) {
        Skills = skills;
    }
}
