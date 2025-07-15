package br.com.caio.api.domain.paciente;

import jakarta.validation.constraints.NotNull;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

public interface PacienteRepository extends JpaRepository<Paciente, Long> {
    @Query("""
            SELECT p.ativo
            FROM pacientes p
            WHERE p.id = :id
            """)
    Boolean findAtivoById(Long idPaciente);
}
