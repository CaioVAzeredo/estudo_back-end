package com.example.demo.repository;

import com.example.demo.model.Musica;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface MusicaRepository extends JpaRepository<Musica, Long> {
    @Query("SELECT m FROM Musica m JOIN m.artista_id a WHERE UPPER(a.nome) = UPPER(:artista)")
    List<Musica> buscarMusicaPorArtista(@Param("artista") String artista);
}
