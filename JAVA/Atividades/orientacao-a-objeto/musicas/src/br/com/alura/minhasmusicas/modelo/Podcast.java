package br.com.alura.minhasmusicas.modelo;

public class Podcast extends Audio {
    private String host;
    private String descricao;

    public String getHost() {
        return host;
    }

    public void setHost(String host) {
        this.host = host;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    @Override
    public String toString() {
        return "Podcast{" +
                "host='" + host + '\'' +
                ", descricao='" + descricao + '\'' +
                " Titulo=" + getTitulo() +
                '}';
    }
}
