package com.example.demo.principal;

import com.example.demo.models.DadosVeiculos;
import com.example.demo.service.ConsumoApi;
import com.example.demo.service.ConverteDados;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Principal {
    Scanner leitura = new Scanner(System.in);
    ConsumoApi consumoApi = new ConsumoApi();
    ConverteDados converteDados = new ConverteDados();

    private final String ENDERECO = "https://parallelum.com.br/fipe/api/v1";

    public void exibir() {
        System.out.println("*** OPÇÕES ***");
        System.out.println("Carros \nMotos \nCaminhoes \nDigite uma das opções para consultar valores:\n ");
        String opcaoVeiculo = leitura.nextLine();

        String json = consumoApi.obterDados(ENDERECO + "/" + opcaoVeiculo + "/marcas");

        List<DadosVeiculos> veiculos = new ArrayList<>();


    }
}
