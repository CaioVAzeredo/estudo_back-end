package Filmes;

import java.util.ArrayList;
import java.util.List;

public class Filme {
    private String Titulo;
    private float Duracao;
    private List<Artista> Elenco = new ArrayList<>();


    public String getTitulo() {
        return Titulo;
    }

    public void setTitulo(String titulo) {
        Titulo = titulo;
    }

    public Float getDuracao() {
        return Duracao;
    }

    public void setDuracao(Float duracao) {
        Duracao = duracao;
    }

    public List<Artista> getElenco() {
        return Elenco;
    }

    public void setElenco(Artista artista) {
        this.Elenco.add(artista);
        //o "this" solo indica a classe que está sendo usada, nesse caso está sendo passado a classe Filme para adicionarFilme
        artista.setAtuacaoEmFilmes(this);
    }

    public Filme(String titulo, float duracao) {
        Titulo = titulo;
        Duracao = duracao;
    }


    public void mostrarDetalhes() {
        System.out.println("Filme: " + Titulo + ", Duração: " + Duracao + " minutos");
        System.out.println("Elenco:");
        for (Artista artista : Elenco) {
            System.out.println(artista.getNome() + " (" + artista.getIdade() + " anos)");
        }
    }
}
