package org.example;

import java.util.HashMap;
import java.util.Scanner;

/*
Criar um programa que simule um
sistema de login utilizando um
dicionário para armazenar nomes
de usuário e senhas.
*/
public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        HashMap<String, String> usuarios = new HashMap<>();
        usuarios.put("caio", "123");
        usuarios.put("felipe", "321");
        usuarios.put("antonio", "231");

        System.out.println("login: ");
        String login = scanner.nextLine();


        for (String usuario : usuarios.keySet()) {
            if (usuario.equals(login)) {
                System.out.println("senha:");
                String senha = scanner.nextLine();
                if (usuarios.get(usuario).equals(senha)) {
                    System.out.println("VOCE ESTÁ DENTRO DO SISTEMA!!!");
                } else {
                    System.out.println("Login ou senha inválidos");
                    break;
                }
            }

        }
    }
}