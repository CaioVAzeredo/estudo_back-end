package com.example.demo;

import com.example.demo.principal.Principal;
import com.example.demo.repository.ArtistaRepository;

import com.example.demo.repository.MusicaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;


@SpringBootApplication
public class DemoApplication implements CommandLineRunner {

    @Autowired
    private ArtistaRepository repositorioArtista;
    private MusicaRepository repositorioMusica;

    public static void main(String[] args) {
        SpringApplication.run(DemoApplication.class, args);
    }

    @Override
    public void run(String... args) throws Exception {
        Principal principal = new Principal(repositorioArtista, repositorioMusica);
        principal.exibirMenu();
    }
}
