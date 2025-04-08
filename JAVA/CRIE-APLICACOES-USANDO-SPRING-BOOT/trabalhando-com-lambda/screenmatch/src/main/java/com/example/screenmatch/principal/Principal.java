package com.example.screenmatch.principal;

import com.example.screenmatch.model.DadosSeries;
import com.example.screenmatch.model.DadosTemporada;
import com.example.screenmatch.service.ConsumoApi;
import com.example.screenmatch.service.ConverteDados;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Principal {
    Scanner leitura = new Scanner(System.in);
    ConsumoApi consumoApi = new ConsumoApi();
    ConverteDados conversor = new ConverteDados();


    //final é utilizado para variaveis que não são mutaveis e com isso é obrigatorio a passagem da informação ja de cara
    private final String ENDERECO = "https://www.omdbapi.com/?t=";
    private final String API_KEY = "&apikey=6585022c";


    public void exibeMenu(){
        System.out.println("Digite o nome da serie para buscar");
        String nomeSerie = leitura.nextLine();

        //replace é passado dois parametros. o primeiro é o que tem e o segundo é para subistituir o do primeiro por esse. nesse caso vai trocar o espaço por +
        String json = consumoApi.obterDados(ENDERECO + nomeSerie.replace(" ", "+")+ API_KEY);

        DadosSeries dados = conversor.obterDados(json, DadosSeries.class);
        System.out.println(dados);

        List<DadosTemporada> temporadas = new ArrayList<>();

		for(int i =1; i<=dados.totalTemporadas(); i++){
        json = consumoApi.obterDados(ENDERECO + nomeSerie.replace(" ", "+")+"&season"+i+ API_KEY);
			DadosTemporada dadosTemporada= conversor.obterDados(json, DadosTemporada.class);
			temporadas.add(dadosTemporada);
		}

		temporadas.forEach(System.out::println);
    }
}
