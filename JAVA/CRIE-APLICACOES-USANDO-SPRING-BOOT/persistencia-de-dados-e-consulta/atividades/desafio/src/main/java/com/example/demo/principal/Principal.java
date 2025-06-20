package com.example.demo.principal;

import com.example.demo.model.Artista;
import com.example.demo.model.Musica;
import com.example.demo.repository.ArtistaRepository;
import com.example.demo.repository.MusicaRepository;
import com.example.demo.service.ConsumoApi;
import com.example.demo.service.ConverteDados;

import java.util.*;

public class Principal {
    private Scanner leitura = new Scanner(System.in);
    private ArtistaRepository repositorioArtista;
    private MusicaRepository repositorioMusica;

    private ConsumoApi consumo = new ConsumoApi();
    private ConverteDados converteDados = new ConverteDados();

    private Optional<Artista> artistaBuscado;
    private List<Artista> artistas = new ArrayList<>();

    public Principal(ArtistaRepository repositorioArtista, MusicaRepository repositorioMusica) {
        this.repositorioMusica = repositorioMusica;
        this.repositorioArtista = repositorioArtista;
    }

    public void exibirMenu() {
        var opcao = -1;
        while (opcao != 0) {
            var menu = """
                    1- Cadastrar artistas
                    
                    2- Cadastrar músicas
                    
                    3- Listar músicas
                    
                    4- Buscar músicas por artistas
                    
                    5- Pesquisar dados sobre um artista
                    
                    9- Sair
                    """;

            System.out.println(menu);
            opcao = leitura.nextInt();
            leitura.nextLine();

            switch (opcao) {
                case 1:
                    cadastrarArtista();
                    break;
                case 2:
                    cadastrarMusica();
                    break;
                case 0:
                    System.out.println("Saindo...");
                    break;
                default:
                    System.out.println("Opção inválida");
            }
        }
    }

    private void cadastrarMusica() {
        System.out.println("Informe o nome da musica: ");
        String nomeMusica = leitura.nextLine();

        System.out.println("Informe o artista: ");
        String artista = leitura.nextLine();
        Artista nomeArtista = new Artista(artista);

        Musica musica = new Musica(nomeMusica);
        musica.setArtista_id(nomeArtista);

    }

    private void listarMusica(){

    }


    private void cadastrarArtista() {
        System.out.println("Informe o nome do artista: ");
        String nome = leitura.nextLine();

        System.out.println("Informe o tipo desse artista: (Solo, dupla, banda)");
        String tipoArtista = leitura.nextLine();
        Artista artista = new Artista(nome, tipoArtista);
        repositorioArtista.save(artista);

        System.out.println("Cadastrar outro artista?(S/N)");
        String cadastrarOutroArtista = leitura.nextLine();
        if (cadastrarOutroArtista.equalsIgnoreCase("S")) {
            cadastrarArtista();
        }
        System.out.println(artista.toString());

    }

    private void listarArtistaBuscadas() {
        artistas = repositorioArtista.findAll();
        artistas.stream()
                .sorted(Comparator.comparing(Artista::getNome))
                .forEach(System.out::println);
    }
}
