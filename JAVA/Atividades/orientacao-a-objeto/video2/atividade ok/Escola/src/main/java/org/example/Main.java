package org.example;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/*
Criar um dicionário que represente um aluno,
com uma lista de notas, e mostre a média de
suas notas na tela.
*/
public class Main {

    public static void main(String[] args) {
        Map<String, List<Float>> alunos = new HashMap<>();

        ArrayList<Float> notasAluno1 = new ArrayList<>();
        notasAluno1.add(1.9F);
        notasAluno1.add(3.5F);
        notasAluno1.add(4.6F);

        ArrayList<Float> notasAluno2 = new ArrayList<>();
        notasAluno2.add(3F);
        notasAluno2.add(5.7F);
        notasAluno2.add(7.2F);

        alunos.put("Caio", notasAluno1);
        alunos.put("Levy", notasAluno2);

        for (String aluno : alunos.keySet()) {
            List<Float> notas = alunos.get(aluno);

            float soma = 0;

            for (Float nota : notas) {
                soma += nota;
            }
            float media = soma / notas.size();
            System.out.println(String.format("A média da nota do aluno %s é: %.2f", aluno, media));
        }
    }
}