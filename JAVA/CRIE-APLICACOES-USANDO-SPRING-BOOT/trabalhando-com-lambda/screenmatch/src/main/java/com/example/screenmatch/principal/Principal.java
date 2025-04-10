package com.example.screenmatch.principal;

import com.example.screenmatch.model.DadosEpisodios;
import com.example.screenmatch.model.DadosSeries;
import com.example.screenmatch.model.DadosTemporada;
import com.example.screenmatch.model.Episodio;
import com.example.screenmatch.service.ConsumoApi;
import com.example.screenmatch.service.ConverteDados;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Principal {
    Scanner leitura = new Scanner(System.in);
    ConsumoApi consumoApi = new ConsumoApi();
    ConverteDados conversor = new ConverteDados();


    //final é utilizado para variaveis que não são mutaveis e com isso é obrigatorio a passagem da informação ja de cara
    private final String ENDERECO = "https://www.omdbapi.com/?t=";
    private final String API_KEY = "&apikey=6585022c";


    public void exibeMenu() {
        System.out.println("Digite o nome da serie para buscar");
        String nomeSerie = leitura.nextLine();

        //replace é passado dois parametros. o primeiro é o que tem e o segundo é para subistituir o do primeiro por esse. nesse caso vai trocar o espaço por +
        String json = consumoApi.obterDados(ENDERECO + nomeSerie.replace(" ", "+") + API_KEY);

        DadosSeries dados = conversor.obterDados(json, DadosSeries.class);
        System.out.println(dados);

        List<DadosTemporada> temporadas = new ArrayList<>();

        for (int i = 1; i <= dados.totalTemporadas(); i++) {
            json = consumoApi.obterDados(ENDERECO + nomeSerie.replace(" ", "+") + "&season" + i + API_KEY);
            DadosTemporada dadosTemporada = conversor.obterDados(json, DadosTemporada.class);
            temporadas.add(dadosTemporada);
        }

        temporadas.forEach(System.out::println);

        //utilizando o lambda. bem semelhante a arrowfunction do JS. dessa vez utilizando o forEach
        temporadas.forEach(temporada -> temporada.episodios().forEach(episodio -> System.out.println(episodio.titulo())));

        List<DadosEpisodios> dadosEpisodios = temporadas.stream()
                .flatMap(temporada -> temporada.episodios().stream()) //flatMap serve para juntar a lista da lista em uma só
                .collect(Collectors.toList()); //o .collect(Collectors.toList()) tem a função de listar, essa lista é mutavel diferente do toList que é imutavel

        System.out.println("Top 5 episodios");
        dadosEpisodios.stream()
                .filter(episodio -> !episodio.avaliacao().equalsIgnoreCase("N/A"))
                .sorted(Comparator.comparing(DadosEpisodios::avaliacao).reversed()) //sorteia fazendo uma comparação da avaliação dos episodios e no final usa no modo reverso
                .limit(5)
                .forEach(System.out::println);

        List<Episodio> episodio = ;

    }
}
