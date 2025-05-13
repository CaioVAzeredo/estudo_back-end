package br.com.alura.screenmatch.service;

import com.theokanning.openai.completion.CompletionRequest;
import com.theokanning.openai.service.OpenAiService;

public class ConsultaChatGPT {

    private static final String CHAVE = System.getenv("OPENAI_API_KEY");

    public static String obterTraducao(String texto) {
        if (CHAVE == null || CHAVE.isEmpty()) {
            throw new IllegalStateException("A variável de ambiente OPENAI_API_KEY não está definida.");
        }

        OpenAiService service = new OpenAiService(CHAVE);

        CompletionRequest requisicao = CompletionRequest.builder()
                .model("gpt-3.5-turbo-instruct")
                .prompt("traduza para o português o texto: " + texto)
                .maxTokens(1000)
                .temperature(0.7)
                .build();

        var resposta = service.createCompletion(requisicao);
        return resposta.getChoices().get(0).getText().trim();
    }
}
