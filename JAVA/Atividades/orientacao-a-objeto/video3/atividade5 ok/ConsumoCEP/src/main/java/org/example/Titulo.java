package org.example;

public class Titulo {
    private String bairro;
    private String localidade;
    private String uf;

    public Titulo(TituloOmdb meuTituloOmdb) {
        this.bairro = meuTituloOmdb.bairro();
        this.localidade = meuTituloOmdb.localidade();
        this.uf = meuTituloOmdb.uf();
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        this.bairro = bairro;
    }

    public String getLocalidade() {
        return localidade;
    }

    public void setLocalidade(String localidade) {
        this.localidade = localidade;
    }

    public String getUf() {
        return uf;
    }

    public void setUf(String uf) {
        this.uf = uf;
    }

    @Override
    public String toString() {
        return "Titulo{" +
                "bairro='" + bairro + '\'' +
                ", localidade='" + localidade + '\'' +
                ", uf='" + uf + '\'' +
                '}';
    }
}
