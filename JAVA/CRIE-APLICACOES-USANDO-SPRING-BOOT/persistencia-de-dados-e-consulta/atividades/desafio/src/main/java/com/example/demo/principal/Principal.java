package com.example.demo.principal;

import com.example.demo.model.Artista;
import com.example.demo.model.Musica;
import com.example.demo.repository.ArtistaRepository;
import com.example.demo.repository.MusicaRepository;
import com.example.demo.service.ConsumoApi;
import com.example.demo.service.ConverteDados;

import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.Stream;

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
                case 3:
                    listarMusicas();
                    break;
                case 4:
                    listarMusicasPorArtistas();
                    break;
                case 0:
                    System.out.println("Saindo...");
                    break;
                default:
                    System.out.println("Opção inválida");
            }
        }
    }

    private void listarMusicasPorArtistas() {

    }

    private void cadastrarMusica() {

        System.out.println("Informe o nome da musica: ");
        String nomeMusica = leitura.nextLine();

        System.out.println("Artistas cadastrados: ");
        listarArtistaBuscados().stream()
                .map(a -> a.getNome())
                .forEach(System.out::println);

        System.out.println("Informe o artista: ");
        String artista = leitura.nextLine();

        Optional<Artista> filtroArtista = repositorioArtista.findByNome(artista);

        if (filtroArtista.isEmpty()) {
            System.out.println("Artista não encontrado");
            exibirMenu();
        }

        Artista artistaFiltroFinal = filtroArtista.get();

        System.out.println("Informe a duração da música: ");
        Double duracao = leitura.nextDouble();

        Musica musica = new Musica(nomeMusica, artistaFiltroFinal, duracao);

        repositorioMusica.save(musica);
        System.out.println("Musica salva com sucesso!! ");

        System.out.println("Cadastrar outro artista?(S/N)");
        String cadastrarOutraMusica = leitura.nextLine();
        if (cadastrarOutraMusica.equalsIgnoreCase("S")) {
            cadastrarMusica();
        }
    }

    private void listarMusicas() {

    }

    private void cadastrarArtista() {
        System.out.println("Informe o nome do artista: ");
        String nome = leitura.nextLine();

        System.out.println("Informe o tipo desse artista: (Solo, dupla, banda)");
        String tipoArtista = leitura.nextLine();
        Artista artista = new Artista(nome, tipoArtista);
        repositorioArtista.save(artista);
        System.out.println("Artista salvo com sucesso!! ");

        System.out.println("Cadastrar outro artista?(S/N)");
        String cadastrarOutroArtista = leitura.nextLine();
        if (cadastrarOutroArtista.equalsIgnoreCase("S")) {
            cadastrarArtista();
        }
        System.out.println(artista.toString());

    }

    private List<Artista> listarArtistaBuscados() {
        List<Artista> artistas = repositorioArtista.findAll();
        artistas.stream()
                .sorted(Comparator.comparing(Artista::getNome));
        return artistas;
    }
}
