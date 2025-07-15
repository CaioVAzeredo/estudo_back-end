package br.com.caio.api.domain.consulta.validacoes;

import br.com.caio.api.domain.ValidacaoException;
import br.com.caio.api.domain.consulta.ConsultaRepository;
import br.com.caio.api.domain.consulta.DadosAgendamentoConsulta;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class ValidadorMedicoComOutraConsulta implements ValidadorAgendamentoDeConsulta{
    @Autowired
    private ConsultaRepository repository;

    public void validar(DadosAgendamentoConsulta dados){
        var medicoPossuiOutraConsultaNoMesmoHorario = repository.existsByMedicoIdAndData(dados.idMedico(), dados.data());

        if(medicoPossuiOutraConsultaNoMesmoHorario){
            throw new ValidacaoException("Médico ja possui outra consulta agendada nesse mesmo horário");
        }
    }
}
