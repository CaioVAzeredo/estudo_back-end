package com.example.demo.service;

public interface IConverteDados {
    <T> T obterDados(String json, Class<T> classe);
}
