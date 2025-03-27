package org.example;
/*
Crie um programa que implemente um quiz
simples de perguntas e respostas.
Utilize um dicionário para armazenar as
perguntas e as respostas corretas
*/

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Map<String, String> quiz = new HashMap<>();
        quiz.put("Qual é a capital do Brasil?", "Brasília");
        quiz.put("Quanto é 5 + 3?\n", "8");
        quiz.put("Qual é a cor do céu em um dia claro?\n", "Azul");
        quiz.put("Qual linguagem estamos usando neste programa?\n", "Java");
        quiz.put("Qual planeta é conhecido como o planeta vermelho?\n", "Marte");

        String resposta = "";

        while (!resposta.equalsIgnoreCase("sair")) {
            int contador = 1;
            String saida = "";

            for (String pergunta : quiz.keySet()) {
                if (contador == quiz.size()) {
                    System.out.println("Gostaria de Refazer o quiz? s = sim, n = nao");
                    saida = scanner.nextLine();
                    if (saida.equalsIgnoreCase("s")) {
                        break;
                    } else if (saida.equalsIgnoreCase("n")) {
                        return;
                    } else {
                        System.out.println("Resposta inválida");
                        return;
                    }
                }
                System.out.println(pergunta);
                resposta = scanner.nextLine();
                if (resposta.equalsIgnoreCase("sair")) {
                    break;
                }

                if (resposta.equalsIgnoreCase(quiz.get(pergunta))) {
                    System.out.println("Resposta correta!!");
                } else {
                    System.out.println("ERRADO!!! A resposta correta é: " + quiz.get(pergunta));
                }
                contador++;
            }

        }
    }
}