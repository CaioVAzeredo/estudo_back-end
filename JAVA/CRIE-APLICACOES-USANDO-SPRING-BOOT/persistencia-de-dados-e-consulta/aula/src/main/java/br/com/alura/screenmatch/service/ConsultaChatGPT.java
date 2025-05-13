package br.com.alura.screenmatch.service;

import com.theokanning.openai.completion.CompletionRequest;
import com.theokanning.openai.service.OpenAiService;

public class ConsultaChatGPT {
    public static String obterTraducao(String texto) {
        OpenAiService service = new OpenAiService("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");

        CompletionRequest requisicao = CompletionRequest.builder()
                .model("gpt-3.5-turbo-instruct")
                .prompt("traduza para o português o texto: " + texto)
                .maxTokens(1000)
                .temperature(0.7)
                .build();

        var resposta = service.createCompletion(requisicao);
        return resposta.getChoices().get(0).getText();
    }
}
