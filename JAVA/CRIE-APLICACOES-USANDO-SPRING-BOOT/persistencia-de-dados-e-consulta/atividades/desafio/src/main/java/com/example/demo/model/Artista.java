package com.example.demo.model;

import jakarta.persistence.*;

@Entity
@Table(name = "serie")
public class Artista {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
    private String nacionalidade;
    private String genero;

    @ManyToOne
    private Musica musicas;


    public Artista() {

    }

    public Artista(String nome, String nacionalidade, String genero, Musica musicas) {
        this.nome = nome;
        this.nacionalidade = nacionalidade;
        this.genero = genero;
        this.musicas = musicas;
    }


    public Musica getMusicas() {
        return musicas;
    }

    public void setMusicas(Musica musicas) {
        this.musicas = musicas;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public String getNacionalidade() {
        return nacionalidade;
    }

    public void setNacionalidade(String nacionalidade) {
        this.nacionalidade = nacionalidade;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    @Override
    public String toString() {
        return "id=" + id +
                ", nome='" + nome + '\'' +
                ", nacionalidade='" + nacionalidade + '\'' +
                ", genero='" + genero + '\'' +
                ", musicas=" + musicas;
    }
}
