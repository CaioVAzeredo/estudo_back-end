package com.example.demo.repository;

import com.example.demo.model.Artista;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface ArtistaRepository extends JpaRepository<Artista, Long> {

    Optional<Artista> findByNomeIgnoreCase(String artista);

}
