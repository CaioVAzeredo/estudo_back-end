package br.com.caio.api.domain.paciente;

import br.com.caio.api.domain.medico.Especialidade;

public record DadosListagemPaciente(
        Long id,
        String nome,
        String email,
        String dpf
) {
    public DadosListagemPaciente (Paciente paciente){
        this(paciente.getId(), paciente.getNome(), paciente.getEmail(), paciente.getCpf());
    }
}
