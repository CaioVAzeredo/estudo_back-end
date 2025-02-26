package Filmes;

import java.util.ArrayList;
import java.util.List;

public class Artista {
    private String Nome;
    private int Idade;
    private List<Filme> AtuacaoEmFilmes = new ArrayList<>();

    public String getNome() {
        return Nome;
    }

    public void setNome(String nome) {
        Nome = nome;
    }

    public int getIdade() {
        return Idade;
    }

    public void setIdade(int idade) {
        Idade = idade;
    }

    public List<Filme> getAtuacaoEmFilmes() {
        return AtuacaoEmFilmes;
    }

    public void setAtuacaoEmFilmes(Filme atuacaoEmFilmes) {
        AtuacaoEmFilmes.add(atuacaoEmFilmes);
    }

    public Artista(String nome, int idade) {
        Nome = nome;
        Idade = idade;
    }

}
