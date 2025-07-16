package br.com.caio.api.domain.consulta;

import br.com.caio.api.domain.ValidacaoException;
import br.com.caio.api.domain.consulta.validacoes.ValidadorAgendamentoDeConsulta;
import br.com.caio.api.domain.medico.Medico;
import br.com.caio.api.domain.medico.MedicoRepository;
import br.com.caio.api.domain.paciente.Paciente;
import br.com.caio.api.domain.paciente.PacienteRepository;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class AgendaDeConsultas {

    @Autowired
    private ConsultaRepository consultaRepository;

    @Autowired
    private MedicoRepository medicoRepository;

    @Autowired
    private PacienteRepository pacienteRepository;

    @Autowired //lista de validadores onde tudo que for extends de da interface ValidadorAgendamentoDeConsulta, vai para essa lista.
    private List<ValidadorAgendamentoDeConsulta> validadores;



    public DadosDetalhamentoConsulta agendar(DadosAgendamentoConsulta dados) {
        if(!pacienteRepository.existsById(dados.idPaciente())){
            throw new ValidacaoException("Id do paciente informado não existente!");
        }

        if(dados.idMedico() != null && !medicoRepository.existsById(dados.idMedico())){
            throw new ValidacaoException("Id do médico informado não existe!");
        }

        validadores.forEach(v -> v.validar(dados));

        var paciente = pacienteRepository.findById(dados.idPaciente()).get();
        var medico = escolherMedico(dados);

        var consulta = new Consulta(null, medico, paciente, dados.data());
        consultaRepository.save(consulta);

        return new DadosDetalhamentoConsulta(consulta);
    }

    private Medico escolherMedico(DadosAgendamentoConsulta dados) {
    if(dados.idMedico() != null){
        return medicoRepository.getReferenceById(dados.idMedico());
    }
    return null;
    }
}