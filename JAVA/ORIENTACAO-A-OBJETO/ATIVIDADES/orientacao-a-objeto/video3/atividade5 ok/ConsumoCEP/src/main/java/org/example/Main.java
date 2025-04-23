import java.io.FileWriter;
import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.net.http.HttpResponse.BodyHandlers;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.FieldNamingPolicy;
import org.example.Titulo;
import org.example.TituloOmdb;

public class Main {
    public static void main(String[] args) throws IOException, InterruptedException {
        Scanner leitura = new Scanner(System.in);
        String busca = "";
        List<Titulo> CEPs = new ArrayList<>();
        Gson gson = (new GsonBuilder()).setPrettyPrinting().create();

        System.out.println("Digite o CEP: ");

        while (!busca.equalsIgnoreCase("sair")) {
            busca = leitura.nextLine();
            if (busca.equalsIgnoreCase("sair")) {
                break;
            }
            String cep = "https://viacep.com.br/ws/" + busca + "/json/";
            try {
                /*Consumo da api*/
                HttpClient client = HttpClient.newHttpClient();
                HttpRequest request = HttpRequest.newBuilder().uri(URI.create(cep)).build();
                HttpResponse<String> response = client.send(request, BodyHandlers.ofString());
                String json = (String) response.body();
                /*------------------------------------*/
                TituloOmdb meutituloOmdb = (TituloOmdb) gson.fromJson(json, TituloOmdb.class);
                /*------------------------------------*/
                Titulo meuTitulo = new Titulo(meutituloOmdb);
                /*------------------------------------*/
                System.out.println("CEP convertido: ");
                System.out.println(meuTitulo);

                CEPs.add(meuTitulo);
            } catch (InterruptedException e) {
                System.out.println(e);
            }
            System.out.println(CEPs);
            FileWriter escrita = new FileWriter("CEPs.txt");
            escrita.write(gson.toJson(CEPs));
            escrita.close();
        }
    }
}