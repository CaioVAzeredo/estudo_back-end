package br.com.caio.api.domain.consulta;

import jakarta.validation.constraints.Future;
import jakarta.validation.constraints.NotNull;

import java.time.LocalDate;
import java.time.LocalDateTime;

public record DadosAgendamentoConsulta(
        Long id,

        @NotNull
        Long idPaciente,

        @NotNull
        Long idMedico,

        @NotNull
        @Future
        LocalDateTime data
) {
}
