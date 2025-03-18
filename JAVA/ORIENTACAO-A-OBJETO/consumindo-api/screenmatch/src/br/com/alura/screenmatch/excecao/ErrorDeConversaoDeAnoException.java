package br.com.alura.screenmatch.excecao;

public class ErrorDeConversaoDeAnoException extends RuntimeException {
    private String mensagem;

    public ErrorDeConversaoDeAnoException(String mensagem) {
        this.mensagem = mensagem;
    }


    public String getMensagem() {
        return this.mensagem;
    }
}
