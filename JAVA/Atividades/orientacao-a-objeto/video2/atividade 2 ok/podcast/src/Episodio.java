import java.util.ArrayList;

public class Episodio {
    private float Duracao;
    private Integer Ordem;
    private String Resumo;
    private String Titulo;
    private ArrayList<String> Convidado;

    public Episodio(float duracao, Integer ordem, String resumo, String titulo) {
        Duracao = duracao;
        Ordem = ordem;
        Resumo = resumo;
        Titulo = titulo;
        Convidado = new ArrayList<>();
    }

    public float getDuracao() {
        return Duracao;
    }

    public void setDuracao(float duracao) {
        Duracao = duracao;
    }

    public Integer getOrdem() {
        return Ordem;
    }

    public void setOrdem(Integer ordem) {
        Ordem = ordem;
    }

    public String getResumo() {
        return Resumo;
    }

    public void setResumo(String resumo) {
        Resumo = resumo;
    }

    public String getTitulo() {
        return Titulo;
    }

    public void setTitulo(String titulo) {
        Titulo = titulo;
    }

    public ArrayList<String> getConvidado() {
        return Convidado;
    }

    public void adicionarConvidados(String convidado) {
        this.Convidado.add(convidado);  // Adiciona o convidado à lista
    }

}
