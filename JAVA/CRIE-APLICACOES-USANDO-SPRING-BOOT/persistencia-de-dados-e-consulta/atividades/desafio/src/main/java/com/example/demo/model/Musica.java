package com.example.demo.model;
import jakarta.persistence.*;


@Entity
@Table(name = "musica")
public class Musica {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String titulo;

    @ManyToOne
    @JoinColumn(name = "artista_id")
    private Artista artista_id;

    public Musica() {
    }

    public Musica(String titulo, Artista artista_id) {
        this.titulo = titulo;
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
                ", artista_id=" + artista_id;
    }
}
