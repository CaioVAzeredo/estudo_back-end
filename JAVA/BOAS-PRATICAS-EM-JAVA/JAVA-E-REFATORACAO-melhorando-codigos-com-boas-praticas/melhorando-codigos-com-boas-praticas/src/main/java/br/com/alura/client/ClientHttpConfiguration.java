package br.com.alura.client;

import com.google.gson.Gson;
import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;

public class ClientHttpConfiguration {
    public static HttpResponse<String> dispararRequisicaoGet(String uri) throws IOException, InterruptedException{
        HttpClient client = HttpClient.newHttpClient();

        HttpRequest request = HttpRequest.newBuilder()
                .uri(URI.create(uri))
                .method("GET", HttpRequest.BodyPublishers.noBody())
                .build();
        return client.send(request, HttpResponse.BodyHandlers.ofString());
    }
    public static HttpResponse<String> DispararRequisisaoPost(String uri, Object object) /*Object object serve para receber qualquer tipo de objeto */ throws IOException, InterruptedException{
        HttpClient client = HttpClient.newHttpClient();

        HttpRequest request = HttpRequest.newBuilder()
                .uri(URI.create(uri))
                .header("Content-Type", "application/json")
                .method("POST", HttpRequest.BodyPublishers.ofString(new Gson().toJson(object)))
                .build();

        return client.send(request, HttpResponse.BodyHandlers.ofString());
    }
}
