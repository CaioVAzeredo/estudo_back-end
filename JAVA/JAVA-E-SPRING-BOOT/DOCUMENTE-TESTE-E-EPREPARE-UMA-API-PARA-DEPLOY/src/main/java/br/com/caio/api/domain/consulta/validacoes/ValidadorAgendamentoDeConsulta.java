package br.com.caio.api.domain.consulta.validacoes;

import br.com.caio.api.domain.consulta.DadosAgendamentoConsulta;

public interface ValidadorAgendamentoDeConsulta {
    void validar(DadosAgendamentoConsulta dados);
}
