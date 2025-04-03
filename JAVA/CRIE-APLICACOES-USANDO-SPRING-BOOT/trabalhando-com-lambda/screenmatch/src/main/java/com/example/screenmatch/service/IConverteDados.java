package com.example.screenmatch.service;

public interface IConverteDados {
    /*<T> T é referente a um tipo generico de dado*/
    /*Class<T> é referente a uma classe generica*/
    <T> T obterDados(String json, Class<T> classe);
}
