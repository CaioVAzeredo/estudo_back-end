package com.example.demo;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.util.Scanner;

@SpringBootApplication
public class DemoApplication {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Digite  um número para iniciar a contagem: ");
        int numero = scanner.nextInt();


        for (int i = 1; i <= numero; i++) {
            System.out.println(i);
        }

    }

}
