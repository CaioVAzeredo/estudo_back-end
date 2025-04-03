package com.example.demo.model;

public class Tarefa {
    private String descricao;
    private boolean concluida;
    private String pessoaResponsavel;

    public Tarefa(String descricao, boolean concluida, String pessoaResponsavel) {
        this.descricao = descricao;
        this.concluida = concluida;
        this.pessoaResponsavel = pessoaResponsavel;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public String getPessoaResponsavel() {
        return pessoaResponsavel;
    }

    public void setPessoaResponsavel(String pessoaResponsavel) {
        this.pessoaResponsavel = pessoaResponsavel;
    }

    public boolean isConcluida() {
        return concluida;
    }

    public void setConcluida(boolean concluida) {
        this.concluida = concluida;
    }

    @Override
    public String toString() {
        return "Tarefa{" +
                "descricao='" + descricao + '\'' +
                ", concluida=" + concluida +
                ", pessoaResponsavel='" + pessoaResponsavel + '\'' +
                '}';
    }
}
