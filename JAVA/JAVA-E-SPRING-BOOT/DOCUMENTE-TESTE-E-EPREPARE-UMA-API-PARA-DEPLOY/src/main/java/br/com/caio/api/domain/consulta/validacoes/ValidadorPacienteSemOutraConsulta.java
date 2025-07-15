package br.com.caio.api.domain.consulta.validacoes;

import br.com.caio.api.domain.ValidacaoException;
import br.com.caio.api.domain.consulta.ConsultaRepository;
import br.com.caio.api.domain.consulta.DadosAgendamentoConsulta;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class ValidadorPacienteSemOutraConsulta implements ValidadorAgendamentoDeConsulta{
    @Autowired
    private ConsultaRepository repository;

    public void validar(DadosAgendamentoConsulta dados) {
        var priemiroHorario = dados.data().withHour(7);
        var ultimoHorario = dados.data().withHour(18);
        var pacientePossuiOutraConusltaNoDia = repository.existsByPacienteIdAndDataBetween(dados.idPaciente(), priemiroHorario, ultimoHorario);

        if(pacientePossuiOutraConusltaNoDia){
            throw new ValidacaoException("Paciente ja possui uma consulta agendada nesse dia");
        }
    }
}
