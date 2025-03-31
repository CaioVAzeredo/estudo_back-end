package org.example;

import java.util.HashMap;
import java.util.Map;

/*
Criar um programa que gerencie o estoque de uma loja.
Utilize um dicionário para armazenar produtos e suas
quantidades em estoque e mostre, a partir do nome de
 um produto, sua quantidade em estoque.
 */
public class Main {
    public static void main(String[] args) {
        Map<String, Integer> estoque = new HashMap<>();
        estoque.put("lapis", 3);
        estoque.put("caneta", 5);
        estoque.put("borracha", 2);

        for (String produto : estoque.keySet()) {
            System.out.println("O " + produto + " tem a quantidade: " + estoque.get(produto));
        }
    }
}