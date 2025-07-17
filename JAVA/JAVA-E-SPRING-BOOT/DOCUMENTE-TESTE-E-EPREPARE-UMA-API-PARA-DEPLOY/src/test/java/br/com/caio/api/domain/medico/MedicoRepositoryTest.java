package br.com.caio.api.domain.medico;

import br.com.caio.api.domain.consulta.Consulta;
import br.com.caio.api.domain.endereco.DadosEndereco;
import br.com.caio.api.domain.paciente.DadosCadastroPaciente;
import br.com.caio.api.domain.paciente.Paciente;
import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.jdbc.AutoConfigureTestDatabase;
import org.springframework.boot.test.autoconfigure.orm.jpa.DataJpaTest;
import org.springframework.boot.test.autoconfigure.orm.jpa.TestEntityManager;
import org.springframework.test.context.ActiveProfiles;

import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.temporal.TemporalAdjuster;
import java.time.temporal.TemporalAdjusters;
import java.util.Random;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.jupiter.api.Assertions.*;

@DataJpaTest
@AutoConfigureTestDatabase(replace = AutoConfigureTestDatabase.Replace.NONE)
@ActiveProfiles("test")
class MedicoRepositoryTest {

    @Autowired
    private MedicoRepository medicoRepository;

    @Autowired
    private TestEntityManager em;

//    @Test
//    @DisplayName("Deveria devolver null quando unico medico cadastrado nao esta disponivel na data")
//    void escolherMedicoAleatorioLivreNaDataCenario1() {
//        // Arrange
//        var dataConsulta = LocalDate.now()
//                .with(TemporalAdjusters.next(DayOfWeek.MONDAY))
//                .atTime(10, 0);
//
//        // Cadastra médico com CRM único
//        var medico = cadastrarMedico(
//                "Dr. João Silva",
//                "joao.silva@voll.med",
//                gerarCrmUnico(),
//                Especialidade.CARDIOLOGIA
//        );
//
//        // Cadastra paciente com CPF único
//        var paciente = cadastrarPaciente(
//                "Maria Oliveira",
//                "maria@email.com",
//                gerarCpfValido()
//        );
//
//        // Agenda consulta
//        cadastrarConsulta(medico, paciente, dataConsulta);
//
//        // Act
//        var medicoDisponivel = medicoRepository
//                .escolherMedicoAleatorioLivreNaData(Especialidade.CARDIOLOGIA, dataConsulta);
//
//        // Assert
//        assertThat(medicoDisponivel)
//                .as("Não deveria encontrar médico disponível pois o único cadastrado já tem consulta marcada")
//                .isNull();
//    }


    @Test
    @DisplayName("Deveria devolver medico quando ele estiver disponivel na data")
    void escolherMedicoAleatorioLivreNaDataCenario2() {

        //given ou arrange
        var proximaSegundaAs10 = LocalDate.now()
                .with(TemporalAdjusters
                        .next(DayOfWeek.MONDAY))
                .atTime(10, 0);

        //when ou act
        var medico = cadastrarMedico("Medico", "email@gmamil.com", gerarCrmUnico(), Especialidade.CARDIOLOGIA);

        //then ou assert
        var medicoLivre = medicoRepository.escolherMedicoAleatorioLivreNaData(Especialidade.CARDIOLOGIA, proximaSegundaAs10);
        Assertions.assertThat(medicoLivre).isEqualTo(medico);
    }

    private void cadastrarConsulta(Medico medico, Paciente paciente, LocalDateTime data) {
        em.persist(new Consulta(null, medico, paciente, data));
    }

    private Medico cadastrarMedico(String nome, String email, String crm, Especialidade especialidade) {
        var medico = new Medico(dadosMedico(nome, email, crm, especialidade));
        em.persist(medico);
        return medico;
    }

    private Paciente cadastrarPaciente(String nome, String email, String cpf) {

        var paciente = new Paciente(dadosPaciente(nome, email, cpf));
        em.persist(paciente);
        return paciente;
    }

    private DadosCadastroMedico dadosMedico(String nome, String email, String crm, Especialidade especialidade) {
        return new DadosCadastroMedico(
                nome,
                email,
                "61999999999",
                crm,
                especialidade,
                dadosEndereco()
        );
    }
    private String gerarCrmUnico() {
        return String.valueOf(new Random().nextInt(10000, 99999));
    }

    private String gerarCpfValido() {
        return String.format("%011d", new Random().nextLong(10000000000L, 99999999999L));
    }


    private DadosCadastroPaciente dadosPaciente(String nome, String email, String cpf) {
        return new DadosCadastroPaciente(
                nome,
                email,
                "61999999999",
                cpf,
                dadosEndereco()
        );
    }

    private DadosEndereco dadosEndereco() {
        return new DadosEndereco(
                "rua xpto",
                "bairro",
                "00000000",
                "Brasilia",
                "DF",
                null,
                null
        );
    }
}


