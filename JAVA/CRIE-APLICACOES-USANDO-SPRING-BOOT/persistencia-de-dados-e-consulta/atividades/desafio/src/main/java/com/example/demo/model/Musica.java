package com.example.demo.model;

import jakarta.persistence.*;

import java.time.LocalDate;

@Entity
@Table(name = "musica")
public class Musica {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String titulo;

    private double duracao;
    private LocalDate data_lancamento;
    private String genero;

    @ManyToOne
    @JoinColumn(name = "artista_id")
    private Artista artista_id;

    public Musica() {
    }

    public Musica(String titulo, double duracao, LocalDate data_lancamento, String genero, Artista artista_id) {
        this.titulo = titulo;
        this.duracao = duracao;
        this.data_lancamento = data_lancamento;
        this.genero = genero;
        this.artista_id = artista_id;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public double getDuracao() {
        return duracao;
    }

    public void setDuracao(double duracao) {
        this.duracao = duracao;
    }

    public LocalDate getData_lancamento() {
        return data_lancamento;
    }

    public void setData_lancamento(LocalDate data_lancamento) {
        this.data_lancamento = data_lancamento;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public Artista getArtista_id() {
        return artista_id;
    }

    public void setArtista_id(Artista artista_id) {
        this.artista_id = artista_id;
    }

    @Override
    public String toString() {
        return "id=" + id +
                ", titulo='" + titulo + '\'' +
                ", duracao=" + duracao +
                ", data_lancamento=" + data_lancamento +
                ", genero='" + genero + '\'' +
                ", artista_id=" + artista_id;
    }
}
