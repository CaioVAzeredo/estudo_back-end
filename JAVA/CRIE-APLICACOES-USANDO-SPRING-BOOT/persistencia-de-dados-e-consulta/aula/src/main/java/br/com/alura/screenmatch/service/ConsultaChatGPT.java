package br.com.alura.screenmatch.service;

import com.theokanning.openai.completion.CompletionRequest;
import com.theokanning.openai.service.OpenAiService;

public class ConsultaChatGPT {
    //System.getenv serve para pegar informações da variavel de ambiente do sistema
    private static final String CHAVE = System.getenv("OPENAI_APIKEY");

    public static String obterTraducao(String texto) {
        // Caso a chave não esteja configurada
        if (CHAVE == null || CHAVE.isEmpty()) {
            System.out.println("[AVISO] Chave da OpenAI não definida. Retornando texto original.");
            return texto;
        }

        try {
            OpenAiService service = new OpenAiService(CHAVE);

            CompletionRequest requisicao = CompletionRequest.builder()
                    .model("gpt-3.5-turbo-instruct")
                    .prompt("traduza para o português o texto: " + texto)
                    .maxTokens(1000)
                    .temperature(0.7)
                    .build();

            var resposta = service.createCompletion(requisicao);
            return resposta.getChoices().get(0).getText().trim();

        } catch (Exception e) {
            System.out.println("[ERRO] Falha ao consultar a API da OpenAI: " + e.getMessage());
            return texto;
        }
    }
}