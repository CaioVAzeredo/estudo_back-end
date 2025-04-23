package com.example.screenmatch.model;

import com.fasterxml.jackson.annotation.JsonAlias;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

/*@JsonAlias seria como um apelido para se referenciar ao Json*/
@JsonIgnoreProperties(ignoreUnknown = true)
public record DadosSeries(@JsonAlias({"Title", "Titulo"}) String titulo,
                          @JsonAlias("totalSeasons") Integer totalTemporadas,
                          @JsonAlias("imdbRating") String avaliacao) {
}