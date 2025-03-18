import Filmes.Artista;
import Filmes.Filme;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Filme filme1 = new Filme("Homem aranha", 160);
        filme1.setElenco(new Artista("Tom Holand", 28));
        filme1.setElenco(new Artista("Zendaia", 25));

        Filme filme2 = new Filme("Inception", 120);
        filme2.setElenco(new Artista("Leonardo DiCaprio", 49));
        filme2.setElenco(new Artista("Elliot Page", 37));

        Filme filme3 = new Filme("The Batman", 152);
        filme3.setElenco(new Artista("Robert Pattinson", 38));

        Filme filme4 = new Filme("Matrix", 130);
        filme4.setElenco(new Artista("Keanu Reeves", 59));

        Filme filme5 = new Filme("Vingadores", 180);
        filme5.setElenco(new Artista("Robert Downey Jr.", 58));


        List<Filme> filmes = new ArrayList<>();
        filmes.add(filme1);
        filmes.add(filme2);
        filmes.add(filme3);
        filmes.add(filme4);
        filmes.add(filme5);

        System.out.println("Meus filmes favoritos:");
        for (Filme filme : filmes) {
            filme.mostrarDetalhes();
        }
    }
}