package br.com.alura.domain;

public class Abrigo {
    private Long id;
    private String nome;
    private String telefone;
    private String email;

    public Abrigo(String nome, String telefone, String email){
        this.nome = nome;
        this.telefone = telefone;
        this.email = email;
    }

    public Long getId() {
        return id;
    }

    public String getNome() {
        return nome;
    }
}
