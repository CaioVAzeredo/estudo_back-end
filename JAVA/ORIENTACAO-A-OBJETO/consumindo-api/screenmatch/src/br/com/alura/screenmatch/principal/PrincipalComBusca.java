package br.com.alura.screenmatch.principal;

import br.com.alura.screenmatch.excecao.ErrorDeConversaoDeAnoException;
import br.com.alura.screenmatch.modelos.Titulo;
import br.com.alura.screenmatch.modelos.TituloOmdb;
import com.google.gson.FieldNamingPolicy;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.util.Scanner;

public class PrincipalComBusca {
    public static void main(String[] args) throws IOException, InterruptedException {
        Scanner leitura = new Scanner(System.in);

        System.out.println("Digite um filme para busca:");
        var busca = leitura.nextLine();
        String endereco = "https://www.omdbapi.com/?t=" + busca.replace(" ", "+") + "&apikey=71d504e2";

        /*-----------------------------------------------------------------------------------*/
        /*Consumo da api*/
        try {
            HttpClient client = HttpClient.newHttpClient();
            HttpRequest request = HttpRequest.newBuilder()
                    .uri(URI.create(endereco))
                    .build();

            HttpResponse<String> response = client
                    .send(request, HttpResponse.BodyHandlers.ofString());

            /*-----------------------------------------------------------------------------------*/
            /*Resultado do consumo da api*/
            String json = response.body();
            System.out.println("JSON pego da api");
            System.out.println(response.body());

            /*-----------------------------------------------------------------------------------*/
            /*Uso do Gson*/
            /*O Gson serve para serializar um JSON */
            Gson gson = new GsonBuilder()
                    .setFieldNamingPolicy(FieldNamingPolicy.UPPER_CAMEL_CASE)
                    .create(); //Pega o objeto e diminui as letras

            TituloOmdb meuTituloOmdb = gson.fromJson(json, TituloOmdb.class);
            System.out.println("JSON serializado");
            System.out.println(meuTituloOmdb);
            /*-----------------------------------------------------------------------------------*/
            /*Adicionando o Gson no meu objeto */
            Titulo meuTitulo = new Titulo(meuTituloOmdb);
            System.out.println("Titulo convertido ");
            System.out.println(meuTitulo);
        } catch (NumberFormatException error) {
            System.out.println("Aconteceu um erro: ");
            System.out.println(error.getMessage());
        } catch (IllegalArgumentException error) {
            System.out.println("Algum erro de argumento na busca, verifique o endereço");
        } catch (ErrorDeConversaoDeAnoException error) {
            System.out.println(error.getMensagem());
        }
        System.out.println("O processo finalizou corretamente");
    }
}
