package br.com.caio.api.domain.consulta.validacoes;

import br.com.caio.api.domain.ValidacaoException;
import br.com.caio.api.domain.consulta.DadosAgendamentoConsulta;
import br.com.caio.api.domain.medico.MedicoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class ValidadorMedicoAtivo implements ValidadorAgendamentoDeConsulta{
    @Autowired
    private MedicoRepository repository;

    public void validar(DadosAgendamentoConsulta dados) {
        if (dados.idMedico() == null) {
            return;
        }

        var medicoEstaAtivo = repository.findAtivoById(dados.idMedico());
            if (!medicoEstaAtivo) {
                throw new ValidacaoException("Consulta não pode ser agendada com médico");
        }
    }
}
